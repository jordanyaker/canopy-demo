module RegistrationSuite

open RegistrationHelpers
open PagesHelpers
open canopy
open runner

let all _ =
    context "Registration Test Suite"

    "As a User, when I do not have an account, I should be able to click a link in order to register for an account." &&& fun _ ->
        when_on_home_page()
        click "Register"
        on_page "Account/Register"
   
//    "As a User, when I am attempting to register an account, and I have supplied invalid details, I should see an error in order to know that my request has not been successful." &&& fun _ ->
//        fill_in_invalid_registration_values()
//
//    "As a User, when I am attempting to register an account, and I have supplied valid details, I should be authenticated and redirected to the home page." &&& fun _ ->
//        ()// TODO: Test Registration Success