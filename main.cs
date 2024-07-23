using System;

class Program {
  public static void Main (string[] args) {
    char ch = 'D';
                int sum = 0, sumD = 0, sumE = 0, sumF = 0, value, highestSale;
                string highestSalesPerson;

                while (true)
                {
                    Console.WriteLine("Enter the initial for salesperson D, E, F, or Z to finish");
                    string input = Console.ReadLine().Trim();

                    if (!string.IsNullOrEmpty(input))
                    {
                        ch = Convert.ToChar(input.ToUpper());
                    }
                    else
                    {
                        ch = 'W';
                    }

                    if (ch == 'D')
                    {
                        Console.WriteLine("Enter the sale amount");
                        value = Convert.ToInt32(Console.ReadLine());
                        sum += value;
                        sumD += value;
                    }
                    else if (ch == 'E')
                    {
                        Console.WriteLine("Enter the sale amount");
                        value = Convert.ToInt32(Console.ReadLine());
                        sum += value;
                        sumE += value;
                    }
                    else if (ch == 'F')
                    {
                        Console.WriteLine("Enter the sale amount");
                        value = Convert.ToInt32(Console.ReadLine());
                        sum += value;
                        sumF += value;
                    }
                    else if (ch == 'Z')
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Intermediate output: Error, invalid salesperson selected, please try again");
                    }
                }

                if (sumD > sumE && sumD > sumF)
                {
                    highestSalesPerson = "Danielle";
                    highestSale = sumD;
                }
                else if (sumE > sumF)
                {
                    highestSalesPerson = "Edward";
                    highestSale = sumE;
                }
                else
                {
                    highestSalesPerson = "Francis";
                    highestSale = sumF;
                }

                Console.WriteLine($"\nTotal sale of Danielle is: {sumD:c}");
                Console.WriteLine($"Total sale of Edward is: {sumE:c}");
                Console.WriteLine($"Total sale of Francis is: {sumF:c}");

                Console.WriteLine($"\nHighest sales person is: {highestSalesPerson}");
                Console.WriteLine($"Highest sale is {highestSale:c}");
                Console.WriteLine($"Grand Total sale is: {sum:c}");
                
                 
                
          
                {
                  
                }

                Console.ReadLine();
            }
        }
    