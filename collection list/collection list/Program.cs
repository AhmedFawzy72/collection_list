using System.Collections;
using System.Collections.Generic;

namespace collection_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> my_list = new List<int> { };
            Console.WriteLine("Welcome in my program");
            Console.WriteLine("Do you want show list program (yes/no)");
            string chosin = Console.ReadLine();
            if (chosin == "yes")
            {
             while (true)
                {
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine(
                        "P - Print numbers\r\n" +
                        "A - Add a number\r\n" +
                        "M - Display mean of the numbers\r\n" +
                        "S - Display the smallest number\r\n" +
                        "L - Display the largest number\r\n" +
                        "F - Find a number\r\n"+
                        "Z - Sort list\r\n"+
                        "H - swap two number\r\n"+
                        "C - Clear list\r\n"+
                        "Q - Quit");
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("Enter your choice");
                    char choice = char.Parse(Console.ReadLine());
                    switch(choice)
                    {
                        //case should display all of the elements (ints) in the list
                        //--------------------------------------------------------------
                        case 'P':
                        case 'p':
                            if (my_list.Count == 0)
                            {
                                Console.WriteLine("[] - the list is empty");
                            }
                            else
                            {
                                Console.Write("["+" ");
                                for(int i = 0; i < my_list.Count; i++)
                                {
                                    Console.Write(my_list[i]+" ");
                                }
                                Console.WriteLine("]");
                            }
                            break;
                        //----------------------------------------------------------------
                        //add number to the list
                        case 'A':
                        case 'a':
                            Console.WriteLine("Please Enter The Number : ");
                            int num = Convert.ToInt32(Console.ReadLine());
                            bool isDuplicate = false;
                            for (int i = 0; i < my_list.Count; i++)
                            {
                                if (my_list[i] == num) 
                                {
                                    isDuplicate = true;
                                    break;
                                }
                            }
                            if (!isDuplicate)
                            {
                                my_list.Add(num);
                                Console.WriteLine($"Number added: {num} successfully");
                            }
                            else if (isDuplicate)
                            {
                              Console.WriteLine("The number already entered || Please Enter Vaild Nmuber");
                                int vaild_num = Convert.ToInt32(Console.ReadLine());
                                bool isVaild = false;
                                for (int i = 0; i < my_list.Count; i++)
                                {
                                    if (my_list[i] == vaild_num)
                                    {
                                        isVaild = true;
                                        break;
                                    }
                                }
                                if (!isVaild)
                                {
                                    my_list.Add(vaild_num);
                                    Console.WriteLine($"Number added: {vaild_num} successfully");
                                }

                            }
                           
                            break;
                        //----------------------------------------------------------------
                        //calculate the mean or average of the elements in the list
                        case 'M':
                        case 'm':
                            double average = 0;
                            int sum = 0;
                            int number_in_list = my_list.Count;
                            if (number_in_list == 0)
                            {
                                Console.WriteLine("Unable to calculate the average - no data\"\r\n");
                            }
                            else
                            {
                                for (int i = 0; i < my_list.Count; i++)
                                {
                                    sum += my_list[i];
                                }
                                average = sum / number_in_list;
                                Console.WriteLine($"The average of the elements in the list = {average}");
                            }
                             break;
                        //----------------------------------------------------------------
                        //display the smallest element in the list
                        case 'S':
                        case 's':
                            int min_num_inList = my_list[0];
                            for(int i = 0; i < my_list.Count; i++)
                            {
                                if(my_list[i]<=min_num_inList)
                                {
                                    min_num_inList = my_list[i];
                                }
                            }
                            Console.WriteLine($"The smallest number is : {min_num_inList}");
                                    break;
                        //----------------------------------------------------------------
                        //display the largest element in the list
                        case 'L':
                        case 'l':
                          int max_num_inlist = my_list[0];
                            for (int i = 0; i < my_list.Count; i++)
                            {
                                if (my_list[i] >= max_num_inlist)
                                {
                                    max_num_inlist = my_list[i];
                                }
                            }
                          Console.WriteLine($"The largest  number is : {max_num_inlist}");
                          break;
                        //----------------------------------------------------------------
                        //clear the list[]
                        case 'C':
                        case 'c':
                        my_list.Clear();
                         break;
                        //----------------------------------------------------------------
                        //find number in the list[]
                        case 'F':
                        case 'f':
                             int my_index=0;
                            bool is_found = false;
                            
                         Console.WriteLine("Enter The num : ");
                          int num_search = Convert.ToInt32(Console.ReadLine());
                         for(int i = 0; i < my_list.Count; i++)
                            {
                                if (num_search == my_list[i])
                                {
                                    is_found = true;
                                    my_index = i;
                                }
                            }
                         if(is_found)
                          Console.WriteLine($"The num {num_search} is found and the index is : [{my_index}]");
                         else Console.WriteLine("The number is not Found");
                           break;
                        //----------------------------------------------------------------
                        //Sorting number in the list using buble sort[]
                        case 'Z':
                        case 'z':
                            Console.WriteLine(" you want Sorting ASC || DESC");
                            string select_sort = Console.ReadLine();
                            if(select_sort=="ASC")
                            {
                                for (int i = 0; i < my_list.Count - 1; i++)
                                {
                                    for (int j = 0; j < my_list.Count - 1 - i; j++)
                                    {
                                        if (my_list[j] > my_list[j + 1])
                                        {
                                            int temp = my_list[j];
                                            my_list[j] = my_list[j + 1];
                                            my_list[j + 1] = temp;
                                        }
                                    }
                                }
                                Console.Write("the list after sorting  ASC ");
                                Console.Write("[" + " ");
                                for (int i = 0; i < my_list.Count; i++)
                                {
                                    Console.Write(my_list[i] + " ");
                                }
                                Console.Write("]");
                                Console.WriteLine();
                            }
                            else if(select_sort == "DESC")
                            {
                                for (int i = 0; i < my_list.Count - 1; i++)
                                {
                                    for (int j = 0; j < my_list.Count - 1 - i; j++)
                                    {
                                        if (my_list[j] < my_list[j + 1])
                                        {
                                            int temp = my_list[j];
                                            my_list[j] = my_list[j + 1];
                                            my_list[j + 1] = temp;
                                        }
                                    }
                                }
                                Console.Write("the list after sorting DESC ");
                                Console.Write("[" + " ");
                                for (int i = 0; i < my_list.Count; i++)
                                {
                                    Console.Write(my_list[i] + " ");
                                }
                                Console.Write("]");
                                Console.WriteLine();
                            }
                              break;
                        //----------------------------------------------------------------
                        case 'H':
                        case 'h':
                            Console.WriteLine("-----------------------------------------");
                            Console.WriteLine("take care!!the index number start with [0]");
                            Console.WriteLine("-----------------------------------------");
                            Console.WriteLine("Enter The index number you want to swap ");
                            int num1 = Convert.ToInt32(Console.ReadLine());
                            int num2 = Convert.ToInt32(Console.ReadLine());
                            int temp2 = 0;
                            temp2 = my_list[num1];
                            my_list[num1] = my_list[num2];
                            my_list[num2 ] = temp2;
                            Console.WriteLine("the list After swaping :");
                            Console.Write("[" + " ");
                            for (int i = 0; i < my_list.Count; i++)
                            {
                                Console.Write(my_list[i] + " ");
                            }
                            Console.Write("]");
                            Console.ReadLine();


                           break;

                        //----------------------------------------------------------------
                        //quit the program
                        case 'Q':
                        case 'q':
                         Console.WriteLine("Goodbye");
                         return;
                        //----------------------------------------------------------------                      
                        default:
                            Console.WriteLine("Unknown selection, please try again");
                          break;
                         
                           
                    }



                }

            }


            else
            {
                Console.WriteLine("Good Bye");
            }
        }
    }
}
