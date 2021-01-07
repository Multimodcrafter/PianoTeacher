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
        Normal = 0, First = 1, Second = 2, Third = 3
    }
    
    public readonly struct Chord
    {
        private bool Equals(Chord other)
        {
            if (ExpectedNotes == null || other.ExpectedNotes == null) return false;
            return ExpectedNotes.SequenceEqual(other.ExpectedNotes);
        }

        public override bool Equals(object obj)
        {
            return obj is Chord other && Equals(other);
        }

        public override int GetHashCode()
        {
            return ExpectedNotes.GetHashCode();
        }

        public static bool operator ==(Chord left, Chord right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Chord left, Chord right)
        {
            return !left.Equals(right);
        }

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
                ChordVariant.Add2 => Number + 1,
                ChordVariant.Suspended => Number + 3,
                _ => Number + 2
            };
            var thirdRelative = Variant switch
            {
                ChordVariant.Six => Number + 5,
                ChordVariant.Add4 => Number + 3,
                ChordVariant.Add2 => Number + 2,
                _ => Number + 4
            };
            var fourthRelative = Variant switch
            {
                ChordVariant.Add2 => Number + 4,
                ChordVariant.Add4 => Number + 4,
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
                    secondAbsolute = baseNote + 4;
                    thirdAbsolute = secondAbsolute + 3;
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
                        //shift inverted notes by an octave so chord satisfaction works as expected (notes need to be monotonically increasing)
                        ChordInversion.Normal => new[] {baseNote, secondAbsolute, thirdAbsolute, fourthAbsolute},
                        ChordInversion.First => new []{secondAbsolute,thirdAbsolute,fourthAbsolute,baseNote + 12},
                        ChordInversion.Second => new []{thirdAbsolute,fourthAbsolute,baseNote + 12,secondAbsolute + 12},
                        ChordInversion.Third => new []{fourthAbsolute,baseNote + 12,secondAbsolute + 12,thirdAbsolute + 12},
                        _ => Array.Empty<int>()
                    };
                    break;
                default:
                    ExpectedNotes = Inversion switch
                    {
                        ChordInversion.First => new []{secondAbsolute,thirdAbsolute,baseNote + 12},
                        ChordInversion.Second => new []{thirdAbsolute,baseNote + 12,secondAbsolute + 12},
                        _ => new[] {baseNote, secondAbsolute, thirdAbsolute}
                    };
                    break;
            }
        }

        public bool Satisfied(int[] notes)
        {
            Console.WriteLine($@"got: {string.Join(',',notes)}, expected: {string.Join(',',ExpectedNotes)}");
            var shift = ExpectedNotes[0] - notes[0];
            Console.WriteLine($@"calculated shift: {shift}, mod 12: {shift%12}");
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

            if (Inversion != ChordInversion.Normal) result += $"/{(int)Inversion}";
            
            return result;
        }
    }
}