using System.ComponentModel.DataAnnotations;

namespace BlazorWebApp8_CRUD.Entity
{
    public class Mammal
    {
        public int Id { get; set; }
        
        [Display(Name = "English Name"), StringLength(30)]
        public string EnglishName { get; set; }
        
        [Display(Name = "Latin Name"), StringLength(50)]
        
        public string Species { get; set; }
        
        public string Description { get; set; }
    }
}
