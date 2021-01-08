#nullable enable
using System;

namespace PianoTeacher
{
    public readonly struct MusicKey
    {
        private static readonly string[][] NoteNames =
        {
            new[] {"C" ,"D" ,"E" ,"F" ,"G" ,"A" ,"B" }, //C  Major
            new[] {"C#","D#","E#","F#","G#","A#","B#"}, //C# Major
            new[] {"D" ,"E" ,"F#","G" ,"A" ,"B" ,"C#"}, //D  Major
            new[] {"Eb","F" ,"G" ,"Ab","Bb","C" ,"D" }, //Eb Major
            new[] {"E" ,"F#","G#","A" ,"B" ,"C#","D#"}, //E  Major
            new[] {"F" ,"G" ,"A" ,"Bb","C" ,"D" ,"E" }, //F  Major
            new[] {"F#","G#","A#","B" ,"C#","D#","E#"}, //F# Major
            new[] {"G" ,"A" ,"B" ,"C" ,"D" ,"E" ,"F#"}, //G  Major
            new[] {"Ab","Bb","C" ,"Db","Eb","F" ,"G" }, //Ab Major
            new[] {"A" ,"B" ,"C#","D" ,"E" ,"F#","G#"}, //A  Major
            new[] {"Bb","C" ,"D" ,"Eb","F" ,"G" ,"A" }, //Bb Major
            new[] {"B" ,"C#","D#","E" ,"F#","G#","A#"}  //B  Major
        };

        private static readonly int[] AbsoluteNoteMapMaj = {1,-1,2,-1,3,4,-1,5,-1,6,-1,7};

        public static readonly MusicKey[] Keys =
        {
            new(0,true),
            new(1,true),
            new(2,true),
            new(3,true),
            new(4,true),
            new(5,true),
            new(6,true),
            new(7,true),
            new(8,true),
            new(9,true),
            new(10,true),
            new(11,true)
        };

        public string DisplayName => NoteNames[BaseNote][0] + " Major";
        private int BaseNote { get; }
        public bool Major { get; }

        private MusicKey(int note, bool major)
        {
            BaseNote = note % 12;
            Major = major;
        }

        public override bool Equals(object? obj)
        {
            return obj is MusicKey other && Equals(other);
        }
        
        private bool Equals(MusicKey other)
        {
            return BaseNote == other.BaseNote && Major == other.Major;
        }
        
        public static bool operator ==(MusicKey left, MusicKey right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(MusicKey left, MusicKey right)
        {
            return !(left == right);
        }
        
        public override int GetHashCode()
        {
            return HashCode.Combine(BaseNote, Major);
        }

        public int GetAbsoluteNote(int relativeNote)
        {
            if (relativeNote > 7 || relativeNote < 1) throw new ArgumentOutOfRangeException(nameof(relativeNote), @"must be in [1,7]");
            //A major scale has half-steps from note 3 to 4 and from 7 to 8
            //A minor scale has half-steps from note 2 to 3 and from 5 to 6
            var firstHalfStep = Major ? 4 : 3;
            var secondHalfStep = Major ? 8 : 6;
            var result = BaseNote + (relativeNote - 1) * 2 
                         - (relativeNote >= firstHalfStep ? 1 : 0) 
                         - (relativeNote >= secondHalfStep ? 1 : 0);
            return result;
        }

        public int GetRelativeNote(int absoluteNote)
        {
            absoluteNote -= BaseNote;
            absoluteNote %= 12;
            if (Major) return AbsoluteNoteMapMaj[absoluteNote];
            throw new NotImplementedException("Minor scales are not supported yet");
        }

        public string GetNoteName(int relativeNote)
        {
            relativeNote %= 8;
            relativeNote = relativeNote == 0 ? 1 : relativeNote;
            return NoteNames[BaseNote][relativeNote - 1];
        }
    }
}