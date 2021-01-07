using System.Collections.Generic;
using System.Linq;

namespace PianoTeacher
{
    public class ChordExercise
    {
        private ChordExerciseConfiguration _configuration;
        private readonly IChordDisplay _display;
        private readonly List<int> _pressedNotes;
        private Chord _currentChord;

        public ChordExercise(IInstrument instrument, IChordDisplay display)
        {
            _display = display;
            instrument.NoteChanged += NoteChanged;
            _pressedNotes = new List<int>();
        }

        private void NoteChanged(int note, int velocity)
        {
            if (velocity > 0)
            {
                _pressedNotes.Add(note);
                CheckChord();
            }
            else
            {
                _pressedNotes.Remove(note);
            }
        }

        private void CheckChord()
        {
            var pressed = _pressedNotes.OrderBy(x => x).ToArray();
            if (_currentChord.Satisfied(pressed))
            {
                GetNextChord();
            }
        }

        private void GetNextChord()
        {
            var nextChord = _configuration.GetRandomChord();
            while (nextChord == _currentChord) nextChord = _configuration.GetRandomChord();
            _currentChord = nextChord;
            _display.DisplayChord(_currentChord.GetName(_configuration.NumericChords));
        }

        public bool StartExercise(ChordExerciseConfiguration config)
        {
            if (!config.RegularChords && !config.ExtendedChords && !config.FlatChords && !config.FourChords &&
                !config.SeventhChords && !config.SixthChords && !config.TwoChords) return false;
            _configuration = config;
            GetNextChord();
            return true;

        }

        public void StopExercise()
        {
            _pressedNotes.Clear();
        }
    }
}