using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SimurghEngine.API.Entities.CMS.PageBuilder
{
    public class RowBoxDto: BaseHtmlObjectDto
    {
        public int RowBoxId { get; set; }


        public Image Image { get; set; }//Background image
        public PageFrame PageFrame { get; set; } //Father pageFrame


        public List<ColBoxDto> ColBoxes { get; set; }
    }
}