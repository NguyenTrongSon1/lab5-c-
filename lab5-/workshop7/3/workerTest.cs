using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class workerTest
    {
        static void Main(string[] args)
        {
            worker ojbWorkers = new worker();
            if (ojbWorkers.InputDetails())
            {
                ojbWorkers.DisplayDetails();
            }
        }
    }
}
