using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SimurghEngine.API.Entities.CMS.PageBuilder
{
    public class RowBox: BaseHtmlObject
    {
        [Key]
        public int RowBoxId { get; set; }


        public virtual Image Image { get; set; }
        public virtual PageFrame PageFrame { get; set; }


        public virtual List<ColBox> ColBoxes { get; set; }
    }
}