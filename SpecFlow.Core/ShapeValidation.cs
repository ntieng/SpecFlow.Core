using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlow.Core
{
    public class ShapeValidation : IShapeValidation
    {
        private readonly IDictionary<Shapes, bool> _shapes;

        public ShapeValidation()
        {
            _shapes = new Dictionary<Shapes, bool> {
                {Shapes.Square, false},
                {Shapes.Round, false},
                {Shapes.Rectangle, false},
                {Shapes.RightTriangle, true},
                {Shapes.EquilateralTriangle, true},
                {Shapes.IsocelesTriangle, true},
                {Shapes.AcuteTriangle, true},
            };
        }

        public bool IsATriangle(Shapes shapes)
        {
            return _shapes[shapes];
        }
    }
}
