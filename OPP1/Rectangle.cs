using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OPP1
{
    class Rectangle
    {
        private int CoordinateA1 = 0;
        private int CoordinateA2 = 0;
        private int CoordinateB1 = 0;
        private int CoordinateB2 = 0;
        private int Point;
        public void RectangleOne(int A1,int A2)
        {
            if (A1 < 1001 && A2 < 1001 && 0 <= A1 && 0 <= A2)
            {
                if ((A2 - A1) <= 500)
                {
                    if (A2 < CoordinateB1 || A2 > CoordinateB2)
                    {
                        if (A1 < A2)
                        {
                            A1 = CoordinateA1;
                            A2 = CoordinateA2;
                        }
                        //if (A1 > A2)
                        //{
                        //    MessageBox.Show("Это уже не похоже на прямоугольник.", "Error");
                        //}
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
            else
            {
                MessageBox.Show("Значения не входят в обозначенную зону.", "Error");
            }
        }
        public void RectangleDouble(int B1, int B2)
        {
            if (B1 < 1001 && B2 < 1001 && 0 <= B1 && 0 <= B2)
            {
                if (B2-B1 <= 500)
                {

                    if (B2 < CoordinateA1 && B1 > CoordinateA2)
                    {
                        if (B1 < B2)
                        {
                            B1 = CoordinateA1;
                            B2 = CoordinateA2;
                        }
                        //if (B2 == B1)
                        //{
                        //    MessageBox.Show("Это уже не похоже на прямоугольник.", "Error");
                        //}
                        else
                        {
                            MessageBox.Show("Значение заполняющие координаты, должны заполнятся в правильном порядке. Начальная точка, затем конечная. В данном случае, вы ввели значение не правильно.", "Error");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Прямоугольник налегает на другой прямоугольник.");
                    }

                }
                else
                {
                    MessageBox.Show("Значение координаты не должно превышать 500 единиц.");
                }
            }
            else
            {
                MessageBox.Show("Значения не входят в обозначенную зону.", "Error");
            }
        }
        public void PrintA()
        {
            MessageBox.Show(CoordinateA1 + " " + CoordinateA2);
        }
        public void PrintB()
        {
            MessageBox.Show(CoordinateB1 + " " + CoordinateB2);
        }    
    }
}