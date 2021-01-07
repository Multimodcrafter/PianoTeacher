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

        public static readonly MusicKey[] Keys =
        {
            new (0,true),
            new (1,true),
            new (2,true)
        };

        public string DisplayName => NoteNames[BaseNote][0] + " Major";
        private int BaseNote { get; }
        private bool Major { get; }

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
            if (relativeNote > 12) throw new ArgumentOutOfRangeException(nameof(relativeNote), @"must be in [1,12]");
            //A major scale has half-steps from note 3 to 4 and from 7 to 8
            //A minor scale has half-steps from note 2 to 3 and from 5 to 6
            var firstHalfStep = Major ? 4 : 3;
            var secondHalfStep = Major ? 8 : 6;
            var result = BaseNote + (relativeNote - 1) * 2 
                         - (relativeNote >= firstHalfStep ? 1 : 0) 
                         - (relativeNote >= secondHalfStep ? 1 : 0)
                         - (relativeNote >= firstHalfStep + 7 ? 1 : 0);
            return result;
        }

        public string GetChordName(int relativeNote)
        {
            relativeNote %= 8;
            relativeNote = relativeNote == 0 ? 1 : relativeNote;
            return NoteNames[BaseNote][relativeNote - 1] + GetChordExtension(relativeNote);
        }

        public bool IsChordMinor(int relativeNote)
        {
            if (Major)
            {
                return relativeNote == 2 || relativeNote == 3 || relativeNote == 6;
            }

            throw new NotImplementedException("minor scales not supported yet");
        }

        private string GetChordExtension(int relativeNote)
        {
            if (Major)
            {
                switch (relativeNote)
                {
                    case 2:
                    case 3:
                    case 6:
                        return "m";
                    case 7:
                        return "dim";
                    default:
                        return "";
                }
            }
            else
            {
                throw new NotImplementedException("minor scales not supported yet");
            }
        }
    }
}