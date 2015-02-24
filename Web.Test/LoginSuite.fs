module LoginSuite

open LoginHelpers
open PagesHelpers
open canopy
open runner
open Faker

let all _ =
    context "Login Test Suite"

    "As a User, when I am not authenticated, I should be able to click a link in order to login to the site." &&& fun _ ->
        when_on_home_page()
        click "Log in"
        on_page "Account/Login"
        
    "As a User, when I am attempting to login and I have provided invalid credentials, I should see an error in order to know that my login attempt has failed." &&& fun _ ->
        "Email" << InternetFaker.Email()
        "Password" << StringFaker.AlphaNumeric(8)
        click "Log in"
        displayed "Invalid login attempt."

    "As a User, when I am attempting to login and I have provided valid credentials, I should be re-directed to the home page." &&& fun _ ->
        "Email" << test_user
        "Password" << test_password
        click "Log in"
        on_page ""
        displayed "Hello billy.testable@testable.com!"

    "As a User, when I am logged in, I should be able to click a link in order to logout." &&& fun _ ->
        click "Log off"
        on_page ""
        displayed "Log in"