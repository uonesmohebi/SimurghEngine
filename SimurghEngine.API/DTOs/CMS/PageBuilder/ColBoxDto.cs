using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SimurghEngine.API.Entities.CMS.PageBuilder
{
    public class ColBoxDto: BaseHtmlObjectDto
    {
        [Key]
        public int ColBoxId { get; set; }


        public virtual Image Image { get; set; }
        public virtual RowBox RowBox { get; set; }
        

        public virtual List<TextEditor> TextEditors { get; set; }
    }
}