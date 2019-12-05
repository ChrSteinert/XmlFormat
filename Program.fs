open System.IO
open System.Xml

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
    |> Array.iter (fun c -> 
        try formatFile c
        with e -> 
            printfn "Could not format file '%O' with the following error\n%O" c e
    )
    
    0