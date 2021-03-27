using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Stealer
{
   public class Spy
    {


        public string StealFieldInfo(string className , params string[] fields)
        {

            Type getClass = Type.GetType(className);

            StringBuilder builder = new StringBuilder();

            FieldInfo[] currentFields = getClass.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);

            object classIstance = Activator.CreateInstance(getClass, new object[] { });

            builder.AppendLine($"Class under investigation: {getClass.Name}");


            foreach(var items in currentFields)
            {

                foreach(var item in fields)
                {

                    if(items.Name==item)
                    {
                        builder.AppendLine($"{items.Name} = {items.GetValue(classIstance)}");
                    }

                }


            }


            return builder.ToString().TrimEnd();
        }

    }
}
