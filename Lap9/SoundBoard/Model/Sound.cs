﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SoundBoard.Model
{
    public class Sound
    {
        public string Name { get; set; }
        public SoudCategory Category { get; set; }
        public string AudioFile { get; set; }
        public string ImageFile { get; set; }
        public Sound(string name, SoudCategory category)
        {
            Name = name;
            Category = category;
            AudioFile = String.Format("/Assets/Audio/{0}/{1}.wav", category, name);
            ImageFile = String.Format("/Assets/Images/{0}/{1}.png", category, name);

        }
    }
    public enum SoudCategory
    {
        Animals,
        Cartoons,
        Taunts,
        Warnings
    }
    
}
