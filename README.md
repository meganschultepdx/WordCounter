# WordCounter

#### A Word Counter C# Application, 4-26-2019

#### By Megan Schulte

## Description

This web applicaton will gather a word and a sentance from a user and will then check how frequently the word appears in the sentence. It will check for full word matches only. It will then display the total count to the user. It's the coolest app you will ever come across 😎

## Setup/Installation Requirements

* Make a clone from GitHub at: https://github.com/meganschultepdx/fp-word-counter.git
* Open in Atom or similar text editor to view code
* No UI has been added at this time, however you should be able to run dotnet test in the console.

## Specs

|Objectives|example input|example output|
|-|-|-|
|Return 0 if user's word does not appear in sentence.| "rad","I went to the bookstore." | 0 |
|Return 1 if user sentence is single word that matches user's word.|"rad", "rad."|1|
|Return 1 if user's word appears once in sentence longer than one word.|"rad", "I wen't to a rad bookstore."| 1 |
|Return total number of times user's word appears in user sentence if more than once.|"rad", "I went to a rad bookstore full of rad books."| 2 |


## Known Bugs

No known bugs

## Support and contact details

Create a pull request on GitHub.

## Technologies Used

I used C# to build this webpage.

### License

GPL, keep information free.

Copyright (c) 2019 Megan Schulte
