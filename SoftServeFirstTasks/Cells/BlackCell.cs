using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftServeFirstTasks
{
    class BlackCell : ICell
    {
        public override CellSymbol Symbol => CellSymbol.Black;
        public override CellColor BackColor => CellColor.Blue;
        public override CellColor ForeColor => CellColor.White;
    }
}
