using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimurghEngine.API.Entities.CMS.PageBuilder
{
    public class BaseHtmlObjectDto
    {
        public string TitleEn { get; set; }
        public string? TitleFa { get; set; }
        public int? Width { get; set; }
        public int? Height { get; set; }
        public string? VerticalAlign { get; set; }
        public string? HorizontalAlign { get; set; }
        public string? BackgroundColor { get; set; }
        public string? Margin { get; set; }
        public string? Padding { get; set; }
    }
}