Feature: SignIn

	Check that registered Users can sign in
	and not registered users cannot sign in.

	Scenario: Sign In using an existing User
		Given existing user
		When Home page is loaded 
		And Sign In button is clicked
		And enter username and click continue
		And enter password and click Sign In
		Then loaded page must be User home page

	Scenario: Sign In using a non-existing user credentials
		Given non-existing user
		When Home page is loaded 
		And Sign In button is clicked
		And enter username and click continue
		Then an error is displayed on form