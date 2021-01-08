namespace PianoTeacher
{
    public readonly struct ChordVariant
    {
        public static readonly ChordVariant[] Variants = {
            new("Major","",new []{4,3},new []{1,4,5}),
            new("Minor","m",new []{3,4},new []{2,3,6}),
            new("Diminished","dim",new []{3,3},new []{7}),
            new("Two","²",new []{2,5},new []{1,2,4,5,6}),
            new("Add2 Major","⁺²",new []{2,2,3},new []{1,4,5}),
            new("Add2 Minor","m⁺²",new []{2,1,4},new []{2,6}),
            new("Suspended","sus",new []{5,2},new []{1,2,3,5,6}),
            new("Add4 Major","⁺⁴",new []{4,1,2},new []{1,5}),
            new("Add4 Minor","m⁺⁴",new []{3,2,2},new []{2,3,6}),
            new("Major 7th","M⁷",new []{4,3,4},new []{1,4}),
            new("Minor 7th","m⁷",new []{3,4,3},new []{2,3,6}),
            new("Dominant 7th","⁷",new []{4,3,3},new []{5}),
            new("Six Major","⁶",new []{4,5},new []{1,4,5}),
            new("Add6 Major","⁶",new []{4,3,2},new []{1,4,5})
        };
        public int[] Intervals { get; }
        public string DisplayName { get; }
        public int[] BasesInMajScale { get; }
        public string ChordSuffix { get; }

        private ChordVariant(string name, string suffix, int[] intervals, int[] bases)
        {
            Intervals = intervals;
            DisplayName = name;
            BasesInMajScale = bases;
            ChordSuffix = suffix;
        }

        public override string ToString()
        {
            return DisplayName;
        }
    }
}