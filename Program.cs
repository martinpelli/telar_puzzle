using System;
using System.IO;
using System.Text;

Console.WriteLine("Searching!")
Telar();

 void Telar()
        {
            int[] numbers = new int[20] { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, 31, 32, 34, 38, 40 };

            int[] l1 = new int[4];
            int[] l2 = new int[4];
            int[] l3 = new int[4];
            int[] l4 = new int[4];
            int[] l5 = new int[4];

            string path = @"./Solutions.txt";

            int index = 0;

            

            for (int a = 0; a < 20; a++)
            {
                l1[0] = numbers[a];
                for (int b = 0; b < 20; b++)
                {
                    if(l1[0] == numbers[b])
                    {
                        continue;
                    }
                    l1[1] = numbers[b];
                    for (int c = 0; c < 20; c++)
                    {
                        if (l1[0] == numbers[c] || l1[1] == numbers[c])
                        {
                            continue;
                        }
                        l1[2] = numbers[c];
                        for (int d = 0; d < 20; d++)
                        {
                            if (l1[0] == numbers[d] || l1[1] == numbers[d] || l1[2] == numbers[d])
                            {
                                continue;
                            }
                            l1[3] = numbers[d];
                            if ((l1[0] + l1[1] + l1[2] + l1[3]) != 80)
                            {
                                continue;
                            }
                            for (int e = 0; e < 20; e++)
                            {
                                if (l1[0] == numbers[e] || l1[1] == numbers[e] || l1[2] == numbers[e] || l1[3] == numbers[e])
                                {
                                    continue;
                                }
                                l2[0] = numbers[e];
                                for (int f = 0; f < 20; f++)
                                {
                                    if (l1[0] == numbers[f] || l1[1] == numbers[f] || l1[2] == numbers[f] || l1[3] == numbers[f] || l2[0] == numbers[f])
                                    {
                                        continue;
                                    }
                                    l2[1] = numbers[f];
                                    for (int g = 0; g < 20; g++)
                                    {
                                        if (l1[0] == numbers[g] || l1[1] == numbers[g] || l1[2] == numbers[g] || l1[3] == numbers[g] || l2[0] == numbers[g] || l2[1] == numbers[g])
                                        {
                                            continue;
                                        }
                                        l2[2] = numbers[g];
                                        for (int h = 0; h < 20; h++)
                                        {
                                            if (l1[0] == numbers[h] || l1[1] == numbers[h] || l1[2] == numbers[h] || l1[3] == numbers[h] || l2[0] == numbers[h] || l2[1] == numbers[h] || l2[2] == numbers[h])
                                            {
                                                continue;
                                            }
                                            l2[3] = numbers[h];
                                            if ((l2[0] + l2[1] + l2[2] + l2[3]) != 80)
                                            {
                                                continue;

                                            }
                                            for (int i = 0; i < 20; i++)
                                            {
                                                if (l1[0] == numbers[i] || l1[1] == numbers[i] || l1[2] == numbers[i] || l1[3] == numbers[i] || l2[0] == numbers[i] || l2[1] == numbers[i] || l2[2] == numbers[i] || l2[3] == numbers[i])
                                                {
                                                    continue;
                                                }
                                                l3[0] = numbers[i];
                                                for (int j = 0; j < 20; j++)
                                                {
                                                    if (l1[0] == numbers[j] || l1[1] == numbers[j] || l1[2] == numbers[j] || l1[3] == numbers[j] || l2[0] == numbers[j] || l2[1] == numbers[j] || l2[2] == numbers[j] || l2[3] == numbers[j] || l3[0] == numbers[j])
                                                    {
                                                        continue;
                                                    }
                                                    l3[1] = numbers[j];
                                                    for (int k = 0; k < 20; k++)
                                                    {
                                                        if (l1[0] == numbers[k] || l1[1] == numbers[k] || l1[2] == numbers[k] || l1[3] == numbers[k] || l2[0] == numbers[k] || l2[1] == numbers[k] || l2[2] == numbers[k] || l2[3] == numbers[k] || l3[0] == numbers[k] || l3[1] == numbers[k])
                                                        {
                                                            continue;
                                                        }
                                                        l3[2] = numbers[k];
                                                        for (int l = 0; l < 20; l++)
                                                        {
                                                            if (l1[0] == numbers[l] || l1[1] == numbers[l] || l1[2] == numbers[l] || l1[3] == numbers[l] || l2[0] == numbers[l] || l2[1] == numbers[l] || l2[2] == numbers[l] || l2[3] == numbers[l] || l3[0] == numbers[l] || l3[1] == numbers[l] || l3[2] == numbers[l])
                                                            {
                                                                continue;
                                                            }
                                                            l3[3] = numbers[l];
                                                            if ((l3[0] + l3[1] + l3[2] + l3[3]) != 80)
                                                            {
                                                                continue;

                                                            }
                                                            for (int m = 0; m < 20; m++)
                                                            {
                                                                if (l1[0] == numbers[m] || l1[1] == numbers[m] || l1[2] == numbers[m] || l1[3] == numbers[m] || l2[0] == numbers[m] || l2[1] == numbers[m] || l2[2] == numbers[m] || l2[3] == numbers[m] || l3[0] == numbers[m] || l3[1] == numbers[m] || l3[2] == numbers[m] || l3[3] == numbers[m])
                                                                {
                                                                    continue;
                                                                }
                                                                l4[0] = numbers[m];
                                                                for (int n = 0; n < 20; n++)
                                                                {
                                                                    if (l1[0] == numbers[n] || l1[1] == numbers[n] || l1[2] == numbers[n] || l1[3] == numbers[n] || l2[0] == numbers[n] || l2[1] == numbers[n] || l2[2] == numbers[n] || l2[3] == numbers[n] || l3[0] == numbers[n] || l3[1] == numbers[n] || l3[2] == numbers[n] || l3[3] == numbers[n] || l4[0] == numbers[n])
                                                                    {
                                                                        continue;
                                                                    }
                                                                    l4[1] = numbers[n];
                                                                    for (int ñ = 0; ñ < 20; ñ++)
                                                                    {
                                                                        if (l1[0] == numbers[ñ] || l1[1] == numbers[ñ] || l1[2] == numbers[ñ] || l1[3] == numbers[ñ] || l2[0] == numbers[ñ] || l2[1] == numbers[ñ] || l2[2] == numbers[ñ] || l2[3] == numbers[ñ] || l3[0] == numbers[ñ] || l3[1] == numbers[ñ] || l3[2] == numbers[ñ] || l3[3] == numbers[ñ] || l4[0] == numbers[ñ] || l4[1] == numbers[ñ])
                                                                        {
                                                                            continue;
                                                                        }
                                                                        l4[2] = numbers[ñ];
                                                                        for (int o = 0; o < 20; o++)
                                                                        {
                                                                            if (l1[0] == numbers[o] || l1[1] == numbers[o] || l1[2] == numbers[o] || l1[3] == numbers[o] || l2[0] == numbers[o] || l2[1] == numbers[o] || l2[2] == numbers[o] || l2[3] == numbers[o] || l3[0] == numbers[o] || l3[1] == numbers[ñ] || l3[2] == numbers[o] || l3[3] == numbers[o] || l4[0] == numbers[o] || l4[1] == numbers[o] || l4[2] == numbers[o])
                                                                            {
                                                                                continue;
                                                                            }
                                                                            l4[3] = numbers[o];
                                                                            if ((l4[0] + l4[1] + l4[2] + l4[3]) != 80)
                                                                            {
                                                                                continue;

                                                                            }
                                                                            for (int p = 0; p < 20; p++)
                                                                            {
                                                                                if (l1[0] == numbers[p] || l1[1] == numbers[p] || l1[2] == numbers[p] || l1[3] == numbers[p] || l2[0] == numbers[p] || l2[1] == numbers[p] || l2[2] == numbers[p] || l2[3] == numbers[p] || l3[0] == numbers[p] || l3[1] == numbers[p] || l3[2] == numbers[p] || l3[3] == numbers[p] || l4[0] == numbers[p] || l4[1] == numbers[p] || l4[2] == numbers[p] || l4[3] == numbers[p])
                                                                                {
                                                                                    continue;
                                                                                }
                                                                                l5[0] = numbers[p];
                                                                                for (int q = 0; q < 20; q++)
                                                                                {
                                                                                    if (l1[0] == numbers[q] || l1[1] == numbers[q] || l1[2] == numbers[q] || l1[3] == numbers[q] || l2[0] == numbers[q] || l2[1] == numbers[q] || l2[2] == numbers[q] || l2[3] == numbers[q] || l3[0] == numbers[q] || l3[1] == numbers[q] || l3[2] == numbers[q] || l3[3] == numbers[q] || l4[0] == numbers[q] || l4[1] == numbers[q] || l4[2] == numbers[q] || l4[3] == numbers[q] || l5[0] == numbers[q])
                                                                                    {
                                                                                        continue;
                                                                                    }
                                                                                    l5[1] = numbers[q];
                                                                                    for (int r = 0; r < 20; r++)
                                                                                    {
                                                                                        if (l1[0] == numbers[r] || l1[1] == numbers[r] || l1[2] == numbers[r] || l1[3] == numbers[r] || l2[0] == numbers[r] || l2[1] == numbers[r] || l2[2] == numbers[r] || l2[3] == numbers[r] || l3[0] == numbers[r] || l3[1] == numbers[r] || l3[2] == numbers[r] || l3[3] == numbers[r] || l4[0] == numbers[r] || l4[1] == numbers[r] || l4[2] == numbers[r] || l4[3] == numbers[r] || l5[0] == numbers[r] || l5[1] == numbers[r])
                                                                                        {
                                                                                            continue;
                                                                                        }
                                                                                        l5[2] = numbers[r];
                                                                                        for (int s = 0; s < 20; s++)
                                                                                        {
                                                                                            if (l1[0] == numbers[s] || l1[1] == numbers[s] || l1[2] == numbers[s] || l1[3] == numbers[s] || l2[0] == numbers[s] || l2[1] == numbers[s] || l2[2] == numbers[s] || l2[3] == numbers[s] || l3[0] == numbers[s] || l3[1] == numbers[s] || l3[2] == numbers[s] || l3[3] == numbers[s] || l4[0] == numbers[s] || l4[1] == numbers[s] || l4[2] == numbers[s] || l4[3] == numbers[s] || l5[0] == numbers[s] || l5[1] == numbers[s])
                                                                                            {
                                                                                                continue;
                                                                                            }
                                                                                            l5[3] = numbers[s];
                                                                                            if ((l5[0] + l5[1] + l5[2] + l5[3]) != 80)
                                                                                            {
                                                                                                continue;

                                                                                            }
                                                                                            if (((l1[0] + l1[1] + l1[2] + l1[3]) == 80) && ((l2[0] + l2[1] + l2[2] + l2[3]) == 80) && ((l3[0] + l3[1] + l3[2] + l3[3]) == 80) && ((l4[0] + l4[1] + l4[2] + l4[3]) == 80) && ((l5[0] + l5[1] + l5[2] + l5[3]) == 80))
                                                                                            {
                                                                                                if ((l1[0] + l2[0] + l3[0] + l4[0] + l5[0] == 100) && (l1[1] + l2[1] + l3[1] + l4[1] + l5[1] == 100) && (l1[2] + l2[2] + l3[2] + l4[2] + l5[2] == 100) && (l1[3] + l2[3] + l3[3] + l4[3] + l5[3] == 100))
                                                                                                {
                                                                                                    index += 1;
                                                                                                    string appendText = "Solución " + index.ToString() + ":" + Environment.NewLine;
                                                                                                    appendText += l1[0].ToString() + " " + l1[1].ToString() + " " + l1[2].ToString() + " " + l1[3].ToString() + Environment.NewLine;
                                                                                                    appendText += l2[0].ToString() + " " + l2[1].ToString() + " " + l2[2].ToString() + " " + l2[3].ToString() + Environment.NewLine;
                                                                                                    appendText += l3[0].ToString() + " " + l3[1].ToString() + " " + l3[2].ToString() + " " + l3[3].ToString() + Environment.NewLine;
                                                                                                    appendText += l4[0].ToString() + " " + l4[1].ToString() + " " + l4[2].ToString() + " " + l4[3].ToString() + Environment.NewLine;
                                                                                                    appendText += l5[0].ToString() + " " + l5[1].ToString() + " " + l5[2].ToString() + " " + l5[3].ToString() + Environment.NewLine;
                                                                                                    appendText += "\n";
                                                                                                    File.AppendAllText(path, appendText, Encoding.UTF8);
                                                                                                }
                                                                                            }
                                                                                        }

                                                                                    }

                                                                                }

                                                                            }

                                                                        }

                                                                    }

                                                                }

                                                            }


                                                        }

                                                    }

                                                }

                                            }

                                        }

                                    }

                                }

                            }

                        }

                    }

                }
            }
        }