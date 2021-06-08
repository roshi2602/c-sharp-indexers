using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//index allows object to be used like arrays
//indexers are special types of properties to store values in array


//through indexers we can check what kind of data we can store in array
namespace Indexers
{
    //make 1 class
    class Employee
    {
        //make 1 array
        //make variable private through encapsulation rule
        private int[] Next = new int[3];    //we can give value upto 0,1,2 not 3

        //now to make sure that the data going is valid or not we make indexer
        //for code written below write indexer and press tab twice
        //this is code for indexer(automatically came)
        public int this[int index]          //array is of int type    //we can use access modifiers with return type in indexers
        {
            get {
                return Next[index];
            }
            set {
                //now give condition using if in set
                //using nested if and applying check for index number not greater than array length and value is not gretaer than 0
                if(index >=0 && index < Next.Length)  //index should not be less than 0 and should be less that Next.Length i.e. 3
          //if both condition are true then go to inner if else
                 {
                    if (value > 0)
                    {
                        Next[index] = value;  //then set this value at array index number
                    }
                    else
                    {
                        Console.WriteLine("you are putting wrong value");
                    }
                }
                // both condition are false then go to else
            else
                        {
                    Console.WriteLine("invalid");
            }

            }
        }
    }
    class Program
    {
        static void Main()
        {
            //now make object for program class
            Employee em = new Employee();
            //object em will act as indexer now
            em[2] = 5; //store value= 5 at index 2       //this works according to if else condition
            Console.WriteLine(em[2]);
            Console.ReadLine();
        }
    }
}
