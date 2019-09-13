using System;

namespace ArregloObjetos_G4
{
    class Program
    {
        static void Main()
        {
            

            Chocolate[] chocolateArr = new Chocolate[3];
            Chocolate CarlosV = new Chocolate();
            CarlosV.Sabor = "Amargo";
            CarlosV.Nombre = "Carlos V";
            chocolateArr[0] = CarlosV;

            Chocolate Crunch = new Chocolate();
            Crunch.Sabor = "Vainilla";
            Crunch.Nombre = "Crunch";
            chocolateArr[1] = Crunch;

            Chocolate Cacep = new Chocolate();
            Cacep.Sabor = "Semi-Amargo";
            Cacep.Nombre = "Cacep";
            chocolateArr[2] = Cacep;
            bool validaError = false; ;
            do
            {
                try
                {
                    validaError = false;
                    Console.Clear();
                    for (int i = 0; i < chocolateArr.Length; i++)
                    {

                        Console.WriteLine(" Nombre: {0} \n Sabor: {1} \n", chocolateArr[i].Nombre, chocolateArr[i].Sabor);
                        Console.WriteLine("Ingresa el precio del chocolate");
                        chocolateArr[i].Precio = float.Parse(Console.ReadLine());
                        if (chocolateArr[i].Precio <= 0)
                        {
                            throw new ApplicationException("El precio debe ser mayor a cero");
                        }

                        Console.WriteLine("Precio {0}", chocolateArr[i].Precio);
                    }

                }

                catch (ApplicationException error)
                {
                    validaError = true;
                    Console.WriteLine(error.Message);
                }

                catch (IndexOutOfRangeException error)
                {
                    validaError = true;
                    Console.WriteLine(error.Message);
                }
                catch (FormatException)
                {
                    validaError = true;
                    Console.WriteLine("No se ingresó un número");
                }
                catch
                {
                    validaError = true;
                    Console.WriteLine("Hubo un error");
                }


            } while (validaError);
            


        }
    }
}
