using System;
using Xunit;
using Beatflix.Services;

namespace WebApi.Tests
{
    public class PlaylistTestService
    {
        public PlaylistService playlistService;
        [Fact]
        public void ShouldCreateANewPlaylistGivenANameAndSongs()
        {
            // Arrange
            string name = "Rock 80s";
            var songs = new string [] {"Under Pressure", "Highway Tune", "Another Brick In The Wall"};
            
            playlistService = new PlaylistService();
            // Act
            var playlist = playlistService.createNewPlaylist(name, songs);

            // Assert
            Assert.Equal(name, playlist.Name);
            Assert.NotEmpty(playlist.Songs);

        }
    }
}
