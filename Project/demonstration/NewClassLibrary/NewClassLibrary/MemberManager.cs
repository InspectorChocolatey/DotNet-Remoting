using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace NewClassLibrary
{
    public class MemberManager : MarshalByRefObject
    {
        public MemberManager()
        {

        }

        public PropertyInfo[] GetMembers(Object obj)
        {
            PropertyInfo[] propertyInfos = obj.GetType().GetProperties();
            return propertyInfos;
        }

        public int GetMemberCount(Object obj)
        {
            int memberCount = obj.GetType().GetRuntimeProperties().Count();
            return memberCount;
        }

        public MethodInfo[] GetMethods(Object obj)
        {
            MethodInfo[] methodInfos = obj.GetType().GetMethods();
            return methodInfos;
        }

        public void ShowInfos(Object obj)
        {
            Console.WriteLine("Object: ", obj.ToString());
            Console.WriteLine();
            Console.WriteLine("Methods: ");
            MethodInfo[] methodInfos = GetMethods(obj);
            foreach (MethodInfo methodInfo in methodInfos)
            {
                Console.WriteLine(methodInfo.Name);
            }
            Console.WriteLine();

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
