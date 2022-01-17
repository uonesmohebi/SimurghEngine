using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SimurghEngine.API.Entities.CMS.PageBuilder
{
    public class PageFrame:BaseHtmlObject
    {
        [Key]
        public int PageFrameId { get; set; }



        public virtual AppUser AppUser { get; set; }

        public virtual List<RowBox> RowBoxes { get; set; }
    }
}