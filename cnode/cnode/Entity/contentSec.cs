using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnode.Entity
{
    public class contentSec
    {
        public string id { get; set; }

        public string author_id { get; set; }

        public string tab { get; set; }

        public string content { get; set; }

        public string title { get; set; }
        public string last_reply_at { get; set; }

        public bool good { get; set; }

        public bool top { get; set;}
        public int reply_count { get; set; }
        public int visit_count { get; set; }
        public string create_at { get; set; }

        public author author { get; set; }

        public List<reply> replies { get; set; }

    }
}
