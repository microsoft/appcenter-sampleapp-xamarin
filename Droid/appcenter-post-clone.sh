#!/usr/bin/env bash

echo "appcenter-post-clone.sh execution started"
echo "Source path="+$APPCENTER_BRANCH+$APPCENTER_BUILD_ID.zip $APPCENTER_SOURCE_DIRECTORY
echo "Zipping started"
zip -r $APPCENTER_BRANCH+$APPCENTER_BUILD_ID.zip $APPCENTER_SOURCE_DIRECTORY
echo "Zipped to " $APPCENTER_SOURCE_DIRECTORY+$APPCENTER_BRANCH+$APPCENTER_BUILD_ID.zip $APPCENTER_SOURCE_DIRECTORY
echo "Listing all files inside zip"
unzip -l $APPCENTER_SOURCE_DIRECTORY+$APPCENTER_BRANCH+$APPCENTER_BUILD_ID.zip $APPCENTER_SOURCE_DIRECTORY | sed '1,3d;$d' | sed '$d'
echo "appcenter-post-clone.sh done"
