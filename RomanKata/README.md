# Intro
Who knows TDD? Red-Green-Refactor?

Who uses TDD? always?

Classical TDD a-la-Uncle Bob.

# Transformation Priority Premise
For example (guidelines not rules) :

* {} -> null // no code -> null
* null -> constant
* constant -> constant+ // simple to more complex
* constant -> scalar // e.g. a variable
* statement -> statements
* unconditional -> if
* scalar -> array
* array -> container
* statement -> recursion
* if -> while
* variable -> assignment
* expression -> switch
* expression -> function

## See also
* [8thlight.com](http://blog.8thlight.com/uncle-bob/2013/05/27/TheTransformationPriorityPremise.html)
* [wikipedia](http://en.wikipedia.org/wiki/Transformation_Priority_Premise)
* [codurance (Sandro Mancuso)](http://codurance.com/videos/)

# Demo

RomanKata

* Class naming
* Method naming
* Try to follow TPP
* Careful with blocks (switch, extract functions, etc: hard to deal with)
* Refactor only when needed

# Guidelines

* Do not start with exceptions
* Prefer tests that improve the algo, help the algo evolve simply
* Add enough tests to be confident

# See also
[Does TDD lead to good design?](http://codurance.com/2015/05/12/does-tdd-lead-to-good-design/) (codurance blog)