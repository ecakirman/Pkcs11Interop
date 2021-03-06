@setlocal

@rem Initialize build environment of Visual Studio 2015
call "C:\Program Files (x86)\Microsoft Visual Studio 14.0\Common7\Tools\vsvars32.bat"

@rem Delete output directory
rmdir /S /Q net20

@rem Clean project
msbuild ..\src\Pkcs11Interop\Pkcs11Interop\Pkcs11Interop.csproj ^
/p:Configuration=Release /p:Platform=AnyCPU /p:TargetFrameworkVersion=v2.0 ^
/target:Clean || goto :error

@rem Build project
msbuild ..\src\Pkcs11Interop\Pkcs11Interop\Pkcs11Interop.csproj ^
/p:Configuration=Release /p:Platform=AnyCPU /p:TargetFrameworkVersion=v2.0 ^
/target:Build || goto :error

@rem Copy result to output directory
mkdir net20 || goto :error
copy ..\src\Pkcs11Interop\Pkcs11Interop\bin\Release\Pkcs11Interop.dll net20 || goto :error
copy ..\src\Pkcs11Interop\Pkcs11Interop\bin\Release\Pkcs11Interop.xml net20 || goto :error

@echo *** BUILD NET20 SUCCESSFUL ***
@endlocal
@exit /b 0

:error
@echo *** BUILD NET20 FAILED ***
@endlocal
@exit /b 1
