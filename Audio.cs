using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GTA;
using NAudio.Wave;

namespace NaV
{
    internal class Audio : Script
    {
        private static WaveFileReader wave;
        private static WaveChannel32 wave1;
        private static DirectSoundOut output;
        private static float volume;
        public Audio()
        {
            volume = Settings.GetValue<float>("SETTINGS", "volume", 0.5f);
            disposeAudio();
        }
        
           public static void playDir(int _dir, float dist, bool spamBlock)
            {
                if (!spamBlock)
                {
                    if (dist <= 800 && dist >= 500)
                    {
                        
                        wave = new NAudio.Wave.WaveFileReader("scripts/navAudio/IN.wav");
                        output = new NAudio.Wave.DirectSoundOut();
                        output.Init(wave1 = new NAudio.Wave.WaveChannel32(wave));
                        wave1.Volume = volume;
                        output.Play();
                        Wait(441);
                        disposeAudio();
                        wave = new NAudio.Wave.WaveFileReader("scripts/navAudio/800.wav");
                        output = new NAudio.Wave.DirectSoundOut();
                        output.Init(wave1 = new NAudio.Wave.WaveChannel32(wave));
                        wave1.Volume = volume;
                        output.Play();
                        Wait(1412);
                        disposeAudio();
                        wave = new NAudio.Wave.WaveFileReader("scripts/navAudio/YARDS.wav");
                        output = new NAudio.Wave.DirectSoundOut();
                        output.Init(wave1 = new NAudio.Wave.WaveChannel32(wave));
                        wave1.Volume = volume;
                        output.Play();
                        Wait(1180);
                        disposeAudio();
                    }
                    else if (dist <= 500 && dist > 300)
                    {
                        wave = new NAudio.Wave.WaveFileReader("scripts/navAudio/IN.wav");
                        output = new NAudio.Wave.DirectSoundOut();
                        output.Init(wave1 = new NAudio.Wave.WaveChannel32(wave));
                        wave1.Volume = volume;
                        output.Play();
                        Wait(441);
                        disposeAudio();
                        wave = new NAudio.Wave.WaveFileReader("scripts/navAudio/500.wav");
                        output = new NAudio.Wave.DirectSoundOut();
                        output.Init(wave1 = new NAudio.Wave.WaveChannel32(wave));
                        wave1.Volume = volume;
                        output.Play();
                        Wait(1277);
                        disposeAudio();
                        wave = new NAudio.Wave.WaveFileReader("scripts/navAudio/YARDS.wav");
                        output = new NAudio.Wave.DirectSoundOut();
                        output.Init(wave1 = new NAudio.Wave.WaveChannel32(wave));
                        wave1.Volume = volume;
                        output.Play();
                        Wait(1180);
                        disposeAudio();
                    }

                    else if (dist <= 200 && dist > 100)
                    {
                        
                        wave = new NAudio.Wave.WaveFileReader("scripts/navAudio/IN.wav");
                        output = new NAudio.Wave.DirectSoundOut();
                        output.Init(wave1 = new NAudio.Wave.WaveChannel32(wave));
                        wave1.Volume = volume;
                        output.Play();
                        Wait(441);
                        disposeAudio();
                        wave = new NAudio.Wave.WaveFileReader("scripts/navAudio/200.wav");
                        output = new NAudio.Wave.DirectSoundOut();
                        output.Init(wave1 = new NAudio.Wave.WaveChannel32(wave));
                        wave1.Volume = volume;
                        output.Play();
                        Wait(1336);
                        disposeAudio();
                        wave = new NAudio.Wave.WaveFileReader("scripts/navAudio/YARDS.wav");
                        output = new NAudio.Wave.DirectSoundOut();
                        output.Init(wave1 = new NAudio.Wave.WaveChannel32(wave));
                        wave1.Volume = volume;
                        output.Play();
                        Wait(1180);
                        disposeAudio();
                    }
                    switch (_dir)
                    {
                        case -1:
                            
                            wave = new NAudio.Wave.WaveFileReader("scripts/navAudio/UHAVEARRIVED.wav");
                            output = new NAudio.Wave.DirectSoundOut();
                            output.Init(wave1 = new NAudio.Wave.WaveChannel32(wave));
                            wave1.Volume = volume;
                            output.Play();
                            Wait(1860);
                            disposeAudio();
                            break;

                        case 0:
                            break;

                        case 1:
                            spamBlock = true;
                            
                            wave = new NAudio.Wave.WaveFileReader("scripts/navAudio/RECALCULATING.wav");
                            output = new NAudio.Wave.DirectSoundOut();
                            output.Init(wave1 = new NAudio.Wave.WaveChannel32(wave));
                            wave1.Volume = volume;
                            output.Play();
                            Wait(2080);
                            disposeAudio();
                            break;
                        /*
                    case 2:
                        spamBlock = true;
                        wave = new NAudio.Wave.WaveFileReader("scripts/navAudio/HIGHLIGHTEDROUTE.wav");
                        output = new NAudio.Wave.DirectSoundOut();
                        output.Init(new NAudio.Wave.WaveChannel32(wave));
                        output.Play();
                        Wait(2897);
                        disposeAudio();
                        break;
                        */
                        case 3:
                            spamBlock = true;
                            wave = new NAudio.Wave.WaveFileReader("scripts/navAudio/TURN.wav");
                            output = new NAudio.Wave.DirectSoundOut();
                            output.Init(wave1 = new NAudio.Wave.WaveChannel32(wave));
                            wave1.Volume = volume;
                            output.Play();
                            Wait(780);
                            disposeAudio();
                            wave = new NAudio.Wave.WaveFileReader("scripts/navAudio/LEFT.wav");
                            output = new NAudio.Wave.DirectSoundOut();
                            output.Init(wave1 = new NAudio.Wave.WaveChannel32(wave));
                            wave1.Volume = volume;
                            output.Play();
                            Wait(1125);
                            disposeAudio();
                            break;
                        case 4:
                            spamBlock = true;
                            wave = new NAudio.Wave.WaveFileReader("scripts/navAudio/TURN.WAV");
                            output = new NAudio.Wave.DirectSoundOut();
                            output.Init(wave1 = new NAudio.Wave.WaveChannel32(wave));
                            wave1.Volume = volume;
                            output.Play();
                            Wait(780);
                            disposeAudio();
                            wave = new NAudio.Wave.WaveFileReader("scripts/navAudio/RIGHT.wav");
                            output = new NAudio.Wave.DirectSoundOut();
                            output.Init(wave1 = new NAudio.Wave.WaveChannel32(wave));
                            wave1.Volume = volume;
                            output.Play();
                            Wait(902);
                            disposeAudio();
                            break;
                        case 5:
                            spamBlock = true;
                            
                            wave = new NAudio.Wave.WaveFileReader("scripts/navAudio/STRAIGHTAHEAD.WAV");
                            output = new NAudio.Wave.DirectSoundOut();
                            output.Init(wave1 = new NAudio.Wave.WaveChannel32(wave));
                            wave1.Volume = volume;
                            output.Play();
                            Wait(1620);
                            disposeAudio();
                        break;
                        case 6:
                            
                            spamBlock = true;
                            wave = new NAudio.Wave.WaveFileReader("scripts/navAudio/EXITFREEWAY.WAV");
                            output = new NAudio.Wave.DirectSoundOut();
                            output.Init(wave1 = new NAudio.Wave.WaveChannel32(wave));
                            wave1.Volume = volume;
                            output.Play();
                            Wait(500);
                            disposeAudio();
                            
                            wave = new NAudio.Wave.WaveFileReader("scripts/navAudio/LEFT.WAV");
                            output = new NAudio.Wave.DirectSoundOut();
                            output.Init(wave1 = new NAudio.Wave.WaveChannel32(wave));
                            wave1.Volume = volume;
                            output.Play();
                            Wait(2894);
                            disposeAudio();
                            break;
                        case 7:
                            
                            spamBlock = true;
                            wave = new NAudio.Wave.WaveFileReader("scripts/navAudio/EXITFREEWAY.WAV");
                            output = new NAudio.Wave.DirectSoundOut();
                            output.Init(wave1 = new NAudio.Wave.WaveChannel32(wave));
                            wave1.Volume = volume;
                            output.Play();
                            Wait(500);
                            disposeAudio();
                            
                            wave = new NAudio.Wave.WaveFileReader("scripts/navAudio/RIGHT.WAV");
                            output = new NAudio.Wave.DirectSoundOut();
                            output.Init(wave1 = new NAudio.Wave.WaveChannel32(wave));
                            wave1.Volume = volume;
                            output.Play();
                            Wait(2894);
                            disposeAudio();
                            break;
                        case 9:
                            wave = new NAudio.Wave.WaveFileReader("scripts/navAudio/TONE.WAV");
                            output = new NAudio.Wave.DirectSoundOut();
                            output.Init(wave1 = new NAudio.Wave.WaveChannel32(wave));
                            wave1.Volume = volume;
                            output.Play();
                            Wait(1378);
                            disposeAudio();
                            wave = new NAudio.Wave.WaveFileReader("scripts/navAudio/CALCULATINROUTE.WAV");
                            output = new NAudio.Wave.DirectSoundOut();
                            output.Init(wave1 = new NAudio.Wave.WaveChannel32(wave));
                            wave1.Volume = volume;
                            output.Play();
                            Wait(1980);
                            disposeAudio();
                            wave = new NAudio.Wave.WaveFileReader("scripts/navAudio/HIGHLIGHTEDROUTE.WAV");
                            output = new NAudio.Wave.DirectSoundOut();
                            output.Init(wave1 = new NAudio.Wave.WaveChannel32(wave));
                            wave1.Volume = volume;
                            output.Play();
                            Wait(2497);
                            disposeAudio();
                            break;
                    }
                }
            }
           public static void disposeAudio()
            {
                if (output != null)
                {
                    if (output.PlaybackState == NAudio.Wave.PlaybackState.Playing)
                    {
                        output.Stop();
                        output.Dispose();
                        output = null;
                        //GTA.UI.Screen.ShowHelpText("Disposed output", 1000, true, false);
                    }
                }
                if (wave != null)
                {
                    wave.Dispose();
                    wave = null;
                    // GTA.UI.Screen.ShowHelpText("Disposed wave", 1000, true, false);
                }
            }
        }
    }

