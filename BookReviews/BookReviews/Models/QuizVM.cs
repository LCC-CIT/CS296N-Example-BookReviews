using System;
using System.ComponentModel.DataAnnotations;

namespace BookReviews.Models
{
    public class QuizVM
    {
        // User's answers and results of checking the answers
        [Required(ErrorMessage = "You need to answer this question")]
        [StringLength(40, MinimumLength = 3, ErrorMessage = "You answer needs to be from 3 to 40 characters")]
        public String UserAnswer1 {get; set;}
        public String RightOrWrong1 { get; set; }

        [Required(ErrorMessage = "You need to answer this question")]
        public String UserAnswer2 { get; set; }
        public String RightOrWrong2 { get; set; }

        [Required(ErrorMessage = "You need to answer this question")]
        public String UserAnswer3 { get; set; }
        public String RightOrWrong3 { get; set; }

        // Checks each answer to see if it's right or wrong
        // Returns "Right" or "Wrong"
        public void CheckAnswers()
        {
            RightOrWrong1 = UserAnswer1 == "Victor Hugo" ? "Right" : "Wrong";
            RightOrWrong2 = UserAnswer2 == "1812" ? "Right" : "Wrong";
            RightOrWrong3 = UserAnswer3 == "false" ? "Right" : "Wrong";
        }
    }
}
