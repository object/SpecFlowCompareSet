Feature: Table comparison mismatch errors
	In order to avoid writing my own collection comparison code
	As a SpecFlow user
	I want to compare collections using different criteria

Scenario: Match was not expected
	When I have a collection
	| Artist     | Album       |
	| Beatles    | Rubber Soul |
	| Pink Floyd | Animals     |
	| Muse       | Absolution  |
	Then it should not match
	| Artist     | Album       |
	| Beatles    | Rubber Soul |
	| Pink Floyd | Animals     |
	| Muse       | Absolution  |

Scenario: Exact match was not expected
	When I have a collection
	| Artist     | Album       |
	| Beatles    | Rubber Soul |
	| Pink Floyd | Animals     |
	| Muse       | Absolution  |
	Then it should not exactly match
	| Artist     | Album       |
	| Beatles    | Rubber Soul |
	| Pink Floyd | Animals     |
	| Muse       | Absolution  |

Scenario: Not all contained items were expected
	When I have a collection
	| Artist     | Album       |
	| Beatles    | Rubber Soul |
	| Pink Floyd | Animals     |
	| Muse       | Absolution  |
	Then it should not contain all items
	| Artist     | Album       |
	| Beatles    | Rubber Soul |
	| Muse       | Absolution  |

Scenario: Common items were not expected
	When I have a collection
	| Artist     | Album       |
	| Beatles    | Rubber Soul |
	| Pink Floyd | Animals     |
	| Muse       | Absolution  |
	Then it should not contain any of items
	| Artist     | Album       |
	| Beatles    | Rubber Soul |
