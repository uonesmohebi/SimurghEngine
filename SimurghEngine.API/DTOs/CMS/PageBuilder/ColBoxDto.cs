using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SimurghEngine.API.Entities.CMS.PageBuilder
{
    public class ColBoxDto: BaseHtmlObjectDto
    {
        public int ColBoxId { get; set; }


        public Image Image { get; set; }  //Background image
        public RowBox RowBox { get; set; } //Father rowBox
        

        public List<TextEditor> TextEditors { get; set; }
    }
}