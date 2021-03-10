using IEnumerableIEnumeratorLibrary;
using OOPLibrary;
using IQueryableLibrary;
using IComparableLibrary;
using System;
using SpeedBoxingUnboxingLibrary;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            bool key = true;
            while (key)
            {
                Console.WriteLine(" 1: OOPLibrary \n 2: ShowIEnumerableIEnumeratorLibrary" +
                    "\n 3: IComparableLibrary \n 4:BoxingUnboxingLibrary \n 5:IQueryableLibrary");

                switch (Console.ReadLine())
                {
                    case "1":
                        OOPResult.ShowOOP();
                        break;
                    case "2":
                        IEnumeratorResult.ShowIEnumerableIEnumerator();
                        break;
                    case "3":
                        IComparableResult.ShowIComporable();
                        break;
                    default:
                        key = false;
                        break;
                    case "4":
                        BoxingUnboxing.ShowBoxingUnboxing();
                        break;
                    case "5":
                        IQueryableProgram.IQueryableRun();
                        break;
                }

            } 
        
        }
    }
}
