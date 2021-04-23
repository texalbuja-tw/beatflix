using Beatflix.Domain;

namespace Beatflix.Services {
    public class PlaylistService {
        public Playlist createNewPlaylist(string name, string [] songs){
            return new Playlist { Name = name, Songs = songs };
        }
    }
}