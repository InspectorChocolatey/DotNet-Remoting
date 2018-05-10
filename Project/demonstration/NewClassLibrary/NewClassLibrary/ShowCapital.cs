using System;
using System.Data;

/*
 * references:
 *  https://www.youtube.com/watch?v=lJph_kKQTQA
 */

namespace NewClassLibrary
{
    public class ShowCapital : MarshalByRefObject
    {
        public ShowCapital()
        {

        }

        public string Show(string country)
        {
            if (country.ToLower() == "england")
            {
                return "London";
            }
            else if (country.ToLower() == "scotland")
            {
                return "Edinburgh";
            }
            else
            {
                return "Not known";
            }
        }
    }
}
