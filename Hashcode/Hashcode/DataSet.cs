using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashcode
{
    class DataSet
    {
        int vid_num = 0;
        int endpoint_num = 0;
        int request_des = 0;
        int cache = 0;
        int cache_size = 0;
        Cache[] caches;
        Video[] videos;
        Endpoint[] endPoints;
        string[] lines;

        public int Vid_num
        {
            get
            {
                return vid_num;
            }

            set
            {
                vid_num = value;
            }
        }

        public int Request_des
        {
            get
            {
                return request_des;
            }

            set
            {
                request_des = value;
            }
        }

        public int Cache
        {
            get
            {
                return cache;
            }

            set
            {
                cache = value;
            }
        }

        public int Cache_size
        {
            get
            {
                return cache_size;
            }

            set
            {
                cache_size = value;
            }
        }

        public Video[] Videos
        {
            get
            {
                return videos;
            }

            set
            {
                videos = value;
            }
        }

        public int Endpoint_num
        {
            get
            {
                return endpoint_num;
            }

            set
            {
                endpoint_num = value;
            }
        }

        public Endpoint[] EndPoints
        {
            get
            {
                return endPoints;
            }

            set
            {
                endPoints = value;
            }
        }

        public Cache[] Caches
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

        public DataSet(String dataIn)
        {
            lines = System.IO.File.ReadAllLines("me_at_the_zoo.in");
            int i = 0;
            int lineNum = 2;
            foreach (string s in split(lines[0], ' '))
            {
                switch (i)
                {
                    case 0:
                        Vid_num = int.Parse(s);
                        break;
                    case 1:
                        endpoint_num = int.Parse(s);
                        break;
                    case 2:
                        Request_des = int.Parse(s);
                        break;
                    case 3:
                        Cache = int.Parse(s);
                        break;
                    case 4:
                        Cache_size = int.Parse(s);
                        break;
                }
                i++;
            }
            //create caches
            caches = new Cache[Cache];
            for (int cacss = 0; cacss < Cache; cacss++)
            {
                caches[cacss] = new Cache(cacss, Cache_size);
                Console.WriteLine(cacss + " " + cache_size); 
            }
            //input videos
            int j = 0;
            foreach (string s in split(lines[1], ' '))
            {
                Videos = new Video[Vid_num];
                int video_size = int.Parse(s);
                Videos[j] = new Video(j, video_size);
                j++;
            }
            //for (int k = 0; k < endpoint_num; k++)
            //{
            //    string[] end = split(lines[lineNum], ' '); // get endpoint
            //    int data_lat = int.Parse(end[0]);
            //    int num_cache = int.Parse(end[1]);
            //    lineNum++;
            //    for (int l = 0; l < num_cache; l++)
            //    {
            //        string[] cac = split(lines[lineNum], ' '); // get endpoint
            //        int cacheID = int.Parse(cac[0]);
            //        int cacheLate = int.Parse(cac[1]);
            //        new Cache(cacheID,);
            //        lineNum++;
            //    }
            //}
            //start input endpoints
            Console.WriteLine(Vid_num + " " + endpoint_num + " " + Request_des + " " + Cache + " " + Cache_size);
        }


        public static string[] split(String s, char c)
        {
            return s.Split(c);
        }
    }
}
