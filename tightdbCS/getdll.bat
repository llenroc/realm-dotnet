@echo off
:  This batch file copies the c++ dll from tightCSDLL to this projects debug dir
:  This enables easy debugging against the very latest build of c++ tightCSDLL
echo Copying tightdbCS.dll
copy ..\native\tightCSDLL\tightCSDLL2010\debug\tightCSDLL2010.dll bin\debug\tightCSDLL.dll
echo finished!

