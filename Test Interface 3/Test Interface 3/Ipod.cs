using System;
using System.Collections.Generic;
using System.Text;

namespace Test_Interface_3
{
    class Ipod :RadioPlayerInterface , MusicPlayerInterface
    {
        MusicFile []
        musicFile = new MusicFile[500];


        public void songs()
    {
        MusicFile song = new MusicFile();
        musicFile[0] = song;
        song = new MusicFile("x", "y", 2010, 4);
        musicFile[1] = song;
    }


    public void changeSong()
    {
        Console.WriteLine("Change Song");
    }

    public void play(bool on)
    {
        Console.WriteLine("Play");
    }

    public void playNext()
    {
        Console.WriteLine("Play next");
    }

    public void playPrevious()
    {
        Console.WriteLine("Play previous");
    }

    public void Return(double frequency)
    {
        Console.WriteLine("Return");
    }

    public void setVolume(int loudness)
    {
        Console.WriteLine("Set volume");
    }

    public void Switch(bool on)
    {
        Console.WriteLine("Switch");
    }

        void RadioPlayerInterface.Switch(bool on)
        {
            throw new NotImplementedException();
        }

        void RadioPlayerInterface.retune(double frequency)
        {
            throw new NotImplementedException();
        }

        void RadioPlayerInterface.setVolume(int loudness)
        {
            throw new NotImplementedException();
        }

        void RadioPlayerInterface.changeChannel()
        {
            throw new NotImplementedException();
        }
    }
}
    