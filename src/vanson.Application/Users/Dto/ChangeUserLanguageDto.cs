using System.ComponentModel.DataAnnotations;

namespace vanson.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}