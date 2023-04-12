using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Data.Entities
{
    public class Post
    {
        public Post()
        {
            Comments = new HashSet<Comment>();
        }
        // Specifies that it is primary key 
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }

        public ICollection<Comment> Comments { get; set; }
       
    }
}
