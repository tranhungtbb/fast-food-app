using System.ComponentModel.DataAnnotations;

namespace FastFootApp.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}