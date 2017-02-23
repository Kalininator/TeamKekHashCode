using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashcode
{
    class Cache
    {
        int id;
        int capacity;
        List<Video> videos;

        public Cache(int id, int capacity)
        {
            this.id = id;
            this.capacity = capacity;
            videos = new List<Video>();
        }

        public int remainingCapacity()
        {
            int remaining = Capacity;
            foreach (Video vid in Videos)
            {
                remaining -= vid.Size;
            }
            return remaining;
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public int Capacity
        {
            get
            {
                return capacity;
            }

            set
            {
                capacity = value;
            }
        }

        public List<Video> Videos
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

        public void addVideo(Video v)
        {
            videos.Add(v);
        }
        

        
    }
}
