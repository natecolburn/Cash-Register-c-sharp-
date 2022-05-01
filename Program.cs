using System;

// Author: Nathan Colburn
// date: 6/3/2019

//about:
// program askes you to input name of item, quantity, and price of items. 
// does calculations and outputs recipt.


namespace Assignment_5
{
    class Program
    {
        static void Main(string[] args)
        {

            int Counter = 0, QTY; 
            decimal price = 0, subTotal = 0, tax = 0.065M, total = 0, bottom_SubTotal = 0;
            string itemName = "";
            int i = 0;


            price = 0;

            string[,] items = new string[100,4];

            Console.WriteLine("                            Scan Items Now");
            Console.WriteLine();

            do
            {
                Console.Write(" Item Name: \n(enter 0 if done ):");
                itemName = Console.ReadLine();

               
                if (itemName == "0")
                    break;
                items[i, 0] = itemName;




                Console.WriteLine();

                Console.Write(" Quantity:  ");

                QTY = Convert.ToInt32(Console.ReadLine());
                items[i, 2] = QTY.ToString();



                Console.WriteLine();
                Console.Write(" Item Price:  $");
                price = Convert.ToDecimal(Console.ReadLine());
                items[i, 1] = price.ToString();


                Console.WriteLine();

                    //        calculate subtotal


                subTotal = price * QTY;
                items[i, 3] = subTotal.ToString();



                //store the item details int the array


                ++i;

                ++Counter; //  keep item count

                    // 


            


            } while (itemName != "0");

            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("total items: {0}", Counter);

            Console.WriteLine("");

            Console.WriteLine("{0}{1, 10}{2, 20}{3, 20}", "Name" , "price", "Quantity", "subTotal");

            for(int j = 0; j < Counter; j++)
            {
                Console.WriteLine("{0}{1,10}{2,20}{3,20}",
                    items[j, 0],
                    items[j, 1],
                    items[j, 2],
                    items[j, 3]);
                bottom_SubTotal += subTotal;
            }

            tax *= subTotal;
            total = bottom_SubTotal + tax;
            Console.WriteLine("SubTotal:     ${0}", string.Format("{0:0.00}", bottom_SubTotal));
            Console.WriteLine("Tax (0.065%): ${0}", string.Format("{0:0.00}", tax));
            Console.WriteLine("Total:        ${0}", string.Format("{0:0.00}", total));
            Console.ReadLine();
           // 




        }
        
    }


}
