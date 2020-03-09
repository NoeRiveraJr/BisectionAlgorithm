using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyNumber
{
    class BisectionAlgorithm
    {
        public Tuple<Array,string> performBisection(int[] list, int number)
        {
            string msg;
            int check = 0;
            int halfSize = list.Length / 2;

            if (list[list.Length / 2-1 ] == number)
            {
                msg = ($"The value entered is {number}");
                check++;
                return new Tuple<Array, string>(list, msg);
            }
            else if(list[halfSize-1] > number)
            {
                if (list.Length % 2 == 0)
                {
                    int[] newList = new int[halfSize - 1];
                    for (int i = 0; i < halfSize-1; i++)
                    {
                        newList[i] = list[i];
                    }
                    msg = ($"The number you have entered is less than {list[halfSize - 1]}");
                    return new Tuple<Array, string>(newList, msg);
                }
                else
                {
                    int[] newList = new int[halfSize];
                    for (int i = 0; i < halfSize+1; i++)
                    {
                        newList[i] = list[i];
                    }
                    msg = ($"The number you have entered is less than {list[halfSize]}");
                    return new Tuple<Array, string>(newList, msg);
                }
            }
            else
            {
                if(list.Length%2==0)
                {
                    int[] newList2 = new int[list.Length - halfSize];
                    for(int i = 0; i < halfSize; i++)
                    {
                        newList2[i] = list[halfSize + i];
                    }
                    msg = ($"The number you have entered is greater than {list[halfSize-1]}");
                    return new Tuple<Array, string>(newList2, msg);
                }
                else
                {
                    int[] newList3 = new int[list.Length - halfSize];
                    for(int i =0; i < halfSize+1;i++)
                    {
                        newList3[i] = list[halfSize + i];
                    }
                    msg = ($"The number you have entered is greater than {list[halfSize]}");
                    return new Tuple<Array, string>(newList3, msg);
                }
            } 
        }
    }
}
