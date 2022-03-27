KoreanRomanisation
==================

KoreanRomanisation is a C# library for correctly romanising Korean text (taking Korean characters, and replacing them with a representation of their pronunciation using the English alphabet). It can romanise Korean text using any of four systems of romanisation: the McCune-Reischauer Romanisation, the Revised Romanisation, the Simplified Romanisation, and the Yale Romanisation.

## Table of Contents

- [Usage](#usage)
- [Testing](#testing)

## Usage 

To romanise some Korean text, simply create an instance of the relevant romanisation class, and then call the `RomaniseText()` function.

```csharp
var romanisation = new McCuneReischauerRomanisation();

var koreanText = "안녕 하세요";
var romanisedText = romanisation.RomaniseText(koreanText);

Console.WriteLine(romanisedText); // annyŏng haseyo
```

The other romanisation classes are `RevisedRomanisation`, `SimplifiedRomanisation`, and `YaleRomanisation`. The Revised Romanisation is the official one for South Korea, so probably most often the one you want to use, but the McCune-Reischauer Romanisation is the most accurate, the Simplified Romanisation is the easiest for non-Korean-speakers, and the Yale Romanisation is for academia.

Any non-Korean text will, by default, be preserved. If you want to remove any non-Korean text, set the `PreserveNonKoreanText` property on the romanisation class to `false`.

```csharp
var romanisation = new McCuneReischauerRomanisation();

romanisation.PreserveNonKoreanText = false;
```

Additionally, it's often convenient to romanise ㅅ as _sh_ and ㅆ as _ssh_ when they are followed by ㅣ _i_. The romanisation classes do this by default. If you don't want them to do this, set the `UseSh` property to `false`.

```csharp
var romanisation = new McCuneReischauerRomanisation();

romanisation.UseSh = false;
```

You can also choose to romanise ㅚ as _oi_ instead of _oe_, which, although a less accurate representation of the pronunciation, tends to be less confusing for non-Korean-speakers. 

```csharp
var romanisation = new McCuneReischauerRomanisation();

romanisation.UseOi = true;
```

## The Simplified Romanisation of Korean

The Simplified Romanisation of Korean is a system of romanisation created by me (B. T. Milnes). It's designed to be easier to read for people who have no knowledge of Korean whatsoever. The Revised Romanisation uses some digraphs that often confuse non-Korean-speakers, such as _eo_ and _eu_. The Simplified Romanisation of Korean uses digraphs that should be more intuitive for those unfamiliar with the language.

## Testing 

This library is covered by 1261 unit tests, all passing as of the latest release.

The majority of these tests are of the four main romanisation classes (`McCuneReischauerRomanisation`, `RevisedRomanisation`, `SimplifiedRomanisation`, and `YaleRomanisation`), and they simply check: if the romanisation class is given some Korean text, does it return the correct romanised text.

There are also a small number of unit tests for the `KoreanLetter` and `KoreanSyllable` structs.