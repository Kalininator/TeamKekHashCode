using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashcode
{
    class Program
    {
        static void Main(string[] args)
        {
            DataSet kittens = new DataSet("kittens.in");
            DataSet zoo = new DataSet("me_at_the_zoo.in");
            DataSet trend = new DataSet("trending_today.in");
            DataSet video = new DataSet("videos_worth_spreading.in");
            kittens.output("kit_out");
            zoo.output("zoo_out");
            trend.output("trend_out");
            video.output("video_out");
            Console.ReadLine();
        }
    }
}
