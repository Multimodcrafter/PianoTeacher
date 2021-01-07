namespace PianoTeacher
{
    public interface IInstrument
    {
        public delegate void NoteEventDelegate(int pitch, int velocity);
        public event NoteEventDelegate NoteChanged;
    }
}