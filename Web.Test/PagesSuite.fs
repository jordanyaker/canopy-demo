module PagesSuite

open PagesHelpers
open canopy
open runner

let all _ =
    context "Pages Test Suite"

    "As a User, I should be able to click a link in order to view the 'Home' page." &&& fun _ ->
        when_on_page "Home/About"
        click "Home"
        on_page ""

    "As a User, I should be able to click a link in order to view the 'About' page." &&& fun _ ->
       // when_on_home_page()
        click "About"
        on_page "Home/About"

    "As a User, I should be able to click a link in order to view the 'Contact' page." &&& fun _ ->
        //when_on_home_page()
        click "Contact"
        on_page "Home/Contact"

    "As an annoying, unending, bothersome User, if I want to learn about how awesome ASP.NET is, I should be able to click a button in order to learn more." &&& fun _ ->
        when_on_home_page()
        click  "a.btn-primary"
        on "http://asp.net"