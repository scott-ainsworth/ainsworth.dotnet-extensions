#!/usr/bin/env bash
##
# Run gitversion on packable projects only (ignore test projects)
##

find * -type f -name '*.csproj' ! -name '*.Tests.csproj' \
| while read f; do
    cd "$(dirname "$f")"
    dotnet-gitversion /updateprojectfiles \
    | sed '/InformationalVersion/!d; s/^ *"//; s/"//g; s/,$//'
done

# end
