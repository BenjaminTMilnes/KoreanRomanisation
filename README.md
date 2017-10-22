KoreanRomanisation
==================

KoreanRomanisation is a C# class library for romanising Korean text.

## Key Components

### KoreanLetter

The KoreanLetter struct encapsulates a letter in the Korean language - known as a jamo.

It has a number of internal constants that help define which letter a given character is, as well as shortcuts for instantiating particular Korean letters.
This is useful for implementing some of the rules of romanisation.

### KoreanSyllable

The KoreanSyllable struct encapsulates a syllable in the Korean language - which comprises of an initial, a medial, and a final letter, or just an initial and a medial letter.
Every possible syllable that exists in Korean is stored as a separate character code in Unicode, but in order to romanise any Korean text, you need to know what the
individual letters of the syllable are. The KoreanSyllable struct provides methods for identifying the letters within a syllable.