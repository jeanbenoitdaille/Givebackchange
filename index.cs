    using System;
    using System.Collections.Generic;
     
    namespace Coding.Exercise
    {
        public class Exercise
        {
            public int[] GiveChange(int x, int y)
            {
                int change = y - x;
                List<int> result = new List<int>();
                
                while (change > 0)
                {
                    if (change >= 50)
                    {
                        result.Add(50);
                        change -= 50;
                    }
                    else
                    {
                        if (change >= 20)
                        {
                            result.Add(20);
                            change -= 20;
                        }
                        else
                        {
                        if (change >= 10)
                        {
                            result.Add(10);
                            change -= 10;
                        }
                        else
                        {
                            if (change >= 5)
                            {
                                result.Add(5);
                                change -= 5;
                            }
                            else
                            {
                                if (change >= 2)
                                {
                                    result.Add(2);
                                    change -= 2;
                                }
                                else
                                {
                                    result.Add(1);
                                    change -= 1;
                                }
                            }
                        }
                    }
                }
            }
                return result.ToArray();
            }
        }
    }