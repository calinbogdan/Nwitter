using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nwitter.Models {

    public class Nweet {
        public int Id { get; set; }
        public string Text { get; set; }
        public User Author { get; set; }
        public DateTime NweetedAt { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public IEnumerable<Comment> Comments { get; set; }
    }
}
