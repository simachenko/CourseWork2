using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Spectacle
    {
        public int SpectacleId { set; get; }
        public string name { set; get; }
        public string author { set; get; }
        public string genre { set; get; }
        public string date { set; get; }
        public int freePlaces { set; get; }
        public int allPlaces { set; get; }

        public virtual ICollection<Ticket> ticket { set; get; }
    }
}
