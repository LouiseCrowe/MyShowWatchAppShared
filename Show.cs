using System;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyShowWatch.Shared
{

    public class Show
    {
        [Required(ErrorMessage ="Please include the show title")]
        public string Title { get; set; }                   // show title

        [Required(ErrorMessage = "Please select a show type")]
        public ShowType ShowType { get; set; }              // movie, tv show, documentary

        public Status Status { get; set; }                  // show ongoing indicates 
                                                            // indicates if or when it will 
                                                            // be available

        public bool IsWatched { get; set; }                 // have you watched the show yet?

        public DateTime? ReleaseDate { get; set; }          // scheduled release date, may be unknown (null)

        public bool ShowComplete { get; set; }              // has the show run finished
                                                            // are there any future releases planned
        public int? NumSeasonsConfirmed { get; set; }       // number of seasons confirmed
                                                            // may or may not be available to view yet
        public int? LatestSeasonAvailable { get; set; }     // number of latest season available

        public int? NumEpisodes { get; set; }               // number of episodes in latest season

        public int? NumMovies { get; set; }                 // number of movies in series

        public int? LatestMovieAvailable { get; set; }      // number of latest movie available

        public bool IsKidFriendly { get; set; }             // suitable for children

        public string Description { get; set; }             // show description                
    }
}

