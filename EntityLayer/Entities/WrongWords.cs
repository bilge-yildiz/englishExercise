using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
       public class WrongWords
    {
        public int WrongWordsId { get; set; }

        public int WordId { get; set; }

        public int UserId { get; set; }
        public int Count { get; set; }
       

    }

}
