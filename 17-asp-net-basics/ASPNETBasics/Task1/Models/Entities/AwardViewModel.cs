using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class AwardViewModel
    {
        
        public int ID { get; set; }

        [Required(ErrorMessage ="*")]
        [MaxLength(50)]
        public string Title { get; set; }

        [MaxLength(250)]
        public string Description { get; set; }

        public AwardViewModel() { }

        public AwardViewModel(Award award)
        {
            ID = award.ID;
            Title = award.Title;
            Description = award.Description;
        }

    }
}
