using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimurghEngine.API.Entities.CMS.PageBuilder
{
    public class TextEditorDto:BaseHtmlObjectDto
    {
        public int TextEditorId { get; set; }
        public string? Content { get; set; }

    }
}