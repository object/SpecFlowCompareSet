Feature: Table comparison errors
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

Scenario: Contained items were not expected
	When I have a collection
	| Artist     | Album       |
	| Beatles    | Rubber Soul |
	| Pink Floyd | Animals     |
	| Muse       | Absolution  |
	Then it should not contain any of items
	| Artist     | Album       |
	| Beatles    | Rubber Soul |
