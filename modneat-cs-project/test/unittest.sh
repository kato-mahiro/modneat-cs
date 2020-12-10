#!bin/bash

# build 
mcs /out:Test$1.exe ../src/$1.cs Test$1.cs

if [ $? = 0 ]; then
    echo ' ### Build Success. ### '
else
    echo ' ### Build Failed. ### '
    exit
fi

# test
./Test$1.exe

# clean up
rm Test$1.exe
