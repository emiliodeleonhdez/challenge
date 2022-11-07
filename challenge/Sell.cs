using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge
{
    public class Sell
    {
        public int id { get; set; }
        public string comments { get; set; }
        public int userId { get; set; }

        public Sell(int id, string comments, int userId)
        {
            this.id = id;
            this.comments = comments;
            this.userId = userId;
        }

    }
}
