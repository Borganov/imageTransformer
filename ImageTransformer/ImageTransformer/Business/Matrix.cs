
namespace ImageTransformer.Business
{
    public class Matrix
    {
        public static double[,] Prewitt3x3Horizontal
        {
            get
            {
                return new double[,]
                { { -1,  0,  1, },
                  { -1,  0,  1, },
                  { -1,  0,  1, }, };
            }
        }

        public static double[,] Prewitt3x3Vertical
        {
            get
            {
                return new double[,]
                { {  1,  1,  1, },
                  {  0,  0,  0, },
                  { -1, -1, -1, }, };
            }
        }


        public static double[,] Kirsch3x3Horizontal
        {
            get
            {
                return new double[,]
                { {  5,  5,  5, },
                  { -3,  0, -3, },
                  { -3, -3, -3, }, };
            }
        }

        public static double[,] Kirsch3x3Vertical
        {
            get
            {
                return new double[,]
                { {  5, -3, -3, },
                  {  5,  0, -3, },
                  {  5, -3, -3, }, };
            }
        }
    }
}
