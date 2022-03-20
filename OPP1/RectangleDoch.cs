using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OPP1
{
    class RectangleDoch : Rectangle
    {
        private int CoordinateC1 = 0;
        private int CoordinateC2 = 0;
        public void RectangleThird(int C1, int C2)
        {
            if (C1 < 1001 && C2 < 1001 && 0 <= C1 && 0 <= C2)
            {
                if (C2-C1 <= 500)
                {
                    if (C2 < CoordinateC1 || C2 > CoordinateC2)
                    {
                        if (C1 < C2)
                        {
                            C1 = CoordinateC1;
                            C2 = CoordinateC2;
                        }
                        else
                        {
                            MessageBox.Show("Значение заполняющие координаты, должны заполнятся в правильном порядке. Начальная точка, затем конечная. В данном случае, вы ввели значение не правильно.", "Error");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Прямоугольник налегает на другой прямоугольник.", "Error");
                    }
                }
                else
                {
                    MessageBox.Show("Значение координаты не должно превышать 500 единиц.", "Error");
                }
            }
        }
    }
}
