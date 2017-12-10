namespace HexGameFieldInit
{
    public partial class HexFields
    {
        private struct Point
        {
            public int x;
            public int y;

            public Point(int _x, int _y)
            {
                x = _x;
                y = _y;
            }

            public void Move(int direction)
            {
                // с четных по диагонали вверх, с нечетных по диагонали вниз
				if (x%2!=0)
				{ 
        	        switch (direction)
            	    {
                	    case 1:
	                        x = x + 0; y = y + 1; return;
    	                case 2:
        	                x = x + 1; y = y + 0; return;
            	        case 3:
                	        x = x + 1; y = y -1; return;
                    	case 4:
	                        x = x + 0; y = y - 1; return;
    	                case 5:
        	                x = x - 1; y = y - 1; return;
            	        case 6:
                	        x = x - 1; y = y + 0; return;
	                }
				}else{
					switch (direction)
					{
					case 1:
						x = x + 0; y = y + 1; return;
					case 2:
						x = x + 1; y = y + 1; return;
					case 3:
						x = x + 1; y = y + 0; return;
					case 4:
						x = x + 0; y = y - 1; return;
					case 5:
						x = x - 1; y = y + 0; return;
					case 6:
						x = x - 1; y = y + 1; return;
					}
				}
			}
            
            public void UnMove(int direction)
            {
				
                switch (direction)
                {
                    case 1:
                        Move(4); return;
                    case 2:
						Move(5); return;
                    case 3:
						Move(6); return;
                    case 4:
                        Move(1); return;
                    case 5:
                        Move(2); return;
                    case 6:
						Move(3); return;
                }
            }
        }
    }
}