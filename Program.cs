using System;

namespace print_series_n_terms
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n = 10;
                int count = 0;

                for (int i = 1; i <= n; i++)
                {
                    if (count == n)
                    {
                        break;
                    }

                    else
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            if (count == n)
                            {
                                break;
                            }
                            else
                            {
                                Console.Write(i + ",");
                                count++;
                            }
                        }
                    }
                }

            }   // End of try

            catch
            {
                Console.WriteLine("Exception occured while computing Intersect()");

            }   // End of catch
        }
    }
}
