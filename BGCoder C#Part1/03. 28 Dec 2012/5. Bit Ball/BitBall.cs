using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Bit_Ball
{
    class BitBall
    {
        static void Main(string[] args)
        {
            string[] inputLine = new string[16];
            for (int i = 0; i < 16; i++)
            {
                inputLine[i] = Console.ReadLine();
            }

            string[] rowAfterCheckTop = new string[8];
            string[] rowAfterCheckBottom = new string[8];
            for (int i = 0; i < inputLine.Length / 2; i++)
            {
                int topTeam = int.Parse(inputLine[i]);
                int bottomTeam = int.Parse(inputLine[8 + i]);

                char[] rowTopTeam = Convert.ToString(topTeam, 2).PadLeft(8, '0').ToCharArray();
                char[] rowBottomTeam = Convert.ToString(bottomTeam, 2).PadLeft(8, '0').ToCharArray();
                

                for (int j = 0; j <rowTopTeam.Length; j++)
                {
                    if (rowTopTeam[j] == rowBottomTeam[j])
                    {
                        rowTopTeam[j] = '0';
                        rowBottomTeam[j] = '0';
                    }
                }
                
                rowAfterCheckTop[i] = new string(rowTopTeam);
                rowAfterCheckBottom[i] = new string(rowBottomTeam);
            }

            int goalsTop = 0;
            int goalsBottom = 0;

            Console.WriteLine(string.Join(",", rowAfterCheckTop));
            Console.WriteLine(string.Join(",", rowAfterCheckBottom));

            for (int row = 0; row < rowAfterCheckTop.Length; row++)
            {
                for (int col = 0; col < rowAfterCheckTop[row].Length; col++)
                {
                    if (rowAfterCheckTop[row][col] == '1')
                    {
                        for (int rowBottom = row + 1; rowBottom < rowAfterCheckBottom[col].Length; rowBottom++)
                        {
                            if (rowAfterCheckBottom[rowBottom][col] == '0')
                            {
                                if (rowBottom == (rowAfterCheckBottom[col].Length - 1))
                                {
                                    goalsTop++;
                                }
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                }
            }

            for (int row = rowAfterCheckBottom.Length-1; row >= 0; row--)
            {
                for (int col = 0; col < rowAfterCheckBottom[row].Length; col++)
                {
                    if (rowAfterCheckBottom[row][col] == '1')
                    {
                        for (int rowTop = row - 1; rowTop >= 0; rowTop--)
                        {
                            if (rowAfterCheckTop[rowTop][col] == '0')
                            {
                                if (rowTop == 0)
                                {
                                    goalsBottom++;
                                }
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                }
            }

            Console.WriteLine("{0}:{1}", goalsTop, goalsBottom);

        }
    }
}
