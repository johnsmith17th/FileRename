set path=%~dp0%
set para=%%0
set full=%path%FileRename.exe %para%
reg add HKEY_CLASSES_ROOT\Directory\shell\frename /t REG_SZ /d "重命名所有文件(&R)"
reg add HKEY_CLASSES_ROOT\Directory\shell\frename\command /t REG_SZ /d "%full%"