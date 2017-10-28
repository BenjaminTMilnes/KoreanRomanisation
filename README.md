KoreanRomanisation
==================

KoreanRomanisation is a C# class library for romanising Korean text.

## Key Components

### Structures to identify Korean characters

#### KoreanLetter

The KoreanLetter struct encapsulates a letter in the Korean language - known as a jamo.

It has a number of internal constants that help define which letter a given character is, as well as shortcuts for instantiating particular Korean letters.
This is useful for implementing some of the rules of romanisation.

#### KoreanSyllable

The KoreanSyllable struct encapsulates a syllable in the Korean language - which comprises of an initial, a medial, and a final letter, or just an initial and a medial letter.
Every possible syllable that exists in Korean is stored as a separate character code in Unicode, but in order to romanise any Korean text, you need to know what the
individual letters of the syllable are. The KoreanSyllable struct provides methods for identifying the letters within a syllable.

### Structures for processing input text

#### TextBlock

Represents a generic block of text, which can be described in terms of Korean and non-Korean sections. Any text that is passed through to the romanisation converters is first
converted into a TextBlock object.

#### KoreanTextSection

Represents a section of Korean text, which is made up of syllabic blocks.

#### NonKoreanTextSection

Represents a section of non-Korean text. This is just a text string, and it is ignored by the romanisation converter.

### Defining romanisation rules

#### TupleList

There are two TupleList classes, and they both simply represent a list of tuples.

These simple classes allow for easy hardcoding of romanisation data into the class library. The shortest way to express a romanisation rule is as a tuple, which requires
minimal markup. TupleList allows a large number of tuples to be added to a list with very little markup.

### Romanisation Converters

#### Romanisation

The Romanisation class acts as a base class for other specific romanisation schemes. It encapsulates the basic properties of a romanisation converter, such as whether it will
explicitly romanise ㅅ as 'sh' when it is followed by ㅣ. It also contains the functions used to deconstruct a passage of text into its Korean and non-Korean components, 
as well as core, overridable functions that are used to romanise the text.

#### IRomanisation

A further abstraction of the concept of a romanisation converter. There are only three official systems of romanisation for Korean, so it is unlikely that anyone would want
to write a custom converter - even less so one that didn't implement the Romanisation base class. But if they did, the IRomanisation describes the basic features of a
romanisation converter.

## Unit Tests

The KoreanRomanisation library is covered by a large number of unit tests - 1239 of them.