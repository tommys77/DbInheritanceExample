using System.Collections.Generic;

namespace ModelsEF
{
    public class Owner
    {

        public int OwnerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public ICollection<Item> Items { get; set; }
    }
}