using System.ComponentModel.DataAnnotations;

namespace Quiz1.Models
{
    public class AddQuestionLevelModel
    {

        [Required]
        public string QuestionLevelID { get; set; }

        [Required]
        public string QuestionLevel { get; set; }

        [Required]
        public int UserID { get; set; }

        [Required]
        public DateTime Created { get; set; }

        [Required]
        public DateTime Modified { get; set; }


        
        }
}
