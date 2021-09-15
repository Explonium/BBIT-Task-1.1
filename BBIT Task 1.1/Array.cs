using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBIT_Task_1._1
{
    class Array
    {
        private int[,] _array;
        private int _columnSize;

        public Array(int min = 0, int max = 0)
        {
            // Defining a new array
            _array = new int[20,20];
            var rand = new Random();

            // Filling an array with random numbers
            for (int y = 0; y < 20; y++)
                for (int x = 0; x < 20; x++)
                    _array[y,x] = rand.Next(min, max);
                

            // Finding optimal column size
            _columnSize = Math.Max(min.ToString().Length, max.ToString().Length) + 1;
        }

        public Coords GetMinCoords()
        {
            int minNumber = _array[0,0];
            Coords minNumberCoords = new Coords();

            for (int y = 0; y < 20; y++)
                for (int x = 0; x < 20; x++)
                    if (_array[y, x] < minNumber)
                    {
                        minNumber = _array[y, x];
                        minNumberCoords.SetCoords(x, y);
                    }

            return minNumberCoords;
        }

        public Coords GetMaxCoords()
        {
            int minNumber = _array[0,0];
            Coords maxNumberCoords = new Coords();

            for (int y = 0; y < 20; y++)
                for (int x = 0; x < 20; x++)
                    if (_array[y, x] > minNumber)
                    {
                        minNumber = _array[y, x];
                        maxNumberCoords.SetCoords(x, y);
                    }

            return maxNumberCoords;
        }

        public int GetValue(Coords coords)
        {
            return _array[coords.y, coords.x];
        }

        public void Sort()
        {
            int size = 400;

            // using Bubble Sort
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size - 1; j++)
                {
                    if (_array[j / 20, j % 20] > _array[(j + 1)
                        / 20, (j + 1) % 20])
                    {
                        int temp = _array[j / 20, j % 20];
                        _array[j / 20, j % 20] = _array[(j + 1)
                            / 20, (j + 1) % 20];
                        _array[(j + 1) / 20, (j + 1) % 20] = temp;
                    }
                }
            }
        }

        public void Render(int xPos = 0, int yPos = 0)
        {
            Console.SetBufferSize(Math.Max(Console.BufferWidth, _columnSize * 20 + xPos), Console.BufferHeight);

            for (int y = 0; y < 20; y++)
            {
                for (int x = 0; x < 20; x++)
                {
                    var number = _array[y, x];
                    Console.SetCursorPosition(xPos + _columnSize * (x + 1) - number.ToString().Length, yPos + y);
                    Console.Write(number);
                }
            }
                
        }
    }
}
