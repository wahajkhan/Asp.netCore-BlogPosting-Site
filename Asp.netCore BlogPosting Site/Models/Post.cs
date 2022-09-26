using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.netCore_BlogPosting_Site.Models
{
    [MetadataType(typeof(Post))]
    public  class Post : Abs_Post
    {

        public int ID { get; set; }
    }
    public abstract class Abs_Post
    {
        [Display(Name = "Blog title", Description = "Blog Title is help user to check that blog")]
        [Required]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "Minimun 10 Charater and max 100 required for blog Title")]
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime Posted { get; set; }
        [Display(Name = "Blog Body", Description = "Blog Body is help user to check that blog")]
        [Required]
        [MinLength(200, ErrorMessage = "Minimun 200 Charater required for blog Title")]
        [DataType(DataType.MultilineText)]
        public string Body { get; set; }
    }
}
