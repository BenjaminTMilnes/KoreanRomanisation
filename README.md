KoreanRomanisation
==================

KoreanRomanisation is a C# class library for romanising Korean text.

## Principle of Operation

With this class library, it is possible to take a string of text, which contains some characters from the native Korean script - Hangeul - and convert it 
into a string of text where the Korean characters have been replaced with a representation of their pronunciation using the English alphabet. This class library
can romanise Korean text using any of four systems of romanisation (different romanisation systems have different advantages and disadvantages in terms of accuracy,
readability, writeability, and so on).

The first part of the process is to divide the text that is given into the sections - the Korean text and the non-Korean text. The non-Korean sections are ignored by 
the romanisation (and can either be left in the text as they are, or removed to leave only the romanised Korean). This part of the process
is done by the **GetTextBlock()** function in the base **Romanisation** class. This function takes a string, and returns a **TextBlock** object, which contains a list of **ITextSection**s, 
which are either of the type **KoreanTextSection** for Korean text, or **NonKoreanTextSection** for everything else.

The **RomaniseTextBlock()** function within **Romanisation** then takes this **TextBlock** object, and goes through each section of it. For each **KoreanTextSection**, it will go through each 
of the Korean syllables within that section, and romanise each one based on the rules of the romanisation system.

There are four derived classes: McCuneReischauerRomanisation, RevisedRomanisation, YaleRomanisation, and SimplifiedRomanisation, which each inherit from Romanisation, and can
romanise text according to the rules of those four systems of romanisation. The majority of the rules for each system are defined in a set of five enumerable properties of the class;
however, in several of the systems of romanisation there are certain rules which apply only under very specific circumstances, and depend on a very specific combination of initials, 
medials, and finals over several syllables, and so the entirety of the rules cannot be expressed in this way, and finer rules are sometimes just defined as part of the 
basic romanisation functions for each class.

To romanise text according to a specific system, first create an instance of the romanisation class for the system you want to use, and then call the RomaniseText() function, which
takes a string as its argument, and returns a single string with the romanised text.

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