using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Allgemeine Informationen über eine Assembly werden über die folgenden
// Attribute gesteuert. Ändern Sie diese Attributwerte, um die Informationen zu ändern,
// die einer Assembly zugeordnet sind.
[assembly: AssemblyTitle("Taschenrechner")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Terppe")]
[assembly: AssemblyProduct("Taschenrechner")]
[assembly: AssemblyCopyright("Copyright ©  2020")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Durch Festlegen von ComVisible auf FALSE werden die Typen in dieser Assembly
// für COM-Komponenten unsichtbar.  Wenn Sie auf einen Typ in dieser Assembly von
// COM aus zugreifen müssen, sollten Sie das ComVisible-Attribut für diesen Typ auf "True" festlegen.
[assembly: ComVisible(false)]

// Die folgende GUID bestimmt die ID der Typbibliothek, wenn dieses Projekt für COM verfügbar gemacht wird
[assembly: Guid("c5ec3ab4-df79-4f3b-a6c0-d3ed45b8148e")]

// Versionsinformationen für eine Assembly bestehen aus den folgenden vier Werten:
//
//      Hauptversion
//      Nebenversion
//      Buildnummer
//      Revision
//
// Sie können alle Werte angeben oder Standardwerte für die Build- und Revisionsnummern verwenden,
// indem Sie "*" wie unten gezeigt eingeben:
/*
 1. Unload Project from visual studio and edit .csproj file Or open .csproj solution file in editor.
 2. Search for tag and Change value from true to false <deterministic>false</deterministic>
 3. Save file and reload project again inside Visual studio
     <propertygroup>
        <configuration condition=" '$(Configuration)' == '' ">Debug</configuration>
        <platform condition=" '$(Platform)' == '' ">AnyCPU</platform>
        <projectguid>{76602FA1-9AD8-4014-BA5D-2E9128C19AB2}</projectguid>
        <targetframeworkversion>v4.7</targetframeworkversion>
        <filealignment>512</filealignment>
        <autogeneratebindingredirects>true</autogeneratebindingredirects>
        <deterministic>false</deterministic>  !!!!
      </propertygroup>
 */
[assembly: AssemblyVersion("1.0.*")]
//[assembly: AssemblyVersion("1.0.0.0")]
//[assembly: AssemblyFileVersion("1.0.0.0")]
