﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StatlerWaldorfCorp.TeamService.Models
{
    public class Team
    {
        public string Name { get; set; }
        public Guid ID { get; set; }
        public ICollection<Member> Members { get; set; }

        public Team()
        {
            Members = new List<Member>();
        }
        public Team(string name)
        {
            Name = name;
        }

        public Team(string name,Guid id):this(name)
        {
            ID = id;
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
