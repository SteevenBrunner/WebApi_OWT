using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi_OWT.Models
{
    public class Skills
    {


        public enum Levels
        {
            [Description("Beginner level")]
            Beginner = 0,
            [Description("Intermediate level")]
            Intermediate = 1,
            [Description("Advanced level")]
            Advanced = 2,
            [Description("Expert level")]
            Expert = 3
        }

        // primary key
        [Key]
        public int SkillsID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Level is required")]
        public Levels Level { get; set; }

        public int? ContactID { get; set; }
        [ForeignKey("ContactID")]
        public virtual ICollection<Contact> ContactsCollection { get; private set; }
    }
}