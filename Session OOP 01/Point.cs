using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_OOP_01
{
    internal struct Point
    {
        //What You Can Write Inside The Struct Or Class

        // 1. Attributes[Fields] => Member Variable  

        public int x;
        public int y;


        // 2. Functions[Constructor, Getter Setter, Method]
        #region Constructor

        // Constructor => A Special type of Function
        // 1. Always Named With Same Name of Struct or Class 
        // 2. Has no Return



        // By Default => Compiler Will Always Generate ParameterLess Constructor 
        // That Initialize Attributes of Struct With Default Value of its Database 

        public Point()
        {
            x = 1;
            y = 2;
            // Valid from C# 10 .net 6.0 
        }

        // 3. Properties[Full Property, Automatic Property, Indexer]
        // 4. Events

        //   Access Modifier Allowed Inside Struct?
        //1. Private[Default]
        //2. Internal
        //3. Public 
        #endregion

        #region Method 
        public override string ToString()
        {
            return $"({this.x} , {this.y})";
        }
        #endregion

    }
}
