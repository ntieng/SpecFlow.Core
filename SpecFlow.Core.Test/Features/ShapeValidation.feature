Feature: ShapeValidation

A short summary of the feature

Scenario: Is RightTriangle a Triangle
	When The shape is RightTriangle
	Then it is triangle

Scenario: Is Round a Triangle
	When The shape is Round
	Then it is not triangle