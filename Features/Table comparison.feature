Feature: Table comparison
	In order to avoid writing my own collection comparison code
	As a SpecFlow user
	I want to compare collections using different criteria

Scenario: Match
	When I have a collection
	| Artist     | Album       |
	| Beatles    | Rubber Soul |
	| Pink Floyd | Animals     |
	| Muse       | Absolution  |
	Then it should match
	| Artist     | Album       |
	| Beatles    | Rubber Soul |
	| Pink Floyd | Animals     |
	| Muse       | Absolution  |
	And it should match
	| Artist     | Album       |
	| Beatles    | Rubber Soul |
	| Muse       | Absolution  |
	| Pink Floyd | Animals     |
	And it should exactly match
	| Artist     | Album       |
	| Beatles    | Rubber Soul |
	| Pink Floyd | Animals     |
	| Muse       | Absolution  |
	But it should not match
	| Artist     | Album       |
	| Beatles    | Rubber Soul |
	| Queuen     | Jazz        |
	| Muse       | Absolution  |
	And it should not match
	| Artist     | Album       |
	| Beatles    | Rubber Soul |
	| Muse       | Absolution  |
	And it should not exactly match
	| Artist     | Album       |
	| Beatles    | Rubber Soul |
	| Muse       | Absolution  |
	| Pink Floyd | Animals     |

Scenario: Containment
	When I have a collection
	| Artist     | Album       |
	| Beatles    | Rubber Soul |
	| Pink Floyd | Animals     |
	| Muse       | Absolution  |
	Then it should contain all items
	| Artist     | Album       |
	| Beatles    | Rubber Soul |
	| Muse       | Absolution  |
	But it should not contain all items
	| Artist     | Album       |
	| Beatles    | Rubber Soul |
	| Muse       | Resistance  |
	And it should not contain any of items
	| Artist     | Album       |
	| Beatles    | Abbey Road  |
	| Muse       | Resistance  |
