namespace SoftServeFirstTasks
{
    class WhiteCell : ICell
    {
        public override CellSymbol Symbol => CellSymbol.White;

        public override CellColor BackColor => CellColor.White;

        public override CellColor ForeColor => CellColor.Blue;

    }
}