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
        Dictionary<int, int> caches;//cacheID and latency
        Dictionary<int, int> requests;//videoID and NumRequests

        public Endpoint(int lat, Dictionary<int, int> cache)
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

        internal Dictionary<int, int> Caches
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

        public Dictionary<int, int> Requests
        {
            get
            {
                return requests;
            }

            set
            {
                requests = value;
            }
        }
    }
}
