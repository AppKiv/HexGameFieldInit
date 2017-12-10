using System;

namespace HexGameFieldInit
{
    public partial class HexFields
    {
        private const byte  DIRECT_COUNT = 6;
        private const byte FIELD_WIDTH = 7;
        private const byte FIELD_HEIGHT = 8;
        private const char EMPTY_CHAR = '.';
        private const int MAX_WORD_LENGTH = 12;
        private char[,] matrix; /* char[FIELD_HEIGHT,FIELD_WIDTH] */
        public int FieldNumber{get; set;}
        public char[,] GameField { get{ return matrix;}}
        private bool IsEmptyPlace(Point p) { return matrix[p.y, p.x] == EMPTY_CHAR; }
        private void SetPlace(Point p, char value) { matrix[p.y, p.x] = value;}
        private void SetEmpty(Point p) { matrix[p.y, p.x] = EMPTY_CHAR;}
        public HexFields(string word, string alphabet)
        {
            if ((word.Length >MAX_WORD_LENGTH)||(word.Length<1)){
                throw new System.ArgumentException("Parameter Word cannot be more than "+MAX_WORD_LENGTH.ToString()+" symbols.", word);
            }
            FieldNumber = GetRandomFieldNumber(word.Length);
            InitGameField(FieldNumber);
            Fill(word);
            FillEmptyPlace(alphabet);
        }
        private byte[] FillDirection()
        {
            byte[] d = new byte[DIRECT_COUNT] { 1, 2, 3, 4, 5, 6 };
            var rng = new Random();
            for (int i = 0; i<10; i++){
                var i1 = rng.Next(0, DIRECT_COUNT);
                var i2 = rng.Next(0, DIRECT_COUNT);
                var buf = d[i1];
                d[i1] = d[i2];
                d[i2] = buf;
            }
            return d;
        }

        private void Fill(string word)
        {
            var wordLen = word.Length;

            var rng = new Random();
            byte[][] AllDirection = new byte[wordLen][];    // все возможнвые направления-переходы по каждой букве
            byte[] direction = new byte[wordLen];           // текущая позиция в массиве направлений
            for (int i = 0; i < wordLen; i++)
                AllDirection[i] = FillDirection();

            Point testPoint  = new Point(0, 0);
            Point startPoint = new Point(0, 0);
            Point currPoint  = new Point(0, 0);
            byte currCh = 0;

            while (currCh < wordLen)
            {
                // search start position
                // todo: массив возможных начал для матрицы и из них по брать по порядку
                if (currCh == 0)
                {
                    startPoint = new Point(rng.Next(2, FIELD_WIDTH), rng.Next(2, FIELD_HEIGHT));
                    while (!IsEmptyPlace(startPoint))
                        startPoint = new Point(rng.Next(2, FIELD_WIDTH), rng.Next(2, FIELD_HEIGHT));
                    currPoint = startPoint; // struct
                    SetPlace(startPoint, word[currCh]);
                    currCh++;
                }
                
                // из каждой точки есть шесть направлений, выбираем произвольное в которое ещё не ходили
                //Console.WriteLine("x={0} y={1}", currPoint.x, currPoint.y);
                byte d = direction[currCh];
                while(d<DIRECT_COUNT) {
                    /* массив перестановки от [1, DIRECT_COUNT] - возможные варианты движения из точки, перебираем по порядку */
                    testPoint = currPoint;
                    testPoint.Move(AllDirection[currCh][d]);
                    if (IsEmptyPlace(testPoint))
                        break;
                    d++;
                }
                if ((d<DIRECT_COUNT)&&(IsEmptyPlace(testPoint)))
                {
                    currPoint = testPoint;
                    //Console.WriteLine("x={0} y={1}", currPoint.x, currPoint.y);
                    SetPlace(currPoint, word[currCh]);
                    direction[currCh] = d;
                    currCh++;
                }
                else
                {   // делаем шаг назад
                    SetEmpty(currPoint);
                    direction[currCh] = 0;
                    currCh--;
                    currPoint.UnMove(AllDirection[currCh][direction[currCh]]);
                    direction[currCh]++;
                    //Console.WriteLine("back to x={0} y={1}", currPoint.x, currPoint.y);
                }
            }
        }

        private void FillEmptyPlace(string alphabet){
            var rng = new Random();
            for(int i = 1; i < FIELD_HEIGHT; i++)
            {
                for (int j = 0; j < FIELD_WIDTH; j++){
                    var point = new Point(j,i);
                    if (IsEmptyPlace(point)) 
                        SetPlace(point, alphabet[rng.Next(1,alphabet.Length)]);
                }
            }
        }
        public void Print(){
            for(int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 7; j++)
                    Console.Write(GameField[i, j]);
                Console.WriteLine();
            }
        }
    }
}
