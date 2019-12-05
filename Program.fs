open System
open System.IO
open System.Xml
open System.Text

let private formatFile (file : FileInfo) =
    let xml = XmlDocument()
    xml.Load file.FullName
    xml.Save file.FullName

[<EntryPoint>]
let main argv =
    argv
    |> Array.choose (fun c -> 
        try
            let file = c |> FileInfo
            if file.Exists then file |> Some
            else None
        with _ -> None
    )
    |> Array.iter formatFile
    0