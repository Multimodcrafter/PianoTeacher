using System;
using System.Linq;

namespace PianoTeacher
{
    public enum ChordVariant
    {
        Regular, Suspended, Add4, Two, Add2, Major7, Minor7, Flat, Diminished, Augmented, Six, Add6
    }

    public enum ChordInversion
    {
        Normal, First, Second, Third
    }
    
    public readonly struct Chord
    {
        private int Number { get; }
        private MusicKey Key { get; }
        private ChordVariant Variant { get; }
        private ChordInversion Inversion { get; }
        private int[] ExpectedNotes { get; }

        public Chord(int num, MusicKey key, ChordVariant variant, ChordInversion inv)
        {
            Number = num % 8 == 0 ? 1 : num % 8;
            Key = key;
            Variant = variant;
            Inversion = inv;

            var baseNote = Key.GetAbsoluteNote(Number);
            var secondRelative = Variant switch
            {
                ChordVariant.Two => Number + 1,
                ChordVariant.Suspended => Number + 3,
                _ => Number + 2
            };
            var thirdRelative = Variant switch
            {
                ChordVariant.Six => Number + 5,
                _ => Number + 4
            };
            var fourthRelative = Variant switch
            {
                ChordVariant.Add2 => Number + 1,
                ChordVariant.Add4 => Number + 3,
                ChordVariant.Add6 => Number + 5,
                _ => 0
            };
            var secondAbsolute = Key.GetAbsoluteNote(secondRelative);
            var thirdAbsolute = Key.GetAbsoluteNote(thirdRelative);
            var fourthAbsolute = Key.GetAbsoluteNote(fourthRelative);
            // ReSharper disable once SwitchStatementMissingSomeEnumCasesNoDefault
            switch (Variant)
            {
                case ChordVariant.Augmented:
                    thirdAbsolute += 1;
                    break;
                case ChordVariant.Diminished:
                    thirdAbsolute -= 1;
                    break;
                case ChordVariant.Flat:
                    baseNote -= 1;
                    secondAbsolute -= 1;
                    thirdAbsolute -= 1;
                    break;
                case ChordVariant.Major7:
                    fourthAbsolute = baseNote + 11;
                    break;
                case ChordVariant.Minor7:
                    fourthAbsolute = baseNote + 10;
                    break;
            }

            // ReSharper disable once SwitchStatementHandlesSomeKnownEnumValuesWithDefault
            switch (Variant)
            {
                case ChordVariant.Add2:
                case ChordVariant.Add4:
                case ChordVariant.Add6:
                case ChordVariant.Major7:
                case ChordVariant.Minor7:
                    ExpectedNotes = Inversion switch
                    {
                        ChordInversion.Normal => new[] {baseNote, secondAbsolute, thirdAbsolute, fourthAbsolute},
                        ChordInversion.First => new []{secondAbsolute,thirdAbsolute,fourthAbsolute,baseNote},
                        ChordInversion.Second => new []{thirdAbsolute,fourthAbsolute,baseNote,secondAbsolute},
                        ChordInversion.Third => new []{fourthAbsolute,baseNote,secondAbsolute,thirdAbsolute},
                        _ => Array.Empty<int>()
                    };
                    break;
                default:
                    ExpectedNotes = Inversion switch
                    {
                        ChordInversion.First => new []{secondAbsolute,thirdAbsolute,baseNote},
                        ChordInversion.Second => new []{thirdAbsolute,baseNote,secondAbsolute},
                        _ => new[] {baseNote, secondAbsolute, thirdAbsolute}
                    };
                    break;
            }
        }

        public bool Satisfied(int[] notes)
        {
            var shift = ExpectedNotes[0] - notes[0];
            if (shift % 12 != 0) return false;
            for (var i = 0; i < notes.Length; ++i)
            {
                notes[i] += shift;
            }

            return ExpectedNotes.SequenceEqual(notes);
        }

        public string GetName(bool numeric)
        {
            var result = numeric ? Number.ToString() : Key.GetChordName(Number);
            // ReSharper disable once SwitchStatementMissingSomeEnumCasesNoDefault
            switch (Variant)
            {
                case ChordVariant.Suspended:
                    result += "sus";
                    break;
                case ChordVariant.Add4:
                    result += "add4";
                    break;
                case ChordVariant.Two:
                    result += "2";
                    break;
                case ChordVariant.Add2:
                    result += "add2";
                    break;
                case ChordVariant.Major7:
                    result += "M7";
                    break;
                case ChordVariant.Minor7:
                    result += "7";
                    break;
                case ChordVariant.Flat:
                    result = "b" + result;
                    break;
                case ChordVariant.Diminished:
                    result += "dim";
                    break;
                case ChordVariant.Augmented:
                    result += "+";
                    break;
                case ChordVariant.Six:
                    result += "6";
                    break;
                case ChordVariant.Add6:
                    result += "add6";
                    break;
            }
            return result;
        }
    }
}