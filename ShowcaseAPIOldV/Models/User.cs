using System.Collections.Generic;

namespace ShowcaseAPIOldV.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Username { get; set; }


        public ICollection<Post> Posts { get; set; } = new HashSet<Post>();
    }
}
