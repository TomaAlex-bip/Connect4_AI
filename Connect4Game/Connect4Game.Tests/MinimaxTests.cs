namespace Connect4Game.Tests
{
    public class MinimaxTests
    {


        [Fact]
        public void EvaluationFunction_EmptyTable_Returns0()
        {
            var table = new Table();

            var evalFuncRes = Minimax.EvaluationFunction(table);

            Assert.Equal(0, evalFuncRes);
        }

        [Fact]
        public void EvaluationFunction_ComputerAdvantage_ReturnsMoreThan0()
        {
            var table = new Table();
            table = table.MakeMove(0, PlayerType.Computer);
            table = table.MakeMove(0, PlayerType.Human);
            table = table.MakeMove(1, PlayerType.Computer);
            table = table.MakeMove(2, PlayerType.Human);

            var evalFuncRes = Minimax.EvaluationFunction(table);

            var advantage = evalFuncRes > 0;

            Assert.True(advantage);
        }

        [Fact]
        public void EvaluationFunction_HumanAdvantage_ReturnsLessThan0()
        {
            var table = new Table();
            table = table.MakeMove(0, PlayerType.Computer);
            table = table.MakeMove(0, PlayerType.Human);
            table = table.MakeMove(2, PlayerType.Computer);
            table = table.MakeMove(0, PlayerType.Human);

            var evalFuncRes = Minimax.EvaluationFunction(table);

            var advantage = evalFuncRes < 0;

            Assert.True(advantage);
        }

        [Fact]
        public void EvaluationFunction2_EmptyTable_Returns0()
        {
            var table = new Table();

            var evalFuncRes = Minimax.EvaluationFunction2(table);

            Assert.Equal(0, evalFuncRes);
        }

        [Fact]
        public void EvaluationFunction2_ComputerAdvantage_ReturnsMoreThan0()
        {
            var table = new Table();
            table = table.MakeMove(0, PlayerType.Computer);
            table = table.MakeMove(0, PlayerType.Human);
            table = table.MakeMove(1, PlayerType.Computer);
            table = table.MakeMove(2, PlayerType.Human);
            table = table.MakeMove(1, PlayerType.Computer);
            table = table.MakeMove(2, PlayerType.Human);
            table = table.MakeMove(2, PlayerType.Computer);
            table = table.MakeMove(3, PlayerType.Human);
            table = table.MakeMove(3, PlayerType.Computer);
            table = table.MakeMove(3, PlayerType.Human);
            table = table.MakeMove(3, PlayerType.Computer);
            table = table.MakeMove(1, PlayerType.Human);

            var evalFuncRes = Minimax.EvaluationFunction2(table);

            var advantage = evalFuncRes > 0;

            Assert.True(advantage);
        }

        [Fact]
        public void EvaluationFunction2_HumanAdvantage_ReturnsLessThan0()
        {
            var table = new Table();
            table = table.MakeMove(0, PlayerType.Human);
            table = table.MakeMove(1, PlayerType.Computer);
            table = table.MakeMove(0, PlayerType.Human);
            table = table.MakeMove(1, PlayerType.Computer);
            table = table.MakeMove(0, PlayerType.Human);
            table = table.MakeMove(1, PlayerType.Computer);
            table = table.MakeMove(1, PlayerType.Human);
            table = table.MakeMove(1, PlayerType.Computer);
            table = table.MakeMove(0, PlayerType.Human);
            table = table.MakeMove(2, PlayerType.Computer);
            table = table.MakeMove(3, PlayerType.Human);
            table = table.MakeMove(6, PlayerType.Computer);

            var evalFuncRes = Minimax.EvaluationFunction2(table);

            var advantage = evalFuncRes < 0;

            Assert.True(advantage);
        }
    }
}