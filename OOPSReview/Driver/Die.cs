using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Driver
{
    // classes by default have a access privillege of private
    // you MYst add publick to your class
   public class Die
    {
        //create a new instance of the math object Random
        // this will be shared by each instance of Die
        // The instance of Random object will be created when
        // the first instance of die is created 
        private static Random _rnd = new Random();

        //classes have 
        // a) data members -- may be private for the class for use only within the class
        // b) proterties
        // b) constructors
        // c) behaviours (methods)

        //data members -- may be private for the class for use only within the class
        // the interface with a class is done via proterties and behaviours 

        //proterties 
        //can be fully implemented
        //   a- private data member 
        //   a - public property 
        private int _Sides; 
        public int Sides
        {
            get
            {
                // this will return the private data memer 
                return _Sides;
                
            }
            set
            {
                // the reserved ket word "value" is used to
                // obtain the incoming data value to the property
                //save the incoming date value to your private
                // data member
                _Sides = value;
            }
        }

        //can be auto implemented
        // does not have a private member
        // the system creates and internal data storage member 
        // for the property 

        public int FaceValue { get; set; }
    }
}
