using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMaker_marin
{
    internal class StringManager
    {
        private string lastInput = "";
        public string Reverse(string s) 
        {
        this.lastInput = s;
        string anotherS = "";

        Stack<char> charStack = new Stack<char>();
        foreach(char c in s)
            {
                charStack.Push(c);
            }
        while(charStack.Count > 0)
            {
                anotherS += charStack.Pop();
            }
        return anotherS;
        
        }

    //    public string Tostring (string s)
    //    {

    //        //was not succesfull 
    //        int ASCII = 0;

    //       foreach(char c in s)
    //        {
    //            ASCII += (int)c;
    //        }
    //        return ASCII % 5;
        
    //}


        public string Reverse(string s,bool PreserveCaseLocation) {
            this.lastInput = s;   

            if(PreserveCaseLocation != true)
            {
                return Reverse(s);
            }

            Stack<int> index = new Stack<int>();

            Stack<char>  anotherChars= new Stack<char>();

            foreach (char c in s) 
            if(char.IsUpper(c) == true)
            {
                index.Push(s.IndexOf(c));
            }

            char[] myarray = (Reverse(s).ToLower().ToCharArray());

            while(index.Count > 0)
            {
                myarray[index.Peek()] = char.ToUpper(myarray[index.Pop()]);
            }
            return (string.Join("", myarray));

        }

        public bool Symetric(string s)
        {
            if (s == Reverse(s))
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        public override bool Equals(object obj)
        {
            return obj is string s && lastInput == s;
        }







        //    private string _s;
        //    private bool _preserveCaseLocation;
        //    public string Reverse(string s)
        //    {
        //        char[] myArr = s.ToCharArray();
        //        Array.Reverse(myArr);
        //        return new string(myArr);

        //    }

        //    public string Reverse(string s, bool preserveCaseLocation)
        //    {
        //        return Reverse(s, preserveCaseLocation);

        //    }

        //    public string s
        //    {
        //        get { return _s; }
        //    }



        //    public bool preserveCaseLocation
        //    {
        //        get { return _preserveCaseLocation; }

        //    }




        //    public StringManager(string s)
        //    {
        //        string _s = s;

        //    }

        //    public StringManager(string s, bool preserveCaseLocation)
        //    {
        //        string _s = s;
        //        bool _preserveCaseLocation = preserveCaseLocation;

        //}






        //    public override string ToString()
        //    {
        //        return base.ToString();
        //    }









    }
}
