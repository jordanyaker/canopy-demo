module RegistrationHelpers

open Faker
open canopy

let fill_in_invalid_registration_values =
    "#Email" << StringFaker.Alpha(10)
    "#Password" << StringFaker.Alpha(10)
    "#ConfirmPassword" << StringFaker.Alpha(10)
