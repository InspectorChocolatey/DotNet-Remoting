using System;
using System.Collections.Generic;

namespace Client.Classes
{
    class CliMenu
    {
        public CliMenu()
        {

        }

        public List<string> GetLibraryClassList()
        {
            List<string> classList = new List<string>();
            classList.Add("MemberManager");
            classList.Add("ShowCapital");
            return classList;
        }

        public void DisplayListItems(List<string> itemList)
        {
            foreach (string item in itemList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
