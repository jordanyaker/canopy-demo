open canopy
open runner
open System

//start an instance of the firefox browser
start firefox

//run all tests
run()

printfn "press [enter] to exit"
System.Console.ReadLine() |> ignore

quit()