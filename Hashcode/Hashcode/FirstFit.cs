using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashcode
{
    class FirstFit
    {
        public void Run(DataSet set)
        {
            foreach(Endpoint endpoint in set.EndPoints)
            {
                //Console.WriteLine("endpoint " + endpoint.Latency);
                int[] caches = endpoint.Caches.Keys.ToArray();//cache ids
                Array.Sort(caches, delegate (int x, int y)
                {
                    return endpoint.Caches[x].CompareTo(endpoint.Caches[y]);
                });
                //foreach(int c in caches)
                //{
                //    Console.WriteLine(c + " " + endpoint.Caches[c]);
                //}
                //Console.WriteLine("endpoint " + endpoint.Latency);
                int[] videos = endpoint.Requests.Keys.ToArray();
                Array.Sort(videos, delegate (int x, int y)
                {
                    return -endpoint.Requests[x].CompareTo(endpoint.Requests[y]);
                });
                //foreach (int v in videos)
                //{
                //    Console.WriteLine(v + " " + endpoint.Requests[v]);
                //}
                foreach (int v in videos)
                {
                    //Console.WriteLine(v);
                    Video vid = set.Videos[v];
                    foreach(int c in caches)
                    {
                        Cache cache = set.Caches[c];
                        if (cache.Videos.Contains(vid))
                        {
                            break;
                        }
                        else if(cache.remainingCapacity() >= vid.Size)
                        {
                            cache.addVideo(vid);
                            break;
                        }
                    }
                }
            }

        }
    }
}
