using System;
using System.Collections.Generic;
using uDrop.Model;

namespace uDrop.ViewModel
{
    public class DropViewModel
    {
        public List<Drop> drops { get; set; }

        public DropViewModel()
        {
            drops = new Drop().GetDrops();
        }
    }
}
