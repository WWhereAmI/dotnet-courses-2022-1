using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class UserViewModel
    {
        public int ID { get; set; }

        [Required(ErrorMessage ="*")]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "*")]
        [MaxLength(50)]
        public string LastName { get; set; }
            
        [Required(ErrorMessage ="*")]
        public DateTime BirthDate { get; set; }

        public List<Award> UserAwards { get; set; } = new List<Award>();

        public UserViewModel() { }

        public UserViewModel(User user)
        {
            ID = user.ID;
            FirstName = user.FirstName; 
            LastName = user.LastName;
            BirthDate = user.BirthDate;
            UserAwards = user.UserAwards;
        }
    }
}
