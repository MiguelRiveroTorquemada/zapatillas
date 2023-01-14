using Classes;
using System.Text.Json;
using Newtonsoft.Json;
using System.Text.Json.Serialization;
using Spectre.Console;


MarcaRepository marcas = new MarcaRepository();
static void listMarcas(MarcaRepository marcas)
{
    List<Marca> allMarcas = marcas.all();
    foreach (Marca individualMarca in allMarcas)
    {
        Console.WriteLine(individualMarca.Summary());
    }
}

ZapatillaRepository zapatillas = new ZapatillaRepository();
static void listZapatilla(ZapatillaRepository zapatillas)
{
    List<Zapatilla> allZapatillas = zapatillas.all();
    foreach (Zapatilla individualZapatilla in allZapatillas)
    {
        Console.WriteLine(individualZapatilla.Summary());
    }

}


var table = new Table();



bool mainExit = false;
do
{
    Menus.showMainMenu();

    switch (Asker.askInteger("escoja una opcion"))
    {
        case 0:
            bool marcaExit = false;
            do
            {
                Menus.showMarcaMenu();
                switch (Asker.askInteger("escoja una opcion"))
                {
                    case 0:
                        listMarcas(marcas);
                        break;
                    case 1:
                        try
                        {
                            string name = Asker.askString("Nombre del marca nuevo: ");
                            bool gender = Asker.askBool("Introduzca el genero MASCULINO TRUE,FEMENINO FALSE de la marca");
                            DateTime fechaAlta = Asker.askDate("Introduzca el la fecha de alta ");
                            decimal tallas = Asker.askDecimal("Introduzca la talla en numero de la zapatilla ");
                            int tipos = Asker.askInteger("Introduzca el numero marcas");
                            Marca newMarca = new Marca(name, gender, fechaAlta, tallas, tipos);
                            marcas.create(newMarca);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("ha habido un error");
                        }
                        break;
                    case 2:


                        try
                        {
                            string marcaNameToChange = Asker.askString("Nombre de la zapatilla para cambiar si es para mujer o hombre: ");
                            Marca marcaToChange = marcas.find(marcaNameToChange);
                            marcaToChange.ChangeGender();
                        }
                        catch (Exception ex)
                        {
                             AnsiConsole.Write(new Markup(" [red]No has escrito bien el nombre de la  marca[/] "));
                        }
                        break;

                        



                    default:
                        marcaExit = true;
                        break;
                }
            } while (!marcaExit);
            break;
        case 1:
            bool zapatillaExit = false;
            do

            {
                Menus.showZapatillaMenu();
                switch (Asker.askInteger("escoja una opcion"))
                {
                    case 0:


                        listZapatilla(zapatillas);
                        break;

                    case 1:

                        try
                        {
                            string name = Asker.askString("identificador de zapatilla: ");
                            string nameZapatilla = Asker.askString("nombre de la zapatilla: ");
                            bool quedanZapatillas = Asker.askBool("Introduzca si quedan zapatillas");
                            DateTime fechaAlta = Asker.askDate("Introduzca el la fecha de alta ");
                            decimal price = Asker.askDecimal("Introduzca el precio ");
                            int stock = Asker.askInteger("Introduzca la cantidad la cantidad de zapatillas");
                            Zapatilla newProduct = new Zapatilla(name, nameZapatilla, quedanZapatillas, fechaAlta, price, stock);
                            zapatillas.create(newProduct);
                        }
                        catch (Exception ex)
                        {
                            AnsiConsole.Write(new Markup(" [red]ha habido un error![/]"));

                        }
                        break;
                    case 2:
                        try
                        {

                            string ZapatillaNameToChange = Asker.askString("Nombre de la zapatilla para cambiar el la cantidad de stock: ");
                            Zapatilla zapatillaToChange = zapatillas.find(ZapatillaNameToChange);
                            zapatillaToChange.ChangeGender();
                        }
                        catch (Exception ex)
                        {
                             AnsiConsole.Write(new Markup(" [red]No has escrito bien el nombre de la zapatilla[/] "));
                        }
                        break;



                    default:
                        zapatillaExit = true;
                        break;
                }

            } while (!zapatillaExit);
            break;

    }

} while (!mainExit);







