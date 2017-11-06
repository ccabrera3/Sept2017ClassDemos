using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chinook.Data.POCOs
{
   public class UserPlaylistTrack
    {
        public int TrackID { get; set; }
        public string Title { get; set; }
        public double TimeLength { get; set; }
        public decimal UnitPrice { get; set; }
        public int TrackNumber { get; set; }
    }
}
