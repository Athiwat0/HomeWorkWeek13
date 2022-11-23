class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        CircularLinkedList<char> flower = new CircularLinkedList<char>(); 
        while(true)
        {
            Console.Write("Input Flower ( J,G,O,R ) : ");
            char Flower_input = char.Parse(Console.ReadLine());

            if (Flower_input != 'J' && Flower_input != 'G' && Flower_input != 'O'&& Flower_input != 'R' )
            {
                break; // if Input not J G O R will Error
            }
            else
            {
                int input_form_users = flower.GetLength();
                if(input_form_users == 0)
                {
                    if(Flower_input == 'R') //ห้าม R ตัวแรก
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
                //S1                
                else if(input_form_users >= 1) //input >1 time
                {
                    if(input_form_users <= 2) //input <2 time
                    {
                        if(input_form_users <=1 && Flower_input == 'R')
                        {
                            Console.WriteLine("Invalid pattern.");      
                        }
                        else if(Flower_input == 'R' && flower.Get(0) == flower.Get(-1))
                        {
                            Console.WriteLine("Invalid pattern.");
                        }
                        else if(Flower_input == 'R' && flower.Get(-1) == flower.Get(-2))
                        {
                            Console.WriteLine("Invalid pattern.");
                        }
                        else
                        {
                            flower.Add(Flower_input);
                        }
                    }
                    //S2
                    else if(input_form_users >= 3) //input 3 time
                    {
                        if(Flower_input == 'R' && flower.Get(0) == flower.Get(-1))
                        {
                            Console.WriteLine("Invalid pattern.");
                        }
                        else if(flower.Get(-1) == 'R' && Flower_input == flower.Get(-2))
                        {
                            Console.WriteLine("Invalid pattern.");
                        }     
                        else if(Flower_input == 'G')
                        {
                            if(Flower_input == flower.Get(-1) && Flower_input == flower.Get(-2) && Flower_input == flower.Get(-3)) //G !3 last input
                            {
                               Console.WriteLine("Invalid pattern."); 
                            }
                            else if(flower.Get(0) == 'G' && flower.Get(1) == 'G' && flower.Get(2) == 'G') // check G !>3 will Error
                            {
                                Console.WriteLine("Invalid pattern.");
                            }
                            else if(flower.Get(0) == 'G' && flower.Get(-1) == 'G' && flower.Get(-2) == 'G') // if input G R G will Error 
                            {
                                Console.WriteLine("Invalid pattern.");
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