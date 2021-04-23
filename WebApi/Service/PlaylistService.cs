using System;
using Beatflix.Domain;

namespace Beatflix.Services {
    public class PlaylistService {
        public Playlist createNewPlaylist(string name, string [] songs){
            var playlist =  new Playlist { Name = name, Songs = songs };
            Array.Sort(playlist.Songs);
            return playlist;
        }
    }
}