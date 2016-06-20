using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 
namespace ValidArrayInputs {
    class Program {
        static void Main(string[] args) {
            // iniciate array
            int[] yourArray = new int[99];
            yourArray = FillArray(yourArray);          
            int validEntries = yourArray[98];
            int entries = yourArray[96];
            Console.WriteLine("There were {0} valid entries and {1} invalid antries.", yourArray[98], yourArray[97]);
            DisplayArray(yourArray);
            DisplayValidEntries(yourArray, entries);
            Console.ReadKey();
            

        }
        public static int[] FillArray(int[] array) {
            bool finish = false;
            int entries = 0;
            int valid = 0;
            int invalid = 0;
            // message
            Console.WriteLine("Enter array elements:\nEnter -99 to finish Array:\n");

            for (int i = 0; i < 99; i++) {                               
                // loop to fill array
                while (finish != true) {
                    // fill array
                    int entry;
                    entry = Int32.Parse(Console.ReadLine());
                    if (entry == -99) {
                        finish = true;
                    } else {
                        array[i] = entry;
                    }
                    if(array[i] < 0 || array[i] > 10) {
                        invalid++;
                    }
                    entries++;
                    //// finish array
                    //if (array[i] == -99) {
                    //    finish = true;
                    //}
                    valid = (entries - invalid); 
                }
                array[98] = valid;
                array[97] = invalid;
                array[96] = entries;
            }
            return array;
           
                
        //}
        //public static int[] CheckValid(int[] array) {
        //    int valid = 0;
        //    int invalid = 0;
        //    for (int i = 0; i < array.Length; i++) {
        //        if (array[i] > -1 || array[i] < 11) {
        //            valid++;
        //        } else {
        //            invalid++;
        //        }
        //    }
            //return array;
        }      
        public static void DisplayValidEntries(int[] array, int entries) {
            Console.WriteLine("Valid entries are:");
            for (int i = 0; i < (entries-1); i++) {
                if(array[i] > -1 && array[i] < 11) {
                    Console.Write(array[i] + " ");
                }
            }
        }
        public static void DisplayArray(int[] array) {
            for(int i = 0; i < array.Length; i++) {
                Console.Write(array[i] + " ");
            }
        } 
    }
}
