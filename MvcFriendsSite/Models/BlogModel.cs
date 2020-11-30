using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcFriendsSite.Models
{
    public class BlogModel
    {
        public int Id { get; set; }
        public UserModel Author { get; set; }
        public string Name { get; set; }
        public string Headline { get; set; }

        public string Content { get; set; }

        public ICollection<UserModel> blogToUserFK { get; set; }


    }
}
