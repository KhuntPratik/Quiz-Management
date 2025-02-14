using System.ComponentModel.DataAnnotations;

namespace Quiz1.Models
{
    public class QuizWiseQuestionsModel
    {
        [Required]
        public string QuizWiseQuestionsID { get; set; }

        [Required]
        public string QuizID { get; set; }

        [Required]
        public int QuestionID { get; set; }

        [Required]
        public int UserID { get; set; }


        [Required]
        public DateTime Created { get; set; }

        [Required]
        public DateTime Modified { get; set; }
    }
}
