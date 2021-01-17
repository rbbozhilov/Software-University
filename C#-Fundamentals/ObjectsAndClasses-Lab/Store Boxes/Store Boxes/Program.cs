using System;
using System.Collections.Generic;

namespace Store_Boxes
{
    class Program
    {


        class Item
        {

            public string Name { get; set; }
            public decimal Price { get; set; }


        }

        class Box
        {


            public Box()
            {
                Item = new Item();
            }

            public int SerialNumber { get; set; }
            public Item Item { get; set; }
            public int ItemUality { get; set; }
            public decimal BoxPrice { get; set; }


            public decimal BoxCalcolator()
            {
                return ItemUality * Item.Price;
            }

        }


        static void SortMethod(List<Box> sortedList)
        {


            for (int i = 0; i < sortedList.Count; i++)
            {

                for (int j = 0; j < sortedList.Count; j++)
                {

                    if (sortedList[i].BoxPrice > sortedList[j].BoxPrice)
                    {

                        Box temp = sortedList[i];

                        sortedList[i] = sortedList[j];
                        sortedList[j] = temp;

                    }


                }


            }


        }

        static void Main(string[] args)
        {


            string text = string.Empty;


            List<Box> boxes = new List<Box>();


            while ((text = Console.ReadLine()) != "end")
            {

                string[] stringArray = text.Split();

                int currentSerialNumber = int.Parse(stringArray[0]);
                string currentItemName = stringArray[1];
                int currentItemUality = int.Parse(stringArray[2]);
                decimal currentItemPrice = decimal.Parse(stringArray[3]);


                Box currentBox = new Box();

                currentBox.SerialNumber = currentSerialNumber;
                currentBox.Item.Name = currentItemName;
                currentBox.ItemUality = currentItemUality;
                currentBox.Item.Price = currentItemPrice;

                currentBox.BoxPrice = currentBox.BoxCalcolator();


                boxes.Add(currentBox);

            }


            // Sort the list //

            SortMethod(boxes);

            foreach (Box items in boxes)
            {


                Console.WriteLine(items.SerialNumber);
                Console.WriteLine("-- {0} - ${1:F2}: {2}", items.Item.Name, items.Item.Price, items.ItemUality);
                Console.WriteLine("-- ${0:F2}", items.BoxPrice);

            }


        }
    }
}
