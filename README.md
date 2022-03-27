KoreanRomanisation
==================

KoreanRomanisation is a C# library for correctly romanising Korean text.

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



## Usage 

To romanise some Korean text, simply create an instance of the relevant romanisation class, and then call the `RomaniseText()` function.

```csharp
var romanisation = new McCuneReischauerRomanisation();

var koreanText = "안녕 하세요";
var romanisedText = romanisation.RomaniseText(koreanText);

Console.WriteLine(romanisedText); // annyeong haseyo
```

The other romanisation classes are `RevisedRomanisation`, `SimplifiedRomanisation`, and `YaleRomanisation`. The Revised Romanisation is the official one for South Korea, so probably most often the one you want to use, but the McCune-Reischauer Romanisation is the most accurate, the Simplified Romanisation is the easiest for non-Korean-speakers, and the Yale Romanisation is for academia.

Any non-Korean text will, by default, be preserved. If you want to remove any non-Korean text, set the `PreserveNonKoreanText` property on the romanisation class to `false`.

```csharp
var romanisation = new McCuneReischauerRomanisation();

romanisation.PreserveNonKoreanText = false;
```

Additionally, it's often convenient to romanise ㅅ as _sh_ and ㅆ as _ssh_ when they are followed by ㅣ _i_. Setting the `UseSh` property to `true` will make the romanisation classes do this. (It is `true` by default.)

```csharp
var romanisation = new McCuneReischauerRomanisation();

romanisation.UseSh = true;
```

You can also choose to romanise ㅚ as _oi_ instead of _oe_, which, although a less accurate representation of the pronunciation, tends to be less confusing for non-Korean-speakers. 

```csharp
var romanisation = new McCuneReischauerRomanisation();

romanisation.UseOi = true;
```

## Testing 

This library is covered by 1261 unit tests, all passing as of the latest release.

The majority of these tests are of the four main romanisation classes (`McCuneReischauerRomanisation`, `RevisedRomanisation`, `SimplifiedRomanisation`, and `YaleRomanisation`), and they simply check: if the romanisation class is given some Korean text, does it return the correct romanised text.

There are also a small number of unit tests for the `KoreanLetter` and `KoreanSyllable` structs.