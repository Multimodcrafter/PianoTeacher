using System;
using System.Collections.Generic;

namespace PianoTeacher
{
    public readonly struct ChordExerciseConfiguration
    {
        public MusicKey Key { get; }
        public bool NumericChords { get; }
        public bool RegularChords { get; }
        public bool FourChords { get; }
        public bool TwoChords { get; }
        public bool SeventhChords { get; }
        public bool SixthChords { get; }
        public bool FlatChords { get; }
        public bool Inversions { get; }
        public bool ExtendedChords { get; }

        private readonly List<ChordVariant> _variantList;
        private readonly Random _random;

        public ChordExerciseConfiguration(MusicKey key, bool numChords, bool regular, bool four, bool two, bool seven,
            bool six, bool flat, bool extended, bool inversions)
        {
            Key = key;
            NumericChords = numChords;
            RegularChords = regular;
            FourChords = four;
            TwoChords = two;
            SeventhChords = seven;
            SixthChords = six;
            FlatChords = flat;
            Inversions = inversions;
            ExtendedChords = extended;
            _random = new Random();
            _variantList = new List<ChordVariant>();
            if(RegularChords) _variantList.Add(ChordVariant.Regular);
            if(FourChords) _variantList.AddRange(new []{ChordVariant.Add4,ChordVariant.Suspended});
            if(TwoChords) _variantList.AddRange(new [] {ChordVariant.Add2,ChordVariant.Two});
            if(SeventhChords) _variantList.AddRange(new [] {ChordVariant.Major7,ChordVariant.Minor7});
            if(SixthChords) _variantList.AddRange(new [] {ChordVariant.Add6, ChordVariant.Six});
            if(FlatChords) _variantList.Add(ChordVariant.Flat);
            if(ExtendedChords) _variantList.AddRange(new []{ChordVariant.Diminished,ChordVariant.Augmented});
        }

        private static readonly ChordInversion[] ThreeInv = {ChordInversion.Normal, ChordInversion.First, ChordInversion.Second};

        private static readonly ChordInversion[] FourInv = 
            {ChordInversion.Normal, ChordInversion.First, ChordInversion.Second, ChordInversion.Third};
        
        public Chord GetRandomChord()
        {
            var variant = _variantList[_random.Next(_variantList.Count)];
            while (true)
            {
                var chordNumber = _random.Next(1, 8);
                //Chord 7 is a diminished chord in its regular form, hence it's only available in regular form
                if (chordNumber == 7)
                {
                    if (!RegularChords) continue;
                    variant = ChordVariant.Regular;
                }

                //Minor chords do not have a major 7 variant, so try again if that happened to be selected
                if (variant == ChordVariant.Major7 && Key.IsChordMinor(chordNumber)) continue;
                //We only want flat 6 and flat 7 to appear
                if (chordNumber != 6 && chordNumber != 7 && variant == ChordVariant.Flat) continue;

                var inversionList = variant switch
                {
                    ChordVariant.Major7 => FourInv,
                    ChordVariant.Minor7 => FourInv,
                    ChordVariant.Add2 => FourInv,
                    ChordVariant.Add4 => FourInv,
                    ChordVariant.Add6 => FourInv,
                    _ => ThreeInv
                };
                var inversion = Inversions ? inversionList[_random.Next(inversionList.Length)] : ChordInversion.Normal;

                return new Chord(chordNumber, Key, variant, inversion);
            }
        }
    }
}