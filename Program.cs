class Program
{
    static void Main(string[] args)
    {
        CircularLinkedList<char> flower = new CircularLinkedList<char>(); 
        while(true)
        {
            Console.Write("Input Fower ( J,G,O,R ) : ");
            char Flower_input = char.Parse(Console.ReadLine());

            if (Flower_input != 'J' && Flower_input != 'G' && Flower_input != 'O'&& Flower_input != 'R' )
            {
                break;
            }
            else
            {
                int input_form_users = flower.GetLength();
                if(input_form_users == 0)
                {
                    if(Flower_input == 'R')
                    {
                        //Console.Clear();
                        Console.WriteLine("Invalid pattern.");
                        //Console.WriteLine("Please try again.");
                    }
                    else
                    {
                    flower.Add(Flower_input);
                    }
                }                
                else if(input_form_users >= 1)
                {

                    if(input_form_users <= 2)
                    {
                        if (flower.Get(-1) == 'R')
                        {
                            if(Flower_input == flower.Get(-2) || Flower_input == 'R')
                            {
                            Console.WriteLine("Invalid pattern.");
                            //Console.WriteLine("Please try again.");
                            }
                            else
                            {
                            flower.Add(Flower_input);
                            }
                        }
                    else if(Flower_input == 'R')
                    {
                        if(Flower_input == flower.Get(-1))
                        {
                            Console.WriteLine("Invalid pattern.");
                            //Console.WriteLine("Please try again.");
                        }
                        else
                        {
                            flower.Add(Flower_input);
                        }
                    }
                    else 
                    {
                        flower.Add(Flower_input);
                    }
                    }


                    else if(input_form_users >= 3)
                    {
                        
                        if(flower.Get(-1) == 'R' && Flower_input == flower.Get(-2))
                        {

                            if(Flower_input == 'R')
                            {
                            Console.WriteLine("Invalid pattern.");
                            //Console.WriteLine("Please try again.");
                            }

                            else if(Flower_input == flower.Get(-2))
                            {
                                Console.WriteLine("Invalid pattern.");
                                //Console.WriteLine("Please try again.");
                            }
                            else
                            {
                                flower.Add(Flower_input);
                            }
                        }

                        else if(Flower_input == 'R')
                        {
                            if(Flower_input == flower.Get(-1))
                            {
                                Console.WriteLine("Invalid pattern.");
                                //Console.WriteLine("Please try again.");
                            }
                            else
                            {
                            flower.Add(Flower_input);
                            }
                        }
                        else if(Flower_input == 'G')
                        {
                            if(flower.Get(0) == 'G' && flower.Get(1) == 'G' && flower.Get(2) == 'G' && flower.Get(3) == 'G')
                            {
                                Console.WriteLine("Invalid pattern.");
                                //Console.WriteLine("Please try again.");
                            }
                            else if(Flower_input == flower.Get(-1) && Flower_input == flower.Get(-2)&& Flower_input == flower.Get(-3))
                            {
                                Console.WriteLine("Invalid pattern.");
                                //Console.WriteLine("Please try again.");
                            }
                            else
                            {
                                flower.Add(Flower_input);
                            }
                        }
                        else 
                        {
                            flower.Add(Flower_input);
                        }

                    }
                }
            }
        }
        Console.WriteLine("=================================================");
        int index = 0;
        int print_totalflower = flower.GetLength();
        Console.Write("Total number of flowers : ");
        Console.WriteLine(print_totalflower);
        while(index < print_totalflower)
        {
            Console.Write(flower.Get(index));
            index++;
        }
        Console.ReadKey();
    }
}