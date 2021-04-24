namespace TicTacToeLib
{
    public class TicTacToe
    {
        private char[,] _gameArray = new char[3,3]
        {
            { '1', '2', '3' },
            { '4', '5', '6' },
            { '7', '8', '9' }
        };

        public char[,] GameArray
        {
            get { return _gameArray; }
        }

        public int PutSign(int column, int row, char sign)
        {
            if ((_gameArray[row - 1, column - 1] != 'X' && _gameArray[row - 1, column - 1] != 'O') &&
                (sign.Equals('X') | sign.Equals('O')))
            {
                _gameArray[row - 1, column - 1] = sign;
                return 0;
            }
            else
            {
                return -1;
            }
        }

        public string CheckWin()
        {
            string column1 = GameArray[0, 0].ToString() + GameArray[1, 0].ToString() + GameArray[2, 0].ToString();
            string column2 = GameArray[0, 1].ToString() + GameArray[1, 1].ToString() + GameArray[2, 1].ToString();
            string column3 = GameArray[0, 2].ToString() + GameArray[1, 2].ToString() + GameArray[2, 2].ToString();

            string row1 = GameArray[0, 0].ToString() + GameArray[0, 1].ToString() + GameArray[0, 2].ToString();
            string row2 = GameArray[1, 0].ToString() + GameArray[1, 1].ToString() + GameArray[1, 2].ToString();
            string row3 = GameArray[2, 0].ToString() + GameArray[2, 1].ToString() + GameArray[2, 2].ToString();

            string diagonal1 = GameArray[0, 0].ToString() + GameArray[1, 1].ToString() + GameArray[2, 2].ToString();
            string diagonal2 = GameArray[0, 2].ToString() + GameArray[1, 1].ToString() + GameArray[2, 0].ToString();

            if (column1.Equals("XXX") | column2.Equals("XXX") | column3.Equals("XXX") | row1.Equals("XXX") |
                row2.Equals("XXX") | row3.Equals("XXX") |
                diagonal1.Equals("XXX") | diagonal2.Equals("XXX"))
            {
                return "player x won";
            }
            else if (column1.Equals("OOO") | column2.Equals("OOO") | column3.Equals("OOO") | row1.Equals("OOO") |
                     row2.Equals("OOO") | row3.Equals("OOO") |
                     diagonal1.Equals("OOO") | diagonal2.Equals("OOO"))
            {
                return "player o won";
            }
            else
            {
                return "no one won";
            }
        }

        public void ResetGame()
        {
            _gameArray = new char[3,3]
            {
                { '1', '2', '3' },
                { '4', '5', '6' },
                { '7', '8', '9' }
            };
        }
    }
}