using System;

namespace Open_Lab_03._06
{
    public class Checker
    {
        public bool HasSpaces(string str)
        {
            for (int i = 0; i < str.length; i++){
                if(str[i]==' '){

                    return true;
                }
			}
            return false;
          
       
        } 
    }
}
