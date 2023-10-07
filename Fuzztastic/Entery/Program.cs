// See https://aka.ms/new-console-template for more information
using Entery.IO;
using Fuzztastic.Expermintal;
using Fuzztastic.Workers.Workload;
using Sharprompt;

Console.WriteLine(@"
     ____                          __                     __                  
    /\  _`\                       /\ \__                 /\ \__  __           
    \ \ \L\_\__  __  ____    ____ \ \ ,_\    __      ____\ \ ,_\/\_\    ___   
     \ \  _\/\ \/\ \/\_ ,`\ /\_ ,`\\ \ \/  /'__`\   /',__\\ \ \/\/\ \  /'___\ 
      \ \ \/\ \ \_\ \/_/  /_\/_/  /_\ \ \_/\ \L\.\_/\__, `\\ \ \_\ \ \/\ \__/ 
       \ \_\ \ \____/ /\____\ /\____\\ \__\ \__/.\_\/\____/ \ \__\\ \_\ \____\
        \/_/  \/___/  \/____/ \/____/ \/__/\/__/\/_/\/___/   \/__/ \/_/\/____/
");

WorkloadGenerator.Generate(new Expermintal().GetDocument());

Console.WriteLine("\nBye!");

var isNewComer = Prompt.Select("Are you new to Fuzztastic?", new[] { "Yes!", "No!" });

if (isNewComer.Equals("Yes!"))
{
    Console.WriteLine(@"
        TODO: Show help command
    ");
}

var openAPILocation = "";

while (true)
{
    openAPILocation = Prompt.Input<string>("Enter OpenAPI file location:");

    if (OpenAPI.Exists(openAPILocation))
    {
        break;
    }

    Console.WriteLine($"OpenAPI file couldn't be found at location: {openAPILocation}");
}

Console.WriteLine($"OpenAPI file was found at location: {openAPILocation}");