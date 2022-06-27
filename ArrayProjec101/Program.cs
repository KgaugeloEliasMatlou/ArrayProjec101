using System;


class advaArrays
{
    static void Main()
    {
        int[] advArray = new int[5];
        Stack<int> stack = new Stack<int>();
        
        bool isValid = false;
        Random random = new Random();

        do
        {
            int choice = getChoice();
            switch (choice)
            {
                case 1:
                    for (int i = 0; i < 5; i++)
                    {
                        advArray[i] = random.Next(100);
                        stack.Push(advArray[i]);
                    }
                    break;
                case 2:
                    foreach (int i in stack)
                    {
                        Console.WriteLine(i);
                    }
                    break;
                case 3:

                    Console.WriteLine("the number was popped " + stack.Pop());
                    
                    
                    break;

                case 4:

                    Array.Clear(advArray, 0, advArray.Length);
                    break;
                default:
                    break;

            }
            if(choice == 5)
            {
                isValid = true;
            }

        } while (!isValid);
        

    }



    static int getChoice()
    {
        bool isValid = false;
        int choice = 0;
        do
        {
            try
            {
                // ask the user to choose from the below menu 
                Console.Write("Please choos from the below menu\n" +
                    "1 : Add values to the array\n" +
                    "2 : Display values from the array\n" +
                    "3 : Pop values from the array\n" +
                    "4 : Clear the array\n" +
                    "5 : Exit\n" +
                    "Your choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                if(choice < 1 && choice > 5)
                {
                    isValid = false;
                }
                else
                {
                    if(choice ==5)
                    {
                        Console.WriteLine("Thank you for using our program");
                        isValid = true;
                    }
                    isValid = true;
                }
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        } while (!isValid);
        return choice;
    }

    
}