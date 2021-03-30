using CommandPattern.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace CommandPattern.Core
{
    public class CommandInterpreter : ICommandInterpreter
    {

        private const string COMMAND_COM = "Command";

        public CommandInterpreter()
        {

        }


        public string Read(string args)
        {

            string[] commandTokens = args.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string command = commandTokens[0]+COMMAND_COM;
            string[] commandArgs = commandTokens.Skip(1).ToArray();

            Assembly assembly = Assembly.GetCallingAssembly();
            Type commandType = assembly.GetTypes().FirstOrDefault(x => x.Name.ToLower() == command.ToLower());

            if(commandType==null)
            {
                throw new ArgumentException("Invalid command type!");
            }

            ICommand commandIstance = (ICommand)Activator.CreateInstance(commandType);

            string result = commandIstance.Execute(commandArgs);

            return result;
        }
    }
}
