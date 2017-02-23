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
            requests = new Dictionary<int, int>();
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
        public void addRequest(int ID, int reqN)
        {
            if (requests.ContainsKey(ID))
            {
                requests[ID] = (reqN) + requests[ID];
            }
            else
            {
                requests.Add(ID, reqN);
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
