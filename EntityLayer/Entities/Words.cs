using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Words
    {
        public int WordId {get ;set;} 

        public string WordEng { get; set; }
        public string WordTur { get; set; }
        public int Level { get; set; }
        
        public bool IsActive { get; set; }
    }
}
