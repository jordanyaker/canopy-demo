module Configurations

open canopy

let Host = "localhost"
let Port = ":49246"
let Protocol = "http://"
let Root = Protocol + Host + Port + "/"

let Browser = firefox
