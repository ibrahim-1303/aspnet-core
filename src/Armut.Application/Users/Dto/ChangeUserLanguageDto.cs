using System.ComponentModel.DataAnnotations;

namespace Armut.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}