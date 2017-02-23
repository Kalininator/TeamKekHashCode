using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashcode
{
    class DataSet
    {
        int videos = 0;
        int endpoints = 0;
        int request_des = 0;
        int cache = 0;
        int cache_size = 0;

        public DataSet(String dataIn)
        {
            System.IO.StreamReader file = new System.IO.StreamReader("me_at_the_zoo.in");
            int counter = 0;
            string line;
            while ((line = file.ReadLine()) != null)
            {
                if (counter == 0)
                {
                    int i = 0;
                    foreach (string s in split(line, ' '))
                    {
                        switch (i)
                        {
                            case 0:
                                videos = int.Parse(s);
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
                }
                counter++;
            }
            Console.WriteLine(videos + " " + endpoints + " " + request_des + " " + cache + " " + cache_size);
        }

        public static string[] split(String s, char c)
        {
            return s.Split(c);
        }
    }
}
