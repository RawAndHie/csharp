using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace SoundApp.Model
{
    public class MusicManager
    {
        public static List<Music> getMusic()
        {
            var sounds = new List<Music>();

            sounds.Add(new Music ( "Hai Triệu Năm", MusicCategory.Den, "Assets/Music/2trieunam.mp3", "Assets/Img/2trieunam.png" ));
            sounds.Add(new Music ( "1 Phút", MusicCategory.Andiez, "Assets/Music/1phut.mp3", "Assets/Img/1phut.jpg"));
            sounds.Add(new Music ( "Bài này chill phết", MusicCategory.Den, "Assets/Music/bainaychillphet.mp3", "Assets/Img/bainaychill.jpg"));
            sounds.Add(new Music ( "Lạ Lùng", MusicCategory.Vu, "Assets/Music/lalung.mp3", "Assets/Img/lalung.jpg"));
            sounds.Add(new Music ( "Suýt nữa thì", MusicCategory.Andiez, "Assets/Music/suytnuathi.mp3", "Assets/Img/suytnuathi.jpg"));
            return sounds;
        }

        public static void GetAllMusic(ObservableCollection<Music> music)
        {
            var allSounds = getMusic();
            music.Clear();
            allSounds.ForEach(p => music.Add(p));
        }

        public static void GetMusicByCategory(ObservableCollection<Music> sounds, MusicCategory musicCategory)
        {
            var allMusic = getMusic();
            var filteredMusic = allMusic.Where(p => p.Category == musicCategory).ToList();
            sounds.Clear();
            filteredMusic.ForEach(p => sounds.Add(p));
        }

        public static void GetMusicByName(ObservableCollection<Music> sounds, string name)
        {
            var allMusic = getMusic();
            var filteredSounds = allMusic.Where(p => p.Name == name).ToList();
            sounds.Clear();
            filteredSounds.ForEach(p => sounds.Add(p));
        }
    }
}
