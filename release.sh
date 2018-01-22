#!/bin/bash
if [ $# -eq 0 ]
then
    echo "Must specify target version"
    exit 1
fi
version=$1

msbuild /p:Configuration=Release

if [ -d target ]
then
    mkdir target
fi

projects="Core Sys Dummy"
for prj in $projects
do
	nuget pack "Myriagonal.Net.${prj}/Myriagonal.Net.${prj}.nuspec" -OutputDirectory ./target
done

for prj in $projects
do
     mono nuget.exe push "target/Myriagonal.Net.${prj}.${version}.nupkg" -Source https://api.nuget.org/v3/index.json
done
