﻿Feature: Sorting
	As an Employer
	In order to narrow the list of Standards or Framework
	I need to be able to filter by Apprenticeship Level
	So I can see only relevant levels listed first
#WIP
#Tests Sorting  works
#@Regression @PreProd @Prod
Scenario: Sort Apprenticeship Search Results Page 
	Given I navigated to the Search page
	When  I choose Search Button
	Then  I am on the Search Results page
	When  I wait for the view to become active
	Then  I wait to see First Standard Result
	Then  I wait to see Sorting Dropdown	
	Then  I wait to see Filter Block
	