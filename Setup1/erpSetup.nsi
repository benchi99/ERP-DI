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
  RequestExecutionLevel admin

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
  !insertmacro MUI_UNPAGE_INSTFILES

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

Section "ERP"

  SectionIn RO
  SetOutPath "$INSTDIR"

  CreateDirectory "$INSTDIR\res"
  CreateDirectory "$INSTDIR\res\help\"
  CreateDirectory "$INSTDIR\res\img\"
  CreateDirectory "$INSTDIR\res\pdf\"
  CreateDirectory "$INSTDIR\es"
  CreateDirectory "$INSTDIR\SqlServerTypes"
  CreateDirectory "$INSTDIR\SqlServerTypes\x86"
  CreateDirectory "$INSTDIR\SqlServerTypes\x64"

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
  
  CopyFiles "$INSTDIR\*.pdf" "$INSTDIR\res\pdf\"
  CopyFiles "$INSTDIR\*.chm" "$INSTDIR\res\help\"
  CopyFiles "$INSTDIR\*.ico" "$INSTDIR\res\img\"

  Delete "$INSTDIR\*.pdf"
  Delete "$INSTDIR\*.chm"
  Delete "$INSTDIR\*.ico"

  CopyFiles "$INSTDIR\Microsoft.ReportViewer.Common.resources.dll" "$INSTDIR\es\"
  CopyFiles "$INSTDIR\Microsoft.ReportViewer.DataVisualization.resources.dll" "$INSTDIR\es\"
  CopyFiles "$INSTDIR\Microsoft.ReportViewer.Design.resources.dll" "$INSTDIR\es\"
  CopyFiles "$INSTDIR\Microsfot.ReportViewer.WinForms.dll" "$INSTDIR\es\"
  CopyFiles "$INSTDIR\Microsoft.VisualStudio.Data.Core.resources.dll" "$INSTDIR\es\"
  CopyFiles "$INSTDIR\Microsoft.VisualStudio.Data.Services.resources.dll" "$INSTDIR\es\"

  Delete "$INSTDIR\Microsoft.ReportViewer.Common.resources.dll" 
  Delete "$INSTDIR\Microsoft.ReportViewer.DataVisualization.resources.dll" 
  Delete "$INSTDIR\Microsoft.ReportViewer.Design.resources.dll" 
  Delete "$INSTDIR\Microsfot.ReportViewer.WinForms.dll" 
  Delete "$INSTDIR\Microsoft.VisualStudio.Data.Core.resources.dll" 
  Delete "$INSTDIR\Microsoft.VisualStudio.Data.Services.resources.dll" 

  CopyFiles "$INSTDIR\msvcr120.dll" "$INSTDIR\SqlServerTypes\x86\"
  CopyFiles "$INSTDIR\msvcr120.dll" "$INSTDIR\SqlServerTypes\x64\"
  CopyFiles "$INSTDIR\SqlServerSpatial140.dll" "$INSTDIR\SqlServerTypes\x86\"
  CopyFiles "$INSTDIR\SqlServerSpatial140.dll" "$INSTDIR\SqlServerTypes\x64\"

  Delete "$INSTDIR\msvcr120.dll" 
  Delete "$INSTDIR\SqlServerSpatial140.dll" 

  CreateShortCut "$DESKTOP\ERP.lnk" "$INSTDIR\ERP.exe"

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

  Delete "$INSTDIR\res\help\help.chm"
  Delete "$INSTDIR\res\pdf\manual.pdf"
  Delete "$INSTDIR\res\img\tramite.ico"
  Delete "$INSTDIR\es\Microsoft.ReportViewer.Common.resources.dll"
  Delete "$INSTDIR\es\Microsoft.ReportViewer.DataVisualization.resources.dll"
  Delete "$INSTDIR\es\Microsoft.ReportViewer.Design.resources.dll"
  Delete "$INSTDIR\es\Microsoft.ReportViewer.WinForms.resources.dll"
  Delete "$INSTDIR\es\Microsoft.VisualStudio.Data.Core.resources.dll"
  Delete "$INSTDIR\es\Microsoft.VisualStudio.Data.Services.resources.dll"
  Delete "$INSTDIR\SqlServerTypes\x86\msvcr120.dll"
  Delete "$INSTDIR\SqlServerTypes\x86\SqlServerSpatial140.dll"
  Delete "$INSTDIR\SqlServerTypes\x64\msvcr120.dll"
  Delete "$INSTDIR\SqlServerTypes\x64\SqlServerSpatial140.dll"
  Delete "$INSTDIR\Microsoft.VisualStudio.ComponentModelHost.dll"
  Delete "$INSTDIR\Microsoft.VisualStudio.Data.Core.dll"
  Delete "$INSTDIR\Microsoft.VisualStudio.Data.Services.dll"
  Delete "$INSTDIR\Microsoft.VisualStudio.Debugger.Interop.11.0.dll"
  Delete "$INSTDIR\Microsoft.VisualStudio.Debugger.InteropA.dll"
  Delete "$INSTDIR\Microsoft.VisualStudio.GraphModel.dll"
  Delete "$INSTDIR\Microsoft.VisualStudio.ManagedInterfaces.dll"
  Delete "$INSTDIR\Microsoft.VisualStudio.OLE.Interop.dll"
  Delete "$INSTDIR\Microsoft.VisualStudio.ProjectAggregator.dll"
  Delete "$INSTDIR\Microsoft.VisualStudio.Shell.Interop.8.0.dll"
  Delete "$INSTDIR\Microsoft.VisualStudio.Shell.Interop.9.0.dll"
  Delete "$INSTDIR\Microsoft.VisualStudio.Shell.Interop.10.0.dll"
  Delete "$INSTDIR\Microsoft.VisualStudio.Shell.Interop.11.0.dll"
  Delete "$INSTDIR\Microsoft.VisualStudio.Shell.Interop.dll"
  Delete "$INSTDIR\Microsoft.VisualStudio.TemplateWizardInterface.dll"
  Delete "$INSTDIR\Microsoft.VisualStudio.TemplateWizardInterface.xml"
  Delete "$INSTDIR\Microsoft.VisualStudio.TextManager.Interop.8.0.dll"
  Delete "$INSTDIR\Microsoft.VisualStudio.TextManager.Interop.10.0.dll"
  Delete "$INSTDIR\Microsoft.VisualStudio.TextManager.Interop.dll"
  Delete "$INSTDIR\Microsoft.VisualStudio.VSHelp.dll"
  Delete "$INSTDIR\AxInterop.AcroPDFLib.dll"
  Delete "$INSTDIR\Control_Calendario.dll"
  Delete "$INSTDIR\Control_Calendario.pdb"
  Delete "$INSTDIR\EnvDTE.dll"
  Delete "$INSTDIR\EnvDTE80.dll"
  Delete "$INSTDIR\ERP.exe"
  Delete "$INSTDIR\ERP.exe.config"
  Delete "$INSTDIR\ERP.pdb"
  Delete "$INSTDIR\ERP.xml"
  Delete "$INSTDIR\Interop.AcroPDFLib.dll"
  Delete "$INSTDIR\MetroFramework.Design.dll"
  Delete "$INSTDIR\MetroFramework.dll"
  Delete "$INSTDIR\MetroFramework.Fonts.dll"
  Delete "$INSTDIR\Microsoft.Build.Framework.dll"
  Delete "$INSTDIR\Microsoft.Build.Tasks.Core.dll"
  Delete "$INSTDIR\Microsoft.Build.Utilities.Core.dll"
  Delete "$INSTDIR\Microsoft.MSXML.dll"
  Delete "$INSTDIR\Microsoft.ReportViewer.Common.dll"
  Delete "$INSTDIR\Microsoft.ReportViewer.DataVisualization.dll"
  Delete "$INSTDIR\Microsoft.ReportViewer.Design.dll"
  Delete "$INSTDIR\Microsoft.ReportViewer.ProcessingObjectModel.dll"
  Delete "$INSTDIR\Microsoft.ReportViewer.WinForms.dll"
  Delete "$INSTDIR\Microsoft.SqlServer.Types.dll"
  Delete "$INSTDIR\stdole.dll"
  Delete "$INSTDIR\System.Threading.Tasks.Dataflow.dll"
  Delete "$INSTDIR\VSLangProj.dll"
  Delete "$INSTDIR\VSLangProj2.dll"
  Delete "$INSTDIR\VSLangProj80.dll"

  Delete "$INSTDIR\Uninstall.exe"

  RMDir "$INSTDIR"

  DeleteRegKey /ifempty HKCU "Software\ERP"
SectionEnd

;--------------------------------
;Uninstaller Functions

Function un.onInit

  !insertmacro MUI_UNGETLANGUAGE
  
FunctionEnd

Function un.onGUIEnd
    MessageBox MB_OK "La aplicacion se ha desinstalado correctamente, pero es posible que algunos archivos no hayan podido eliminarse y tenga que eliminarlos a mano. Gracias por instalar ERP." 
FunctionEnd