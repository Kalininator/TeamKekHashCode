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
        int endpoints = 0;
        int request_des = 0;
        int cache = 0;
        int cache_size = 0;
        Video[] videos;
        string[] lines;

        public DataSet(String dataIn)
        {
            lines = System.IO.File.ReadAllLines("me_at_the_zoo.in");
            int i = 0;
            foreach (string s in split(lines[0], ' '))
            {
                switch (i)
                {
                    case 0:
                        vid_num = int.Parse(s);
                        break;
                    case 1:
                        endpoints = int.Parse(s);
                        break;
                    case 2:
                        request_des = int.Parse(s);
                        break;
                    case 3:
                        cache = int.Parse(s);
                        break;
                    case 4:
                        cache_size = int.Parse(s);
                        break;
                }
                i++;
            }
            //input videos
            int j = 0;
            foreach (string s in split(lines[1], ' '))
            {
                videos = new Video[vid_num];
                int video_size = int.Parse(s);
                videos[j] = new Video(j, video_size);
                j++;
            }
            for (int k = 0; k < endpoints; k++)
            {
                //start input endpoints
                Dictionary<Cache, int> caches;
                string[] end = split(lines[2], ' ');
                int data_lat = int.Parse(end[0]);
                int num_cache = int.Parse(end[1]);
            }
            //start input endpoints
            Console.WriteLine(vid_num + " " + endpoints + " " + request_des + " " + cache + " " + cache_size);
        }


        public static string[] split(String s, char c)
        {
            return s.Split(c);
        }
    }
}
