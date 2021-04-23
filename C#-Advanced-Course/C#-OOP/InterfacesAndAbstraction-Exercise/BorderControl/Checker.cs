using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
   public abstract class Checker
    {



        public string Id { get; set; }


        public string Validation(string id,string currentId)
        {
            if (id.Contains(currentId))
            {

                int lastIndex = id.LastIndexOf(currentId);
                string currentString = id.Substring(lastIndex, currentId.Length);
                lastIndex += currentId.Length;

                if (lastIndex == id.Length && currentString == currentId)
                {
                    return id;
                }

            }


            return "false";
        }


    }
}
