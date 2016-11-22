using System;

namespace _03_Sequence_In_Matrix
{
    class SequenceInMatrix
    {
        static void Main()
        {
            // 100 / 100, TODO: MISSING CHECK FOR Diagonals - Left-  BOTTOM RIGTH section

            // input size Col and Row on a single input line
            string sizeInput = Console.ReadLine();

            string[] sizes = sizeInput
                            .Trim(' ')
                            .Split(' ');

            int inputRows = int.Parse(sizes[0]);
            int inputCols = int.Parse(sizes[1]);

            // N Sizes[0] Lines with M Sizes[1] Strings 
            // Break each row into separate elements
            string[][] jaggerArray = new string[inputRows][];

            for (int i = 0; i < inputRows; i++)
            {
                jaggerArray[i] = Console.ReadLine()
                                     .Trim(' ')
                                     .Split(' ');
            }

            // vars
            int maxSeq = 0;
            int currSeq = 1;

            // Step 1: Check By Rows
            for (int row = 0; row < inputRows; row++)
            {
                // reset for each row
                currSeq = 1;

                for (int col = 1; col < inputCols; col++)
                {
                    if (jaggerArray[row][col] ==
                        jaggerArray[row][col - 1])
                    {
                        currSeq++;
                    }
                    else
                    {
                        // check if cursequence is longest
                        if (currSeq > maxSeq)
                        {
                            maxSeq = currSeq;
                        }
                        //reset curseq
                        currSeq = 1;
                    }
                }

                // double check for last element on row
                if (currSeq > maxSeq)
                {
                    maxSeq = currSeq;
                }
            }

            // Step 2: Check By Cols
            for (int col = 0; col < inputCols; col++)
            {
                // reset for each col
                currSeq = 1;

                for (int row = 1; row < inputRows; row++)
                {
                    if (jaggerArray[row][col] ==
                        jaggerArray[row - 1][col])
                    {
                        currSeq++;
                    }
                    else
                    {
                        // check if cursequence is longest
                        if (currSeq > maxSeq)
                        {
                            maxSeq = currSeq;
                        }
                        //reset curseq
                        currSeq = 1;
                    }
                }

                // double check cursequence for last element
                if (currSeq > maxSeq)
                {
                    maxSeq = currSeq;
                }
            }

            // Check Diagonals
            // Diagonal Left 
            // TODO: Optimizie only check diagonals with enough
            // elements to get a new Max Length
            for (int Col = 1; Col < inputCols; Col++)
            {
                currSeq = 1;

                for (int curMod = 1;
                         curMod <= Math.Min(Col, inputRows - 1);
                         curMod++)
                {
                    if (jaggerArray[0 + curMod][Col - curMod] ==
                        jaggerArray[0 + (curMod - 1)][Col - (curMod - 1)])
                    {
                        currSeq++;
                    }
                }

                if (currSeq > maxSeq)
                {
                    maxSeq = currSeq;
                }
            }

            for (int Row = 1; Row < inputRows; Row++)
            {
                currSeq = 1;

                for (int curMod = 1;
                         curMod <= Math.Min(inputRows - 1 - Row - 1, inputCols - 2);
                         curMod++)
                {
                    if (jaggerArray[Row + curMod][(inputCols - 1) - curMod] ==
                        jaggerArray[Row + (curMod + 1)][(inputCols - 1) - (curMod + 1)])
                    {
                        currSeq++;
                    }
                }

                if (currSeq > maxSeq)
                {
                    maxSeq = currSeq;
                }
            }

            // Diagonal Right
            for (int Row = inputRows - 2;
                     Row >= 0;
                     Row--)
            {
                currSeq = 1;

                for (int curMod = 1;
                    curMod <= Math.Min(inputRows - Row - 1, inputCols - 1);
                    curMod++)
                {
                    if (jaggerArray[Row + curMod][0 + curMod] ==
                        jaggerArray[Row + (curMod - 1)][0 + (curMod - 1)])
                    {
                        currSeq++;
                    }
                }

                if (currSeq > maxSeq)
                {
                    maxSeq = currSeq;
                }
            }

            // Top Right
            for (int Row = 1;
                     Row < inputRows - 1;
                     Row++)
            {
                currSeq = 1;

                for (int curMod = 1;
                    curMod <= Math.Min(Row - 1, inputCols - 1);
                    curMod++)
                {
                    if (jaggerArray[Row - curMod][(inputCols - 1) - curMod] ==
                        jaggerArray[Row - (curMod - 1)][(inputCols - 1) - (curMod - 1)])
                    {
                        currSeq++;
                    }
                }

                if (currSeq > maxSeq)
                {
                    maxSeq = currSeq;
                }
            }

            // print output
            Console.WriteLine(maxSeq);
        }
    }
}