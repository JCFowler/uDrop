using System;
using System.Collections.Generic;

namespace uDrop.Model
{
    public class Drop
    {
        public int id { get; set; }
        public string name { get; set; }
        public string time { get; set; }
        public string location { get; set; }

        public List<Drop> GetDrops()
        {
             var drops = new List<Drop>() {
                new Drop(){ id=1, name="John", time="12:00PM", location="Boston"},
                new Drop(){ id=2, name="Jake", time="1:00PM", location="Arizonia"},
                new Drop(){ id=3, name="Ai", time="7:00PM", location="Japan"}
            };
            return drops;
        }
    }
}
