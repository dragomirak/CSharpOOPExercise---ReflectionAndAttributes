using CommandPattern.Core.Contracts;
using System;


namespace CommandPattern.Engines;

public class Engine : IEngine
{
    private readonly ICommandInterpreter commandInterpreter;

    public Engine(ICommandInterpreter commandInterpreter)
    {
        this.commandInterpreter = commandInterpreter;
    }

    public void Run()
    {
        while (true)
        {
            string input = Console.ReadLine();
            string result = string.Empty;

            try
            {
                result = commandInterpreter.Read(input);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }

            Console.WriteLine(result);



        }
    }
}
