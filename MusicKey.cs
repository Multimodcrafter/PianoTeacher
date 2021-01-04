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

        public string DisplayName => NoteNames[BaseNote][0] + " Major";
        public int BaseNote { get; }
        public bool Major { get; }

        public MusicKey(int note, bool major)
        {
            BaseNote = note % 12;
            Major = major;
        }

        public int GetAbsoluteNote(int relativeNote)
        {
            relativeNote %= 8;
            relativeNote = relativeNote == 0 ? 1 : relativeNote;
            //A major scale has half-steps from note 3 to 4 and from 7 to 8
            //A minor scale has half-steps from note 2 to 3 and from 5 to 6
            var firstHalfStep = Major ? 4 : 3;
            var secondHalfStep = Major ? 8 : 6;
            var result = BaseNote + (relativeNote - 1) * 2 - (relativeNote >= firstHalfStep ? 1 : 0) - (relativeNote >= secondHalfStep ? 1 : 0);
            return result;
        }

        public string GetChordName(int relativeNote)
        {
            relativeNote %= 8;
            relativeNote = relativeNote == 0 ? 1 : relativeNote;
            return NoteNames[BaseNote][relativeNote - 1] + GetChordExtension(relativeNote);
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