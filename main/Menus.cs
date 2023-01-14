namespace Classes;
using System.Text;
using System.Text.Json;
using Spectre.Console;
class Menus
{


    public static void showMainMenu()
    {
        AnsiConsole.Write(new Markup("[bold green] Menu principal[/] "));
        Console.WriteLine("");
        AnsiConsole.Write(new Markup("[bold white]0 - Marcas[/] "));
        Console.WriteLine("");
        AnsiConsole.Write(new Markup("[bold white]1 - Productos[/] "));
        Console.WriteLine("");

        
    }
    public static void showMarcaMenu()
    {
        AnsiConsole.Write(new Markup("[bold Green] Menú de Marcas[/] "));
         Console.WriteLine("");
        AnsiConsole.Write(new Markup("[bold white]0 - Listar Marcas[/] "));
         Console.WriteLine("");
        AnsiConsole.Write(new Markup("[bold white]1 - Insertar Marcas[/] "));
         Console.WriteLine("");
        AnsiConsole.Write(new Markup("[bold white]2 - Cambiar Marcas[/] "));
         Console.WriteLine("");
        AnsiConsole.Write(new Markup("[bold red]3 - Elija 3 para poder salir[/] "));

    }
       public static void showZapatillaMenu()
    {
        AnsiConsole.Write(new Markup("[bold Green] Menú de zapatillas[/] "));
         Console.WriteLine("");
        AnsiConsole.Write(new Markup("[bold white]0 - Listar zapatillas[/] "));
         Console.WriteLine("");
        AnsiConsole.Write(new Markup("[bold white]1 - Insertar zapatillas[/] "));
         Console.WriteLine("");
        AnsiConsole.Write(new Markup("[bold white]2 - ¿Queda stock[/] "));
 Console.WriteLine("");
        AnsiConsole.Write(new Markup("[bold red]3 - Elija 3 para poder salir[/] "));

    }
    
}