using System;
using System.Collections.Generic;

namespace SQL_Test
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Year { get; set; } // может принимать значение NULL, int не обязательный параметр
        public virtual ICollection<Song> Songs { get; set; } // у каждой группы будут храниться все ее песни

        }
    }
}
