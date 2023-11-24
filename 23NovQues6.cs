using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question6AsyncAwait
{
    class Program
    {
        static async Task Main(string[] args)
        {
            process1();
            Console.ReadKey();
        }
        static async void process1()
        {
            Console.WriteLine("Process Started");

            await Task.Delay(4000); // this holds execution for 4 seconds, so the next line of code will be executed after 4 seconds

            Console.WriteLine("Process Completed");

        }


        /*Justification:
        In this program, the main and process method are marked as async, 
        so now our program has become of asynchronous programming type. return type 
        of Main is Task. The main must be async in order to make child methods async
        await Task.Delay(4000) holds the thread for 4 seconds
        The async process1() method gets executed in a separate thread and the 
        main application thread continues execution of the next statement 
        and does not wait for the process1() to complete.
        */
    }
}
