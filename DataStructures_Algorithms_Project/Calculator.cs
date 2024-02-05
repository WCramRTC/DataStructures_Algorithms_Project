using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_Algorithms_Project
{

    /*
     * This is an example class used to demonstrate how the unit test is setup to work
     * Open the Test Explorer
     *  - View -> Test Explorer
     *  - Ctrl + E, T
     *  
     *  You should see a series of names which would be unit tests
     *  Try running them by clicking on the double arrow above the names. 
     *  Is is the button located all the way to the left.
     *  
     *  If you just got started you might see a lot of red, that's fine. Your code will change that.
     *  Find a Test Group calle Basic Test and click the little arrow next to it
     *  You should see text names for the methods below, and some of them are showing up green.
     *  That is because the methods assoicated with the tests are correctly written.
     *  
     *  You should see the SubtractionTest as red. Let's fix that
     *  In this class go to the Subtract method and fix the return value to say a - b.
     *  Save, then click double arrow again. It should now turn green.
     *  
     *  This is an example of how the test in the project work for each class.
     *  
     *  As you fill in the code for the methods, your test will turn green as they work.
     */

    public class Calculator
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            // Uncomment this so it says "return a - b;"
            return a /*- b*/;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static double Divide(double a, double b)
        {
            if (b == 0)
                throw new System.DivideByZeroException();

            return a / b;
        }
    }

}
