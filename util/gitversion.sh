#!/usr/bin/env bash
##
# Run gitversion to set version numbers.
#
# NOTE: While GitVersion has an MSBuild Task (https://gitversion.net/docs/usage/msbuild),
# is does not work with .NET Standard projects. So, this scripting hack takes its place.
#
# WARNING: this code may be fragile under parallel builds, which is the default for
# the `dotnet` command. So far though, it works--at least on macOS 🤞. (This is not my
# favorite strategy.)
##

set -o nounset
set -o errexit

##
# fix csproj spacing that dotnet-gitversion messes up (stdin -> stdout)
function fixup_csproj_spacing() {
    gawk '
        # Put back blank lines removed by dotnet-gitversion
        /^\s*<PropertyGroup>\s*$/ { print "" }
        /^\s*<ItemGroup>\s*$/ { print "" }
        /^\s*<Target .*>\s*$/ { print "" }
        /^\s*<\/Project>\s*$/ { print "" }

        # copy all lines not a version
        { print }
    ' | uniq
}

##
# Rename if csproj changed
# $1 = original csproj file
# $2 = re-spaced csproj file
function roll_csproj() {
    cmp -s "$1" "$2" && rm "$2" || mv "$2" "$1"
}

VERSION_FILE='AssemblyVersionInfo.cs'
SCRIPT="$(basename "$0")"

if [[ "$1" == "update" ]]; then

    # restore dotnet-gitversion tool
    dotnet tool restore

    # update the project files and show the version
    echo "InformationalVersion -> $(dotnet tool run dotnet-gitversion /showvariable InformationalVersion /updateprojectfiles)"
    for csproj in *.csproj; do
        cat "$csproj" | fixup_csproj_spacing >"$csproj.$$"
        roll_csproj "$csproj" "$csproj.$$"
    done

elif [[ "$1" == "clean" ]]; then

    # clean all projects (usually just one)
    for csproj in *.csproj; do
        gawk '
          # Skip version lines
            /^\s*<AssemblyVersion>.*<\/AssemblyVersion>\s*$/ ||
            /^\s*<FileVersion>.*<\/FileVersion>\s*$/ ||
            /^\s*<InformationalVersion>.*<\/InformationalVersion>\s*$/ ||
            /^\s*<Version>.*<\/Version>\s*$/ {
              next
            }
          # Copy everything else
            { print }
        ' "$csproj" | fixup_csproj_spacing > "$csproj.$$"
        roll_csproj "$csproj" "$csproj.$$"
    done

else
    echo "unknown subcommand: $1"
    exit 1
fi

# end
