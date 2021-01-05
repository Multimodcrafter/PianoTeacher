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
        }
    }
}