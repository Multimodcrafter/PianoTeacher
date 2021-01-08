using System;
using System.Collections.Generic;
using System.Linq;

namespace PianoTeacher
{
    public readonly struct Chord
    {
        private int Number { get; }
        private MusicKey Key { get; }
        private ChordVariant Variant { get; }
        private int Inversion { get; }
        private int[] ExpectedNotes { get; }

        public Chord(int num, MusicKey key, ChordVariant variant, int inversion)
        {
            Number = num % 8 == 0 ? 1 : num % 8;
            Key = key;
            Variant = variant;
            Inversion = inversion;

            if (Key.Major && !Variant.BasesInMajScale.Contains(Number))
                throw new ArgumentOutOfRangeException(nameof(num),
                    $@"is not supported for variant {Variant.DisplayName}");
            if (Inversion > Variant.Intervals.Length)
                throw new ArgumentOutOfRangeException(nameof(inversion),
                    $@"{Variant.DisplayName} has only {Variant.Intervals.Length} inversions");

            var baseNote = Key.GetAbsoluteNote(Number);
            var notes = new List<int> {baseNote};
            foreach (var interval in Variant.Intervals)
            {
                notes.Add(notes.Last() + interval);
            }

            //shift inverted notes by an octave so chord satisfaction works as expected (notes need to be monotonically increasing)
            for (var i = 0; i < Inversion; ++i)
            {
                notes.Add(notes.First() + 12);
                notes.RemoveAt(0);
            }

            ExpectedNotes = notes.ToArray();
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
            var result = numeric ? Number.ToString() : Key.GetNoteName(Number);

            result += Variant.ChordSuffix;

            if (Inversion == 0) return result;
            
            var newBaseRelative = Key.GetRelativeNote(ExpectedNotes[0]);
            result += $"/{(numeric ? newBaseRelative.ToString() : Key.GetNoteName(newBaseRelative))}";

            return result;
        }
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
    }
}