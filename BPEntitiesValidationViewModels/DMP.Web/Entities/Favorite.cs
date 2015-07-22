using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DMP.Web.Entities
{
    public class Favorite
    {
        public int FavoriteId { get; set; }

        public int MemberId { get; set; }
        public DateTime DateFavorited { get; set; }
    }
}
