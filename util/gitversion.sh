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

VERSION_FILE='AssemblyVersionInfo.cs'
SCRIPT="$(basename "$0")"

echo "$SCRIPT $*"

#set | sed "s/^/$SCRIPT: /"

if [[ "$1" == "update" ]]; then

    dotnet tool restore
    echo "InformationalVersion -> $(dotnet tool run dotnet-gitversion /showvariable InformationalVersion /updateprojectfiles)"

elif [[ "$1" == "clean" ]]; then

    for csproj in *.csproj; do
        echo "$SCRIPT: clean $csproj"
        gawk '
            # Skip version lines
            /^\s*<AssemblyVersion>.*<\/AssemblyVersion>\s*$/ { next }
            /^\s*<FileVersion>.*<\/FileVersion>\s*$/ { next }
            /^\s*<InformationalVersion>.*<\/InformationalVersion>\s*$/ { next }
            /^\s*<Version>.*<\/Version>\s*$/ { next }

            # Put back blank lines removed by dotnet-gitversion
            /^\s*<PropertyGroup>\s*$/ { print "" }
            /^\s*<ItemGroup>\s*$/ { print "" }
            /^\s*<Target .*>\s*$/ { print "" }
            /^\s*<\/Project>\s*$/ { print "" }

            # copy all lines not a version
            { print }
        ' "$csproj" | uniq >"$csproj.$$"
        if cmp -s "$csproj" "$csproj.$$"; then
            rm "$csproj.$$"
        else
            mv "$csproj.$$" "$csproj"
        fi
    done

else
    echo "unknown subcommand: $1"
    exit 1
fi

# end
