Feature: Table comparison match errors
	In order to avoid writing my own collection comparison code
	As a SpecFlow user
	I want to compare collections using different criteria

Scenario: Match error due to missing item
	When I have a collection
	| Artist     | Album       |
	| Beatles    | Rubber Soul |
	| Pink Floyd | Animals     |
	| Muse       | Absolution  |
	Then it should match
	| Artist     | Album       |
	| Beatles    | Rubber Soul |
	| ABBA       | Arrival     |
	| Muse       | Absolution  |

Scenario: Match error due to extra item
	When I have a collection
	| Artist     | Album       |
	| Beatles    | Rubber Soul |
	| Pink Floyd | Animals     |
	| Muse       | Absolution  |
	Then it should match
	| Artist     | Album       |
	| Beatles    | Rubber Soul |
	| Muse       | Absolution  |
	| Pink Floyd | Animals     |
	| ABBA       | Arrival     |

Scenario: Exact match error due to missing item
	When I have a collection
	| Artist     | Album       |
	| Beatles    | Rubber Soul |
	| Pink Floyd | Animals     |
	| Muse       | Absolution  |
	Then it should exactly match
	| Artist     | Album       |
	| Beatles    | Rubber Soul |
	| Pink Floyd | Animals     |
	| ABBA       | Arrival     |

Scenario: Exact match error due to incorrect order
	When I have a collection
	| Artist     | Album       |
	| Beatles    | Rubber Soul |
	| Pink Floyd | Animals     |
	| Muse       | Absolution  |
	Then it should exactly match
	| Artist     | Album       |
	| Beatles    | Rubber Soul |
	| Muse       | Absolution  |
	| Pink Floyd | Animals     |

Scenario: Containment match error due to extra item
	When I have a collection
	| Artist     | Album       |
	| Beatles    | Rubber Soul |
	| Pink Floyd | Animals     |
	| Muse       | Absolution  |
	Then it should contain all items
	| Artist     | Album       |
	| Beatles    | Rubber Soul |
	| Muse       | Absolution  |
	| ABBA       | Arrival     |
