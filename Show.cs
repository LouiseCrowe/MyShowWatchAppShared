using System;
using System.Collections.Generic;
using System.Text;

namespace MyShowWatch.Shared
{
   
    public class Show
    {
        public string Title { get; set; }

        public ShowType ShowType { get; set; }

        public Status Status { get; set; }

        public DateTime? ReleaseDate { get; set; }

        public bool IsKidFriendly { get; set; }

        public int? LatestSeason { get; set; }

        public int? NumEpisodes { get; set; }

        public string Description { get; set; }

    }
}
