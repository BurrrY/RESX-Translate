!include "MUI.nsh"

Name "RESX-Translate"
RequestExecutionLevel admin
!define INSTALLNAME "RESX-Translate"
!define COMPANY "FB_Software"
!define VERSION 1.0.0.53
;in KB!
!define INSTALLSIZE 4080


!define MUI_ICON "..\RESX-Translate.ico"

OutFile "./${INSTALLNAME}_Setup.exe"
InstallDir $PROGRAMFILES\${INSTALLNAME}

!insertmacro MUI_PAGE_DIRECTORY
!insertmacro MUI_PAGE_COMPONENTS
!insertmacro MUI_PAGE_INSTFILES



!insertmacro MUI_UNPAGE_CONFIRM
!insertmacro MUI_UNPAGE_INSTFILES


!define MUI_LANGDLL_ALLLANGUAGES
!insertmacro MUI_LANGUAGE "German"
!insertmacro MUI_LANGUAGE "English"
!insertmacro MUI_RESERVEFILE_LANGDLL

Function .onInit
!insertmacro MUI_LANGDLL_DISPLAY ;This has to come after the language macros
FunctionEnd

Section ""
  SetShellVarContext current
	SetOutPath $INSTDIR
	File /r Files\*
	WriteUninstaller $INSTDIR\Uninstall.exe
	WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\${INSTALLNAME}" "DisplayName" "${INSTALLNAME}"
    WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\${INSTALLNAME}" "UninstallString" '"$INSTDIR\uninstall.exe"'
	WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\${INSTALLNAME}" "Publisher" "${COMPANY}"
	WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\${INSTALLNAME}" "DisplayIcon" "$INSTDIR\Auswertung.ico"
	WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\${INSTALLNAME}" "DisplayVersion" ${VERSION}
	WriteRegDWORD HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\${INSTALLNAME}" "EstimatedSize" ${INSTALLSIZE}
    WriteRegDWORD HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\${INSTALLNAME}" "NoModify" 1
    WriteRegDWORD HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\${INSTALLNAME}" "NoRepair" 1
SectionEnd

Section "Desktop"
    CreateShortCut "$DESKTOP\${INSTALLNAME}.lnk" "$INSTDIR\${INSTALLNAME}.exe" ""
SectionEnd

Section "Start Menu"
  CreateDirectory "$SMPROGRAMS\${INSTALLNAME}"
  CreateShortCut "$SMPROGRAMS\${INSTALLNAME}\Uninstall.lnk" "$INSTDIR\Uninstall.exe" "" "$INSTDIR\Uninstall.exe" 0
  CreateShortCut "$SMPROGRAMS\${INSTALLNAME}\${INSTALLNAME}.lnk" "$INSTDIR\${INSTALLNAME}.exe" "" "$INSTDIR\${INSTALLNAME}.exe" 0
SectionEnd

Section "Uninstall"
  SetShellVarContext current
  DeleteRegKey HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\${INSTALLNAME}"
  Delete $INSTDIR\*
  RMDir  /r $INSTDIR  
  
  ;SHORTCUTS
  Delete "$DESKTOP\${INSTALLNAME}.lnk"
  Delete "$SMPROGRAMS\${INSTALLNAME}\*"
  RMDir "$SMPROGRAMS\${INSTALLNAME}"
  
  ;APP-DATA
  Delete "$APPDATA\${INSTALLNAME}\*"
  RMDir "$APPDATA\${INSTALLNAME}"
  
  
SectionEnd