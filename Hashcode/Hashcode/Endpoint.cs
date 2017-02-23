using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashcode
{
    class Endpoint
    {
        int latency;
        Dictionary<Cache, int> caches;//cache and latency

        public Endpoint(int lat, Dictionary<Cache, int> cache)
        {
            Latency = lat;
            Caches = cache;
        }

        public int Latency
        {
            get
            {
                return latency;
            }

            set
            {
                latency = value;
            }
        }

        internal Dictionary<Cache, int> Caches
        {
            get
            {
                return caches;
            }

            set
            {
                caches = value;
            }
        }

    }
}
