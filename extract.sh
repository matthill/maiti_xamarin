#!/bin/bash

# Extracts the individual static libraries from the MAITI universal framework.  The lipo tool is used to extract the framework (named MAITI) into the SDK directory

lipo -extract i386 ./MAITI -output ./SDK/libMAITI.i386.a
lipo -extract armv7 ./MAITI -output ./SDK/libMAITI.armv7.a
