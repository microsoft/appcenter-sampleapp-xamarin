#!/usr/bin/env bash

echo "appcenter-post-clone.sh execution started"
echo $APPCENTER_BRANCH_$APPCENTER_BUILD_ID.zip
$ZIPFILENAME = "$APPCENTER_BRANCH_$APPCENTER_BUILD_ID.zip"
$ZIPFILEPATH = $APPCENTER_SOURCE_DIRECTORY/$ZIPFILENAME
echo "Source file="$ZIPFILENAME
echo "Source folder="$APPCENTER_SOURCE_DIRECTORY
echo "Source path="$ZIPFILEPATH
echo "Zipping started for *.cs files"
zip -r $ZIPFILENAME $APPCENTER_SOURCE_DIRECTORY "*.cs"
echo "Zipped to " $ZIPFILEPATH
echo "Listing all files inside zip"
unzip -l $ZIPFILEPATH | sed '1,3d;$d' | sed '$d'
echo "appcenter-post-clone.sh done"
