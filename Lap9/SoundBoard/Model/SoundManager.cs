using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoundBoard.Model;

namespace SoundBoard.Model
{
    class SoundManager
    {
      
        public static void GetSoundByCategory(ObservableCollection<Sound> sounds, SoudCategory soudCategory)
        {
            var allSounds = getSounds();
            var filteredSounds = allSounds.Where(p => p.Category == soudCategory).ToList();
            sounds.Clear();
            filteredSounds.ForEach(p => sounds.Add(p));
        }
        public static void GetAllSounds(ObservableCollection<Sound> sounds)
        {
            var allSounds = getSounds();
            sounds.Clear();
            allSounds.ForEach(p => sounds.Add(p));
        }

        private static List<Sound> getSounds()
        {
            var sounds = new List<Sound>();

            sounds.Add(new Sound("Cow", SoudCategory.Animals));
            sounds.Add(new Sound("Cat", SoudCategory.Animals));

            sounds.Add(new Sound("Gun", SoudCategory.Cartoons));
            sounds.Add(new Sound("Spring", SoudCategory.Cartoons));

            sounds.Add(new Sound("Clock", SoudCategory.Taunts));
            sounds.Add(new Sound("LOL", SoudCategory.Taunts));

            sounds.Add(new Sound("Ship", SoudCategory.Warnings));
            sounds.Add(new Sound("Siren", SoudCategory.Warnings));

            return sounds;
        }
        public static void GetSoundsByName(ObservableCollection<Sound> sounds,string name)
        {
            var allSounds = getSounds();
            var filteredSounds = allSounds.Where(p => p.Name == name).ToList();
            sounds.Clear();
            filteredSounds.ForEach(p => sounds.Add(p));
        }
    }
}
