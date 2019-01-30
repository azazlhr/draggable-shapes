using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DraggableInteractiveDivs.Models
{
    public class ShapeModel
    {
        public string Id { get; set; }
        public int Left { get; set; }
        public int Top { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
    }
}