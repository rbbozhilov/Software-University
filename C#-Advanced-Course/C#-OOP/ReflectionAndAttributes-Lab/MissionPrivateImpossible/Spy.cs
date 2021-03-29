using System;
using System.Collections.Generic;
using System.Linq;
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


        public string AnalyzeAcessModifiers(string className)
        {

            Type type = Type.GetType(className);
            StringBuilder builder = new StringBuilder();
            var fields = type.GetFields(BindingFlags.Public | BindingFlags.Instance  | BindingFlags.Static);
            var publicMethods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance );
            var nonPublicMethods = type.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);


            foreach (var items in fields)
            {

               
                    builder.AppendLine($"{items.Name} must be private!");
                

            }

         
            foreach(var items in nonPublicMethods.Where(x=>x.Name.StartsWith("get")))
            {
                builder.AppendLine($"{items.Name} have to be public!");
            }

            foreach (var items in publicMethods.Where(x => x.Name.StartsWith("set")))
            {
                builder.AppendLine($"{items.Name} have to be private!");
            }


            return builder.ToString().TrimEnd();
        }


       public string RevealPrivateMethods(string className)
        {

            Type type = Type.GetType(className);
            StringBuilder builder = new StringBuilder();

            builder.AppendLine($"All Private Methods of Class: {type.FullName}");
            builder.AppendLine($"Base Class: {type.BaseType}");

            var privateMethods = type.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

            foreach(var items in privateMethods)
            {
                builder.AppendLine(items.Name);
            }


            return builder.ToString().TrimEnd();
        }

    }
}
