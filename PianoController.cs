using System;
using System.Collections.Generic;
using NAudio.Midi;

namespace PianoTeacher
{
    internal class PianoController : IDisposable
    {
        private MidiIn _inDevice;
        private MidiOut _outDevice;
        private bool _initialized;

        public static IEnumerable<MidiInCapabilities> GetConnectedInputDevices()
        {
            for(var i = 0; i < MidiIn.NumberOfDevices; ++i)
            {
                yield return MidiIn.DeviceInfo(i);
            }
        }

        public static IEnumerable<MidiOutCapabilities> GetConnectedOutDevices()
        {
            for(var i = 0; i < MidiOut.NumberOfDevices; ++i)
            {
                yield return MidiOut.DeviceInfo(i);
            }
        }

        public void Init(int inDeviceNo, int outDeviceNo)
        {
            if (_initialized)
            {
                _inDevice.Stop();
                _inDevice.Close();
                _inDevice.Dispose();
                _outDevice.Close();
                _outDevice.Dispose();
            }
            _inDevice = new MidiIn(inDeviceNo);
            _outDevice = new MidiOut(outDeviceNo);
            _inDevice.MessageReceived += MessageReceived;
            _inDevice.ErrorReceived += ErrorReceived;
            _inDevice.Start();
            _initialized = true;
        }

        private void MessageReceived(object sender, MidiInMessageEventArgs e)
        {
            if (e.MidiEvent.CommandCode == MidiCommandCode.TimingClock || e.MidiEvent.CommandCode == MidiCommandCode.AutoSensing) return;
            if (e.MidiEvent is NoteEvent note && note.Channel == Configuration.PlayChannel)
            {
                    if (note.Velocity == 0)
                    {
                        
                    }
                    else
                    {
                        
                    }

            }
        }

        private static void ErrorReceived(object sender, MidiInMessageEventArgs e)
        {
            Console.Error.WriteLine("Error: {0}",e.MidiEvent);
        }

        private void SendControl(MidiEvent e)
        {
            _outDevice.Send(e.GetAsShortMessage());
        }

        public void Dispose()
        {
            _inDevice?.Dispose();
            _outDevice?.Dispose();
        }
    }
}
