﻿using System;
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
        Video[] videos;

        public Cache(int id, int capacity)
        {
            this.id = id;
            this.capacity = capacity;
        }

        int remainingCapacity()
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

        internal Video[] Videos
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

        
    }
}