﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Test_Interface_3
{
    class MusicFile 
    {
        private String title;
        private String artist;
        private int yearOfRelease;
        private int durationInSeconds;

        public MusicFile()
        {
            title = "In thje end";
            artist = "Linkin Park";
            yearOfRelease = 2018;
            durationInSeconds = 4;

        }
        public MusicFile(String title,String artist,int yearOfRelease,int durationInSeconds)
        {
            this.title = title;
            this.artist = artist;
            this.yearOfRelease=yearOfRelease;
            this.durationInSeconds=durationInSeconds;

        }
        void changeTitle(string title)
        {
            this.title = title;
        }
    }
}
