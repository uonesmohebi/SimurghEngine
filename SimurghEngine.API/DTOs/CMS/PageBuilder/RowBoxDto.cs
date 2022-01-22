using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SimurghEngine.API.Entities.CMS.PageBuilder
{
    public class RowBoxDto: BaseHtmlObjectDto
    {
        [Key]
        public int RowBoxId { get; set; }


        public virtual Image Image { get; set; }
        public virtual PageFrame PageFrame { get; set; }


        public virtual List<ColBoxDto> ColBoxes { get; set; }
    }
}