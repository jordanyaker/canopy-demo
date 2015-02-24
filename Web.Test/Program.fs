module Program

open canopy
open runner
open System
open Configurations

open configuration
open reporters
reporter <- new LiveHtmlReporter() :> IReporter


// Start an instance of the firefox browser
start Configurations.Browser

// Setup and configure all of the tests.
PagesSuite.all()
LoginSuite.all()

// Run all of the configured tests.
run()

// Check the results
printfn "press [enter] to exit"
System.Console.ReadLine() |> ignore

quit()