module PagesHelpers

open canopy
open Configurations

let when_on_home_page _ =
    url Configurations.Root

let when_on_page page =
    url(Configurations.Root + page)

let on_page page =
    on(Configurations.Root + page)
