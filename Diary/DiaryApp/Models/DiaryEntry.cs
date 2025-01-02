using System.ComponentModel.DataAnnotations;

namespace DiaryApp.Models
{
    public class DiaryEntry
    {
        // [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "A Title for Diary Entry is Required")]
        [StringLength(100, MinimumLength =3, ErrorMessage ="Title must be between 3 and 100 characters!")]
        public string Title { get; set; } = string.Empty;
        [Required(ErrorMessage = "Content for Diary Entry is Required")]
        [StringLength(500, MinimumLength = 20, ErrorMessage = "Content must be between 20 and 500 characters!")]
        public string Content { get; set; } = string.Empty;
        [Required(ErrorMessage ="A date is needed to stamp the diary entry.")]
        public DateTime Created { get; set; } = DateTime.Now;
    }
}
