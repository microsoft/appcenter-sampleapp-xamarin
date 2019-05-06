#!/usr/bin/env bash

echo "appcenter-post-clone.sh execution started"
echo $APPCENTER_BRANCH"_"$APPCENTER_BUILD_ID.zip
ZIPFILENAME=$APPCENTER_BRANCH"_"$APPCENTER_BUILD_ID.zip
ZIPFILEPATH=$APPCENTER_SOURCE_DIRECTORY/$ZIPFILENAME
echo "Source folder="$APPCENTER_SOURCE_DIRECTORY
echo "Destination file="$ZIPFILENAME
echo "Destination file path="$ZIPFILEPATH
echo "Current directory"$PWD
echo "moving to grant parent directory"
cd ..
echo "Current directory"$PWD
echo "Zipping started for *.cs files from all projects"
zip -r $ZIPFILENAME ./* -i "*.cs"
echo "Zipped to " $ZIPFILENAME
echo "Listing all files inside zip"
unzip -l $ZIPFILENAME | sed '1,3d;$d' | sed '$d'
echo "appcenter-post-clone.sh done"
