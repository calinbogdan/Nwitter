using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nwitter.Models {
    public class User {
        public int Id { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BornAt { get; set; }
        public DateTime JoinedAt { get; set; }
        public string PasswordHash { get; set; }
        public string EmailAddress { get; set; }

        public IEnumerable<Nweet> Nweets { get; set; }
    }
}
