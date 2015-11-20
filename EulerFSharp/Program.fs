module Program

open System.Diagnostics

[<EntryPoint>]
let main argv = 
    let watch = Stopwatch()
    watch.Start()
    Task48.run

    watch.Stop();
    printfn "%O" watch.Elapsed
    0