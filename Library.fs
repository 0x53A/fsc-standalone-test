// Auto-Generated by FAKE; do not edit
namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("Paket")>]
[<assembly: AssemblyProductAttribute("Paket")>]
[<assembly: AssemblyCompanyAttribute("Paket team")>]
[<assembly: AssemblyDescriptionAttribute("A dependency manager for .NET with support for NuGet packages and git repositories.")>]
[<assembly: AssemblyVersionAttribute("5.86.0")>]
[<assembly: AssemblyFileVersionAttribute("5.86.0")>]
[<assembly: AssemblyInformationalVersionAttribute("5.86.0")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] AssemblyTitle = "Paket"
    let [<Literal>] AssemblyProduct = "Paket"
    let [<Literal>] AssemblyCompany = "Paket team"
    let [<Literal>] AssemblyDescription = "A dependency manager for .NET with support for NuGet packages and git repositories."
    let [<Literal>] AssemblyVersion = "5.86.0"
    let [<Literal>] AssemblyFileVersion = "5.86.0"
    let [<Literal>] AssemblyInformationalVersion = "5.86.0"




namespace fsc_standalone_test


open System

open Argu

type AddArgs =
    | [<ExactlyOnce;MainCommand>] NuGet of package_ID:string
    | [<Hidden;ExactlyOnce;CustomCommandLine("nuget")>] NuGet_Legacy of package_ID:string

    | [<Unique;AltCommandLine("-V")>] Version of version_constraint:string
    | [<Hidden;Unique;CustomCommandLine("version")>] Version_Legacy of version_constraint:string

    | [<Unique;AltCommandLine("-p")>] Project of path:string
    | [<Hidden;Unique;CustomCommandLine("project")>] Project_Legacy of path:string

    | [<Unique;AltCommandLine("-g")>] Group of name:string
    | [<Hidden;Unique;CustomCommandLine("group")>] Group_Legacy of name:string

    | [<Unique>] Create_New_Binding_Files
    | [<Hidden;Unique;CustomCommandLine("--createnewbindingfiles")>] Create_New_Binding_Files_Legacy

    | [<Unique;AltCommandLine("-f")>] Force
    | [<Unique;AltCommandLine("-i")>] Interactive
    | [<Unique>] Redirects
    | [<Unique>] Clean_Redirects
    | [<Unique>] No_Install
    | [<Unique>] Keep_Major
    | [<Unique>] Keep_Minor
    | [<Unique>] Keep_Patch
    | [<Unique>] Touch_Affected_Refs
with
    interface IArgParserTemplate with
        member this.Usage =
            match this with
            | NuGet(_) -> "NuGet package ID"
            | NuGet_Legacy(_) -> "[obsolete]"

            | Group(_) -> "add the dependency to a group (default: Main group)"
            | Group_Legacy(_) -> "[obsolete]"

            | Version(_) -> "dependency version constraint"
            | Version_Legacy(_) -> "[obsolete]"

            | Project(_) -> "add the dependency to a single project only"
            | Project_Legacy(_) -> "[obsolete]"

            | Create_New_Binding_Files -> "create binding redirect files if needed"
            | Create_New_Binding_Files_Legacy -> "[obsolete]"

            | Force -> "force download and reinstallation of all dependencies"
            | Interactive -> "ask for every project whether to add the dependency"
            | Redirects -> "create binding redirects"
            | Clean_Redirects -> "remove binding redirects that were not created by Paket"
            | No_Install -> "do not modify projects"
            | Keep_Major -> "only allow updates that preserve the major version"
            | Keep_Minor -> "only allow updates that preserve the minor version"
            | Keep_Patch -> "only allow updates that preserve the patch version"
            | Touch_Affected_Refs -> "touch project files referencing affected dependencies to help incremental build tools detecting the change"

module Program =
    let main argv =
        0
