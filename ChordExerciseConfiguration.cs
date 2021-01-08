using System;

namespace PianoTeacher
{
    public readonly struct ChordExerciseConfiguration
    {
        public MusicKey Key { get; }
        public bool NumericChords { get; }
        public bool Inversions { get; }
        public ChordVariant[] Variants { get; }
        
        private readonly Random _random;

        public ChordExerciseConfiguration(MusicKey key, bool numericChords, ChordVariant[] variants, bool inversions)
        {
            Key = key;
            NumericChords = numericChords;
            Inversions = inversions;
            Variants = variants;
            _random = new Random();
        }
        
        public Chord GetRandomChord()
        {
            var variant = Variants[_random.Next(Variants.Length)];
            int chordNumber;
            if (Key.Major) chordNumber = variant.BasesInMajScale[_random.Next(variant.BasesInMajScale.Length)];
            else throw new NotImplementedException("minor scales not implemented yet");
            var inversion = Inversions ? _random.Next(variant.Intervals.Length) : 0;
            return new Chord(chordNumber, Key, variant, inversion);
        }
    }
}