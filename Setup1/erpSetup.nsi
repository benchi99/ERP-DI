;Instalador ERP NSIS
;Basado en el ejemplo Multilingüe de NSIS.
;Autor: Joost Verburg, modificado por Rubén Bermejo Romero

!pragma warning error all

;--------------------------------
;Include Modern UI

  !include "MUI2.nsh"

;--------------------------------
;General

  ;Properly display all languages (Installer will not work on Windows 95, 98 or ME!)
  Unicode true

  ;Name and file
  Name "ERP"
  OutFile "erpSetup.exe"

  ;Default installation folder
  InstallDir "$PROGRAMFILES\ERP\"

  ;Request application privileges for Windows Vista
  RequestExecutionLevel user

;--------------------------------
;Interface Settings

  !define MUI_ABORTWARNING

  ;Show all languages, despite user's codepage
  !define MUI_LANGDLL_ALLLANGUAGES

;--------------------------------
;Language Selection Dialog Settings

  ;Remember the installer language
  !define MUI_LANGDLL_REGISTRY_ROOT "HKCU" 
  !define MUI_LANGDLL_REGISTRY_KEY "Software\ERP" 
  !define MUI_LANGDLL_REGISTRY_VALUENAME "Installer Language"

;--------------------------------
;Pages

  !insertmacro MUI_PAGE_WELCOME
  !insertmacro MUI_PAGE_LICENSE "nsisRes\LICENSE.txt"
  !insertmacro MUI_PAGE_COMPONENTS
  !insertmacro MUI_PAGE_DIRECTORY
  !insertmacro MUI_PAGE_INSTFILES
  !insertmacro MUI_PAGE_FINISH
  
  !insertmacro MUI_UNPAGE_WELCOME
  !insertmacro MUI_UNPAGE_CONFIRM
  !insertmacro MUI_UNPAGE_LICENSE "nsisRes\LICENSE.txt"
  !insertmacro MUI_UNPAGE_COMPONENTS
  !insertmacro MUI_UNPAGE_DIRECTORY
  !insertmacro MUI_UNPAGE_INSTFILES
  !insertmacro MUI_UNPAGE_FINISH

;--------------------------------
;Languages

  !insertmacro MUI_LANGUAGE "English" ; The first language is the default language
  !insertmacro MUI_LANGUAGE "Spanish"

;--------------------------------
;Reserve Files
  
  ;If you are using solid compression, files that are required before
  ;the actual installation should be stored first in the data block,
  ;because this will make your installer start faster.
  
  !insertmacro MUI_RESERVEFILE_LANGDLL

;--------------------------------
;Installer Sections

Section "MAIN" SecDummy

  SetOutPath "$INSTDIR"
  
  ;ARCHIVOS DE INSTALACIÓN
  File "D:\INSTITUTO\2DAM\prog\desarrollo-interfaces\ERP\ERP\bin\Release\res\help\help.chm"
  File "D:\INSTITUTO\2DAM\prog\desarrollo-interfaces\ERP\ERP\bin\Release\res\pdf\manual.pdf"
  File "D:\INSTITUTO\2DAM\prog\desarrollo-interfaces\ERP\ERP\bin\Release\res\img\tramite.ico"
  File "D:\INSTITUTO\2DAM\prog\desarrollo-interfaces\ERP\ERP\bin\Release\es\Microsoft.ReportViewer.Common.resources.dll"
  File "D:\INSTITUTO\2DAM\prog\desarrollo-interfaces\ERP\ERP\bin\Release\es\Microsoft.ReportViewer.DataVisualization.resources.dll"
  File "D:\INSTITUTO\2DAM\prog\desarrollo-interfaces\ERP\ERP\bin\Release\es\Microsoft.ReportViewer.Design.resources.dll"
  File "D:\INSTITUTO\2DAM\prog\desarrollo-interfaces\ERP\ERP\bin\Release\es\Microsoft.ReportViewer.WinForms.resources.dll"
  File "D:\INSTITUTO\2DAM\prog\desarrollo-interfaces\ERP\ERP\bin\Release\es\Microsoft.VisualStudio.Data.Core.resources.dll"
  File "D:\INSTITUTO\2DAM\prog\desarrollo-interfaces\ERP\ERP\bin\Release\es\Microsoft.VisualStudio.Data.Services.resources.dll"
  File "D:\INSTITUTO\2DAM\prog\desarrollo-interfaces\ERP\ERP\bin\Release\SqlServerTypes\x86\msvcr120.dll"
  File "D:\INSTITUTO\2DAM\prog\desarrollo-interfaces\ERP\ERP\bin\Release\SqlServerTypes\x86\SqlServerSpatial140.dll"
  File "D:\INSTITUTO\2DAM\prog\desarrollo-interfaces\ERP\ERP\bin\Release\SqlServerTypes\x64\msvcr120.dll"
  File "D:\INSTITUTO\2DAM\prog\desarrollo-interfaces\ERP\ERP\bin\Release\SqlServerTypes\x64\SqlServerSpatial140.dll"
  File "D:\INSTITUTO\2DAM\prog\desarrollo-interfaces\ERP\ERP\bin\Release\Microsoft.VisualStudio.ComponentModelHost.dll"
  File "D:\INSTITUTO\2DAM\prog\desarrollo-interfaces\ERP\ERP\bin\Release\Microsoft.VisualStudio.Data.Core.dll"
  File "D:\INSTITUTO\2DAM\prog\desarrollo-interfaces\ERP\ERP\bin\Release\Microsoft.VisualStudio.Data.Services.dll"
  File "D:\INSTITUTO\2DAM\prog\desarrollo-interfaces\ERP\ERP\bin\Release\Microsoft.VisualStudio.Debugger.Interop.11.0.dll"
  File "D:\INSTITUTO\2DAM\prog\desarrollo-interfaces\ERP\ERP\bin\Release\Microsoft.VisualStudio.Debugger.InteropA.dll"
  File "D:\INSTITUTO\2DAM\prog\desarrollo-interfaces\ERP\ERP\bin\Release\Microsoft.VisualStudio.GraphModel.dll"
  File "D:\INSTITUTO\2DAM\prog\desarrollo-interfaces\ERP\ERP\bin\Release\Microsoft.VisualStudio.ManagedInterfaces.dll"
  File "D:\INSTITUTO\2DAM\prog\desarrollo-interfaces\ERP\ERP\bin\Release\Microsoft.VisualStudio.OLE.Interop.dll"
  File "D:\INSTITUTO\2DAM\prog\desarrollo-interfaces\ERP\ERP\bin\Release\Microsoft.VisualStudio.ProjectAggregator.dll"
  File "D:\INSTITUTO\2DAM\prog\desarrollo-interfaces\ERP\ERP\bin\Release\Microsoft.VisualStudio.Shell.Interop.8.0.dll"
  File "D:\INSTITUTO\2DAM\prog\desarrollo-interfaces\ERP\ERP\bin\Release\Microsoft.VisualStudio.Shell.Interop.9.0.dll"
  File "D:\INSTITUTO\2DAM\prog\desarrollo-interfaces\ERP\ERP\bin\Release\Microsoft.VisualStudio.Shell.Interop.10.0.dll"
  File "D:\INSTITUTO\2DAM\prog\desarrollo-interfaces\ERP\ERP\bin\Release\Microsoft.VisualStudio.Shell.Interop.11.0.dll"
  File "D:\INSTITUTO\2DAM\prog\desarrollo-interfaces\ERP\ERP\bin\Release\Microsoft.VisualStudio.Shell.Interop.dll"
  File "D:\INSTITUTO\2DAM\prog\desarrollo-interfaces\ERP\ERP\bin\Release\Microsoft.VisualStudio.TemplateWizardInterface.dll"
  File "D:\INSTITUTO\2DAM\prog\desarrollo-interfaces\ERP\ERP\bin\Release\Microsoft.VisualStudio.TemplateWizardInterface.xml"
  File "D:\INSTITUTO\2DAM\prog\desarrollo-interfaces\ERP\ERP\bin\Release\Microsoft.VisualStudio.TextManager.Interop.8.0.dll"
  File "D:\INSTITUTO\2DAM\prog\desarrollo-interfaces\ERP\ERP\bin\Release\Microsoft.VisualStudio.TextManager.Interop.10.0.dll"
  File "D:\INSTITUTO\2DAM\prog\desarrollo-interfaces\ERP\ERP\bin\Release\Microsoft.VisualStudio.TextManager.Interop.dll"
  File "D:\INSTITUTO\2DAM\prog\desarrollo-interfaces\ERP\ERP\bin\Release\Microsoft.VisualStudio.VSHelp.dll"
  File "D:\INSTITUTO\2DAM\prog\desarrollo-interfaces\ERP\ERP\bin\Release\AxInterop.AcroPDFLib.dll"
  File "D:\INSTITUTO\2DAM\prog\desarrollo-interfaces\ERP\ERP\bin\Release\Control_Calendario.dll"
  File "D:\INSTITUTO\2DAM\prog\desarrollo-interfaces\ERP\ERP\bin\Release\Control_Calendario.pdb"
  File "D:\INSTITUTO\2DAM\prog\desarrollo-interfaces\ERP\ERP\bin\Release\EnvDTE.dll"
  File "D:\INSTITUTO\2DAM\prog\desarrollo-interfaces\ERP\ERP\bin\Release\EnvDTE80.dll"
  File "D:\INSTITUTO\2DAM\prog\desarrollo-interfaces\ERP\ERP\bin\Release\ERP.exe"
  File "D:\INSTITUTO\2DAM\prog\desarrollo-interfaces\ERP\ERP\bin\Release\ERP.exe.config"
  File "D:\INSTITUTO\2DAM\prog\desarrollo-interfaces\ERP\ERP\bin\Release\ERP.pdb"
  File "D:\INSTITUTO\2DAM\prog\desarrollo-interfaces\ERP\ERP\bin\Release\ERP.xml"
  File "D:\INSTITUTO\2DAM\prog\desarrollo-interfaces\ERP\ERP\bin\Release\Interop.AcroPDFLib.dll"
  File "D:\INSTITUTO\2DAM\prog\desarrollo-interfaces\ERP\ERP\bin\Release\MetroFramework.Design.dll"
  File "D:\INSTITUTO\2DAM\prog\desarrollo-interfaces\ERP\ERP\bin\Release\MetroFramework.dll"
  File "D:\INSTITUTO\2DAM\prog\desarrollo-interfaces\ERP\ERP\bin\Release\MetroFramework.Fonts.dll"
  File "D:\INSTITUTO\2DAM\prog\desarrollo-interfaces\ERP\ERP\bin\Release\Microsoft.Build.Framework.dll"
  File "D:\INSTITUTO\2DAM\prog\desarrollo-interfaces\ERP\ERP\bin\Release\Microsoft.Build.Tasks.Core.dll"
  File "D:\INSTITUTO\2DAM\prog\desarrollo-interfaces\ERP\ERP\bin\Release\Microsoft.Build.Utilities.Core.dll"
  File "D:\INSTITUTO\2DAM\prog\desarrollo-interfaces\ERP\ERP\bin\Release\Microsoft.MSXML.dll"
  File "D:\INSTITUTO\2DAM\prog\desarrollo-interfaces\ERP\ERP\bin\Release\Microsoft.ReportViewer.Common.dll"
  File "D:\INSTITUTO\2DAM\prog\desarrollo-interfaces\ERP\ERP\bin\Release\Microsoft.ReportViewer.DataVisualization.dll"
  File "D:\INSTITUTO\2DAM\prog\desarrollo-interfaces\ERP\ERP\bin\Release\Microsoft.ReportViewer.Design.dll"
  File "D:\INSTITUTO\2DAM\prog\desarrollo-interfaces\ERP\ERP\bin\Release\Microsoft.ReportViewer.ProcessingObjectModel.dll"
  File "D:\INSTITUTO\2DAM\prog\desarrollo-interfaces\ERP\ERP\bin\Release\Microsoft.ReportViewer.WinForms.dll"
  File "D:\INSTITUTO\2DAM\prog\desarrollo-interfaces\ERP\ERP\bin\Release\Microsoft.SqlServer.Types.dll"
  File "D:\INSTITUTO\2DAM\prog\desarrollo-interfaces\ERP\ERP\bin\Release\stdole.dll"
  File "D:\INSTITUTO\2DAM\prog\desarrollo-interfaces\ERP\ERP\bin\Release\System.Threading.Tasks.Dataflow.dll"
  File "D:\INSTITUTO\2DAM\prog\desarrollo-interfaces\ERP\ERP\bin\Release\VSLangProj.dll"
  File "D:\INSTITUTO\2DAM\prog\desarrollo-interfaces\ERP\ERP\bin\Release\VSLangProj2.dll"
  File "D:\INSTITUTO\2DAM\prog\desarrollo-interfaces\ERP\ERP\bin\Release\VSLangProj80.dll"
  
  
  ;Store installation folder
  WriteRegStr HKCU "Software\ERP" "" $INSTDIR
  
  ;Create uninstaller
  WriteUninstaller "$INSTDIR\Uninstall.exe"

SectionEnd

;--------------------------------
;Installer Functions

Function .onInit

  !insertmacro MUI_LANGDLL_DISPLAY

FunctionEnd


;--------------------------------
;Uninstaller Section

Section "Uninstall"

  ;ADD YOUR OWN FILES HERE...

  Delete "$INSTDIR\Uninstall.exe"

  RMDir "$INSTDIR"

  DeleteRegKey /ifempty HKCU "Software\Modern UI Test"

SectionEnd

;--------------------------------
;Uninstaller Functions

Function un.onInit

  !insertmacro MUI_UNGETLANGUAGE
  
FunctionEnd