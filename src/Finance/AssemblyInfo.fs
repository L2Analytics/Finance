namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("Finance")>]
[<assembly: AssemblyProductAttribute("Finance")>]
[<assembly: AssemblyDescriptionAttribute("Tools for Financial calculations")>]
[<assembly: AssemblyVersionAttribute("1.0")>]
[<assembly: AssemblyFileVersionAttribute("1.0")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.0"
