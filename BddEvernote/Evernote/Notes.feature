Feature: Notes
	Check that registered Users can create and save Notes.

	Scenario: Create one note
		Given User signed in
		And new Note with "New Note 1" is created
		When new Note is done
		Then Note "New Note 1" must be listed

	Scenario: Created Note must be listed after User has Signed-Out
		Given User signed in
		And new Note with "New Note 2" is created
		When new Note is done
		And User signed-out
		And User signed-in
		Then Note "New Note 2" must be listed