using System;

namespace MyShowWatch.Shared
{

    public class Show
    {
        public string Title { get; set; }                   // show title

        public ShowType ShowType { get; set; }              // movie, tv show, documentary

        public Availability Availability { get; set; }      // show ongoing indicates 
                                                            // indicates if or when it will 
                                                            // be available
        public WatchStatus WatchStatus { get; set; }        // have you watched the show yet?

        public DateTime? ReleaseDate { get; set; }          // scheduled release date, may be unknown (null)

        public RunningStatus RunningStatus { get; set; }    // has the show run finished
                                                            // are there any future releases planned
        public int? NumSeasonsConfirmed { get; set; }       // number of seasons confirmed
                                                            // may or may not be available to view yet
        public int? LatestSeasonAvailable { get; set; }     // number of latest season available

        public int? NumEpisodes { get; set; }               // number of episodes in latest season

        public int? NumMovies { get; set; }                 // number of movies in series

        public int? LatestMovieAvailable { get; set; }      // number of latest movie available

        public AgeRating AgeRating { get; set; }             // suitable for children

        public string Description { get; set; }             // show description                
    }
}

