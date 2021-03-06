using System;

namespace HexGameFieldInit
{
    public partial class HexFields
    {
        private const int MAX_FIELD_COUNT = 13;
        private int GetRandomFieldNumber(int wordLen){
            var rng = new Random();
            if (wordLen>5)
                return rng.Next(5, MAX_FIELD_COUNT+1);
            else
                return rng.Next(1, MAX_FIELD_COUNT+1);
        }
        private void  InitGameField(int fieldNumber){
            switch (fieldNumber)
            {   // четные (2,4,6) поднимаются на полшага вверх
                case 1:
                    matrix = new char[FIELD_HEIGHT,FIELD_WIDTH]
                    {   /*   1   2   3   4   5   6   7   */
                          { '*','*','*','*','*','*','*' } /*1*/
	                     ,{ '*','*','*','*','*','*','*' } /*2*/
	                     ,{ '*','*','*','*','*','*','*' } /*3*/
	                     ,{ '*','*','.','.','.','*','*' } /*4*/
	                     ,{ '*','*','.','.','.','*','*' } /*5*/
	                     ,{ '*','*','*','.','*','*','*' } /*6*/
	                     ,{ '*','*','*','*','*','*','*' } /*7*/
	                     ,{ '*','*','*','*','*','*','*' } /*8*/
                    };
                    break;
                case 2:
                    matrix = new char[FIELD_HEIGHT,FIELD_WIDTH]
                    {   /*   1   2   3   4   5   6   7   */
                          { '*','*','*','*','*','*','*' } /*1*/
	                     ,{ '*','*','*','*','*','*','*' } /*2*/
	                     ,{ '*','*','.','.','.','*','*' } /*3*/
	                     ,{ '*','.','.','.','.','.','*' } /*4*/
	                     ,{ '*','.','.','.','.','.','*' } /*5*/
	                     ,{ '*','*','*','.','*','*','*' } /*6*/
	                     ,{ '*','*','*','*','*','*','*' } /*7*/
	                     ,{ '*','*','*','*','*','*','*' } /*8*/
                    };
                    break;
                case 3:
                    matrix = new char[FIELD_HEIGHT,FIELD_WIDTH]
                    {   /*   1   2   3   4   5   6   7   */
                          { '*','*','*','*','*','*','*' } /*1*/
	                     ,{ '*','*','*','*','*','*','*' } /*2*/
	                     ,{ '*','*','*','*','*','*','*' } /*3*/
	                     ,{ '*','*','.','.','.','*','*' } /*4*/
	                     ,{ '*','.','.','.','.','.','*' } /*5*/
	                     ,{ '*','*','*','.','*','*','*' } /*6*/
	                     ,{ '*','*','*','*','*','*','*' } /*7*/
	                     ,{ '*','*','*','*','*','*','*' } /*8*/
                    };
                    break;
                case 4:
                    matrix = new char[FIELD_HEIGHT,FIELD_WIDTH]
                    {   /*   1   2   3   4   5   6   7   */
                          { '*','*','*','*','*','*','*' } /*1*/
	                     ,{ '*','*','*','*','*','*','*' } /*2*/
	                     ,{ '*','*','.','*','.','*','*' } /*3*/
	                     ,{ '*','.','.','.','.','.','*' } /*4*/
	                     ,{ '*','.','.','.','.','.','*' } /*5*/
	                     ,{ '*','*','*','*','*','*','*' } /*6*/
	                     ,{ '*','*','*','*','*','*','*' } /*7*/
	                     ,{ '*','*','*','*','*','*','*' } /*8*/
                    };
                    break;
                case 5:
                    matrix = new char[FIELD_HEIGHT,FIELD_WIDTH]
                    {   /*   1   2   3   4   5   6   7   */
                          { '*','*','*','*','*','*','*' } /*1*/
	                     ,{ '*','*','*','*','*','*','*' } /*2*/
	                     ,{ '*','*','.','.','.','*','*' } /*3*/
	                     ,{ '*','.','.','.','.','.','*' } /*4*/
	                     ,{ '*','.','.','.','.','.','*' } /*5*/
	                     ,{ '*','.','.','.','.','.','*' } /*6*/
	                     ,{ '*','*','*','.','*','*','*' } /*7*/
	                     ,{ '*','*','*','*','*','*','*' } /*8*/
                    };
                    break;
                case 6:
                    matrix = new char[FIELD_HEIGHT,FIELD_WIDTH]
                    {   /*   1   2   3   4   5   6   7   */
                          { '*','*','*','*','*','*','*' } /*1*/
	                     ,{ '*','*','*','*','*','*','*' } /*2*/
	                     ,{ '*','*','.','.','.','*','*' } /*3*/
	                     ,{ '*','.','.','.','.','.','*' } /*4*/
	                     ,{ '*','.','.','.','.','.','*' } /*5*/
	                     ,{ '*','.','.','.','.','.','*' } /*6*/
	                     ,{ '*','.','*','*','*','.','*' } /*7*/
	                     ,{ '*','*','*','*','*','*','*' } /*8*/
                    };
                    break;
                case 7:
                    matrix = new char[FIELD_HEIGHT,FIELD_WIDTH]
                    {   /*   1   2   3   4   5   6   7   */
                          { '*','*','*','*','*','*','*' } /*1*/
	                     ,{ '*','*','.','*','*','*','*' } /*2*/
	                     ,{ '*','.','.','.','.','*','*' } /*3*/
	                     ,{ '*','.','.','.','.','.','*' } /*4*/
	                     ,{ '*','.','.','.','.','.','*' } /*5*/
	                     ,{ '*','*','*','.','.','.','*' } /*6*/
	                     ,{ '*','*','*','*','*','*','*' } /*7*/
	                     ,{ '*','*','*','*','*','*','*' } /*8*/
                    };
                    break;
                case 8:
                    matrix = new char[FIELD_HEIGHT,FIELD_WIDTH]
                    {   /*   1   2   3   4   5   6   7   */
                          { '*','*','*','*','*','*','*' } /*1*/
	                     ,{ '*','*','.','.','.','*','*' } /*2*/
	                     ,{ '*','.','.','.','.','.','*' } /*3*/
	                     ,{ '*','*','.','.','.','*','*' } /*4*/
	                     ,{ '*','*','.','.','.','*','*' } /*5*/
	                     ,{ '*','.','.','.','.','.','*' } /*6*/
	                     ,{ '*','*','*','.','*','*','*' } /*7*/
	                     ,{ '*','*','*','*','*','*','*' } /*8*/
                    };
                    break;
                case 9:
                    matrix = new char[FIELD_HEIGHT,FIELD_WIDTH]
                    {   /*   1   2   3   4   5   6   7   */
                          { '*','*','*','*','*','*','*' } /*1*/
	                     ,{ '*','*','.','*','.','*','*' } /*2*/
	                     ,{ '*','.','.','*','.','.','*' } /*3*/
	                     ,{ '*','.','.','.','.','.','*' } /*4*/
	                     ,{ '*','.','.','*','.','.','*' } /*5*/
	                     ,{ '*','.','.','*','.','.','*' } /*6*/
	                     ,{ '*','*','*','.','*','*','*' } /*7*/
	                     ,{ '*','*','*','*','*','*','*' } /*8*/
                    };
                    break;
                case 10:
                    matrix = new char[FIELD_HEIGHT,FIELD_WIDTH]
                    {   /*   1   2   3   4   5   6   7   */
                          { '*','*','*','*','*','*','*' } /*1*/
	                     ,{ '*','*','*','*','*','*','*' } /*2*/
	                     ,{ '*','*','.','.','.','*','*' } /*3*/
	                     ,{ '*','.','.','.','.','.','*' } /*4*/
	                     ,{ '*','.','.','*','.','.','*' } /*5*/
	                     ,{ '*','.','.','.','.','.','*' } /*6*/
	                     ,{ '*','*','*','.','*','*','*' } /*7*/
	                     ,{ '*','*','*','*','*','*','*' } /*8*/
                    };
                    break;
                case 11:
                    matrix = new char[FIELD_HEIGHT,FIELD_WIDTH]
                    {   /*   1   2   3   4   5   6   7   */
                          { '*','*','*','*','*','*','*' } /*1*/
	                     ,{ '*','*','*','*','*','*','*' } /*2*/
	                     ,{ '*','.','.','*','.','.','*' } /*3*/
	                     ,{ '*','.','.','.','.','.','*' } /*4*/
	                     ,{ '*','.','.','.','.','.','*' } /*5*/
	                     ,{ '*','.','.','.','.','.','*' } /*6*/
	                     ,{ '*','*','*','.','*','*','*' } /*7*/
	                     ,{ '*','*','*','*','*','*','*' } /*8*/
                    };
                    break;
                case 12:
                    matrix = new char[FIELD_HEIGHT,FIELD_WIDTH]
                    {   /*   1   2   3   4   5   6   7   */
                          { '*','*','*','*','*','*','*' } /*1*/
	                     ,{ '*','*','.','.','.','*','*' } /*2*/
	                     ,{ '*','.','.','.','.','.','*' } /*3*/
	                     ,{ '*','.','.','.','.','.','*' } /*4*/
	                     ,{ '*','.','.','.','.','.','*' } /*5*/
	                     ,{ '*','.','.','.','.','.','*' } /*6*/
	                     ,{ '*','*','*','.','*','*','*' } /*7*/
	                     ,{ '*','*','*','*','*','*','*' } /*8*/
                    };
                    break;
                case 13:
                    matrix = new char[FIELD_HEIGHT,FIELD_WIDTH]
                    {   /*   1   2   3   4   5   6   7   */
                          { '*','*','*','*','*','*','*' } /*1*/
	                     ,{ '*','*','*','*','*','*','*' } /*2*/
	                     ,{ '*','*','.','*','.','*','*' } /*3*/
	                     ,{ '*','.','.','.','.','.','*' } /*4*/
	                     ,{ '*','.','.','.','.','.','*' } /*5*/
	                     ,{ '*','.','.','.','.','.','*' } /*6*/
	                     ,{ '*','.','*','*','*','.','*' } /*7*/
	                     ,{ '*','*','*','*','*','*','*' } /*8*/
                    };
                    break;
                default:
                    matrix = new char[FIELD_HEIGHT,FIELD_WIDTH]
                    {   /*   1   2   3   4   5   6   7   */
                          { '*','*','*','*','*','*','*' } /*1*/
	                     ,{ '*','.','.','.','.','.','*' } /*2*/
	                     ,{ '*','.','.','.','.','.','*' } /*3*/
	                     ,{ '*','.','.','.','.','.','*' } /*4*/
	                     ,{ '*','.','.','.','.','.','*' } /*5*/
	                     ,{ '*','.','.','.','.','.','*' } /*6*/
	                     ,{ '*','.','.','.','.','.','*' } /*7*/
	                     ,{ '*','*','*','*','*','*','*' } /*8*/
                    };
                    break;
            }
        }
    }
}
