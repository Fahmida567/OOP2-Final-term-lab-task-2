using System;

namespace Test_Interface_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Ipod i = new Ipod();
            i.songs();
            i.changeSong();
            i.play(true);
            i.playNext();
            i.playPrevious();
            i.Switch(true);
        }
    }
}
