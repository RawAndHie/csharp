using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundApp.Model
{
    public enum MusicCategory
    {
        Den,
        Vu,
        Andiez
    }
    public class Music
    {
        public string Name { get; set; }
        public MusicCategory Category { get; set; }
        public string AudioFile { get; set; }
        public string ImageFile { get; set; }

        public Music(string name, MusicCategory category, string audioFile, string imgFile)
        {
            Name = name;
            Category = category;
            AudioFile = audioFile;
            ImageFile = imgFile;
        }
    }
}
