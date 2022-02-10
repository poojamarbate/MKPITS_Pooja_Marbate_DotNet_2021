using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_Project_Based_OnSwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**************************************************Welcome****************************************");
            Console.WriteLine();
            Console.WriteLine();
             int FoodCode;
            Console.WriteLine("Press Menu Code for ordering Food =>>>> Food Code Avaliable in front of Food name press the number shown in (): \n\n\n::Indian Food(1) \n\n::Chines food(2) \n\n::Itelian Food(3) \n\n::south indian food(4) \n\n::Bangoli Special Food(5) \n\n::Rajathan Special Food(6) \n\n::Gujaraat Special Food (7)" +
                "\n\n::Maharashtrian Special Food(8)\n\n ");
                FoodCode=int.Parse(Console.ReadLine());
               switch(FoodCode)
            {
                case 1:
                    Console.WriteLine("You are selected Indian Food\n");
                    Console.WriteLine("\n\nIndian Food Menu:\n\nFoodCode::\n\nm-Masala chai\n\nc- Chaat\n\np-Pani puri\n\nd-Dhokla\n\nk-Dal makhani\n");
                   char IFood =Convert.ToChar (Console.ReadLine());
                    switch(IFood)
                    {
                        case 'm':
                            Console.WriteLine("\nYou are selected Masala Chai\nPrice:10Rs/-cut");
                            break;
                        case 'c':
                            Console.WriteLine("\nYou are selected Chaat\nPrice:30Rs/-Full");
                            break;
                        case 'p':
                            Console.WriteLine("\nYou are selected Pani puri\nPrice:15Rs/-");
                            break;
                        case 'k':
                            Console.WriteLine("\nYou are selected Dal makhani\nPrice:110Rs/-");
                            break;
                        case 'd':
                            Console.WriteLine("\nYou are selected Dhokla\nPrice:40Rs/-");
                            break;
                        default:
                            Console.WriteLine("Invalid selection\n");
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("You are selected Chines Food\n");
                    Console.WriteLine("Chines Food Menu:\n\nFoodCode::\n\nn-Noodles\n\nm-Manchurian\n\nf-fried rice\n\nh-Manchurian Noodles\n\nc-chicken65\n\n");
                    char cf = Convert.ToChar(Console.ReadLine());
                    switch(cf)
                    {
                        case 'n':
                            Console.WriteLine("You are selected Noodles\nPrice:80Rs/-full");
                            break;
                        case 'm':
                            Console.WriteLine("You are selected Manchurian\nPrice:80Rs/-full");
                            break;
                        case 'f':
                            Console.WriteLine("You are selected fried rice\nPrice:80Rs/-full");
                            break;
                        case 'h':
                            Console.WriteLine("You are selected Manchurian Noodles\nPrice:100Rs/-full");
                            break;
                        case 'c':
                            Console.WriteLine("You are selected chicken65\nPrice:180Rs/-");
                            break;
                        default:
                            Console.WriteLine("Invalid selection");
                            break;
                    }
                    break;
                case 3:
                    Console.WriteLine("You are selected ItelianFood");
                    Console.WriteLine("Itelian Food Menu:\n\nFoodCode::\n\np-Pastaa\n\nz-Pizza\n\nr-pastry\n\nb-Bread\n\ni-Ice-Cream\n\n");
                    char Food = Convert.ToChar(Console.ReadLine());
                    switch(Food)
                    {

                        case 'p':
                            Console.WriteLine("You are selected Pastaa\nPrice:100Rs/-");
                            break;

                        case 'z':
                            Console.WriteLine("You are selected Pizza\nPrice:199Rs/-");
                            break;

                        case 'r':
                            Console.WriteLine("You are selected Pastry\nPrice:150Rs/-");
                            break;
                        case 'b':
                            Console.WriteLine("You are selected Bread\nPrice:150Rs/-");
                            break;
                        case 'i':
                            Console.WriteLine("You are selected Ice-Cream\nPrice:150Rs/-");
                            break;
                        default:
                            Console.WriteLine("Invalid selection");
                            break;

                    }
                    break;
                case 4:
                    Console.WriteLine("You are selected South Indian Food");
                    Console.WriteLine("South Indian Food Menu:\n\nFoodCode::\n\nd-Dosa\n\ne-Idle\n\nu-Uttapam\n\nm-Sambhadvada\n\na-Aappe\n\n");
                    char sfF = Convert.ToChar(Console.ReadLine());
                    switch (sfF)
                    {
                        case 'd':
                            Console.WriteLine("You are selected Dosa\nPrice:100Rs/-");
                            break;
                        case 'e':
                            Console.WriteLine("You are selected Idle\nPrice:80Rs/-");
                            break;
                        case 'u':
                            Console.WriteLine("You are selected Uttapam\nPrice:80Rs/-");
                            break;
                        case 'm':
                            Console.WriteLine("You are selected Sambhadvada\nPrice:50Rs/-");
                            break;
                        case 'a':
                            Console.WriteLine("You are selected Aappe\nPrice:60Rs/-");
                            break;
                        default:
                            Console.WriteLine("Invalid selection");
                            break;
                    }
                    break;
                case 5:
                    Console.WriteLine("You are selected Bangoli Food");
                    Console.WriteLine("Bangoli Food Menu:\n\nFoodCode::\n\nd-Doi Maach\n\nb-Bhapaa Aloo\n\nc-Chingri Malai Curry\n\ns-Sandesh\n\n");
                    char bf = Convert.ToChar(Console.ReadLine());
                    switch(bf)
                    {
                        case 'd':
                            Console.WriteLine("You are selected Doi Maach\nPrice:450RS/-");
                            break;
                        case 'b':
                            Console.WriteLine("You are selected Bhapaa Aloo\nPrice:450RS/-");
                            break;
                        case 'c':
                            Console.WriteLine("You are selected Chingri Malai Curry\nPrice:450RS/-");
                            break;
                        case 's':
                            Console.WriteLine("You are selected Sandesh\nPrice:450RS/-");
                            break;
                        default:
                            Console.WriteLine("Invalid selection");
                            break;

                    }
                    break;
                case 6:
                    Console.WriteLine("You are selected Rajathani Food");
                    Console.WriteLine("Rajathani Food Menu:\n\nFoodCode::\n\nk-Ker Sangri\n\np-Papad ki subzi\n\nr-Raab\n\no-Onion kachori\n\ng-Ghevar\n\n");
                    char rf = Convert.ToChar(Console.ReadLine());
                    switch(rf)
                    {
                        case 'g':
                            Console.WriteLine("You are selected Ghevar\nPrice:150RS/-");
                            break;
                        case 'k':
                            Console.WriteLine("You are selected Ker Sangri\nPrice:750RS/-");
                            break;
                        case 'p':
                            Console.WriteLine("You are selected Papad ki subzi\nPrice:350RS/-");
                            break;
                        case 'r':
                            Console.WriteLine("You are selected Raab\nPrice:450RS/-");
                            break;
                        case 'o':
                            Console.WriteLine("You are selected Onion kachori\nPrice:150RS/-");
                            break;
                        default:
                            Console.WriteLine("Invalid selection");
                            break;

                    }
                    break; 
                case 7:
                    Console.WriteLine("You are selected Gujaraati Food");
                    Console.WriteLine("Gujarati Food Menu:\n\nFoodCode::\n\nk-Khandvi\n\ng-Gujarati Samosa\n\nu-Undhiyu\n\na-Aam Shrikhand with Mango Salad" +
                        "\n\nt-Thepla\n\n");
                    char gf = Convert.ToChar(Console.ReadLine());
                    switch(gf)
                    {
                        case 'k':
                            Console.WriteLine("You are selected Khandvi\nPrice:150RS/-");
                            break;
                        case 'g':
                            Console.WriteLine("You are selected Gujarati Samosa\nPrice:80RS/-");
                            break;
                        case 'u':
                            Console.WriteLine("You are selected Undhiyu\nPrice:350RS/-");
                            break;
                        case 'a':
                            Console.WriteLine("You are selected Aam Shrikhand with Mango Salad\nPrice:450RS/-");
                            break;
                        case 't':
                            Console.WriteLine("You are selected Thepla\nPrice:150RS/-");
                            break;
                        default:
                            Console.WriteLine("Invalid selection");
                            break;
                    }
                    break;
                case 8:
                    Console.WriteLine("You are selected Maharashtrian Food");
                    Console.WriteLine("Maharashtrian Food Menu:\n\nFoodCode::\n\nv-VadaPav\n\nm-Misalpav\n\np-Pavbhaji\n\nd-Modak\n\nl-Puran Poli\n\n");
                    char mf = Convert.ToChar(Console.ReadLine());
                    switch(mf)
                    {
                        case 'v':
                            Console.WriteLine("You are selected VadaPav\nPrice:150RS/-");
                            break;
                        case 'm':
                            Console.WriteLine("You are selected Misalpav\nPrice:80RS/-");
                            break;
                        case 'p':
                            Console.WriteLine("You are selected Pavbhaji\nPrice:150RS/-");
                            break;
                        case 'd':
                            Console.WriteLine("You are selected Modak\nPrice:450RS/-");
                            break;
                        case 'l':
                            Console.WriteLine("You are selected Puran Poli\nPrice:150RS/-");
                            break;
                        default:
                            Console.WriteLine("Invalid selection");
                            break;
                    }
                    break;
                
                default:
                    Console.WriteLine("Selected Food Items is Not Avaliable pleases select another item ");
                    break;


            }

            Console.WriteLine("\n\nThanking You");



























            Console.ReadLine();
        }
    }
}
