using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace SeriesApp.Models
{
    public class Serie
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Summary { get; set; }
        //agregamos los siguientes atributos para que aparezca el selector de fecha en las vistas
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CreationDate { get; set; }
        public int Episodes { get; set; }
        public int Genre_ID { get; set; }
        public Genre Genre { get; set; }
        [ScriptIgnore]
        public ICollection<User> Favourites { get; set; }
    }
}