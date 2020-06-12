using System.ComponentModel.DataAnnotations;

namespace MyProjectCore.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}