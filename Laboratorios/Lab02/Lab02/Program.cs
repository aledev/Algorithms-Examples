using Lab02.Clases;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    class Program
    {
        static void Main(string[] args)
        {
            int aux = -1;

            while (aux != 0)
            {
                Console.Clear();
                Console.WriteLine("Que lista desea utilizar?");
                Console.WriteLine("1) Lista Ordenada 10000 datos \n" +
                    "2) Lista Ordenada 20000 datos \n" +
                    "3) Lista Ordenada 50000 datos \n" +
                    "4) Lista Ordenada 100000 datos \n" +
                    "5) Lista Ordenada 200000 datos \n" +
                    "6) Lista Ordenada 500000 datos \n" +
                    "7) Lista Desordenada 10000 datos \n" +
                    "8) Lista Desordenada 20000 datos \n" +
                    "9) Lista Desordenada 50000 datos \n" +
                    "10) Lista Desordenada 100000 datos \n" +
                    "11) Lista Desordenada 200000 datos \n" +
                    "12) Lista Desordenada 500000 datos \n" +
                    "0) Salir \n");

                string menu = Console.ReadLine();
                aux = int.Parse(menu);

                List<PersonaDTO> lstDatos = new List<PersonaDTO>();
                string _path = string.Empty;

                if (aux == 1)
                    _path = System.IO.Directory.GetCurrentDirectory() + "\\Data\\data_10000_ord.json";
                else if(aux == 2)
                    _path = System.IO.Directory.GetCurrentDirectory() + "\\Data\\data_20000_ord.json";
                else if (aux == 3)
                    _path = System.IO.Directory.GetCurrentDirectory() + "\\Data\\data_50000_ord.json";
                else if (aux == 4)
                    _path = System.IO.Directory.GetCurrentDirectory() + "\\Data\\data_100000_ord.json";
                else if (aux == 5)
                    _path = System.IO.Directory.GetCurrentDirectory() + "\\Data\\data_200000_ord.json";
                else if (aux == 6)
                    _path = System.IO.Directory.GetCurrentDirectory() + "\\Data\\data_500000_ord.json";
                else if (aux == 7)
                    _path = System.IO.Directory.GetCurrentDirectory() + "\\Data\\data_10000_des.json";
                else if (aux == 8)
                    _path = System.IO.Directory.GetCurrentDirectory() + "\\Data\\data_20000_des.json";
                else if (aux == 9)
                    _path = System.IO.Directory.GetCurrentDirectory() + "\\Data\\data_50000_des.json";
                else if (aux == 10)
                    _path = System.IO.Directory.GetCurrentDirectory() + "\\Data\\data_100000_des.json";
                else if (aux == 11)
                    _path = System.IO.Directory.GetCurrentDirectory() + "\\Data\\data_200000_des.json";
                else if (aux == 12)
                    _path = System.IO.Directory.GetCurrentDirectory() + "\\Data\\data_500000_des.json";

                Console.Write("Cargando datos...");
                lstDatos = JsonConvert.DeserializeObject<List<PersonaDTO>>(System.IO.File.ReadAllText(_path));
                Console.WriteLine("Carga Ok. {0} datos encontrados.", lstDatos.Count());

                if (aux != 0)
                {
                    int auxInnerMenu = 0;

                    while (auxInnerMenu != 9)
                    {
                        Console.WriteLine("Que tipo de algoritmo de ordenamiento desea utilizar?");
                        Console.WriteLine("1) Ordenamiento por Inserción (InsertionSort) \n" +
                            "2) Ordenamiento Burbuja (BubbleSort) \n" +
                            "3) Ordenamiento Selección (SelectionSort) \n" + 
                            "4) Ordenamiento por Mezcla (MergeSort) \n" +
                            "5) Ordenamiento Rápido (QuickSort) \n" +
                            "6) Ordenamiento por Montículos (HeapSort) \n" +
                            "9) Salir \n");

                        string innerMenu = Console.ReadLine();
                        auxInnerMenu = int.Parse(innerMenu);

                        if (auxInnerMenu == 1)
                        {
                            DateTime fchInicio = DateTime.Now;

                            Console.WriteLine("Ordenando Datos...");

                            Algoritmos.OrdenamientoInsercion(lstDatos.ToArray());

                            Console.WriteLine("Ordenamiento Completado!");

                            DateTime fchTermino = DateTime.Now;
                            var tiempoDemora = (fchTermino - fchInicio).TotalMilliseconds.ToString();

                            Console.WriteLine("El proceso se demoró: {0} milisegundos", tiempoDemora);
                            Console.ReadLine();
                        }
                        else if (auxInnerMenu == 2)
                        {
                            DateTime fchInicio = DateTime.Now;

                            Console.WriteLine("Ordenando Datos...");

                            Algoritmos.OrdenamientoBurbuja(lstDatos.ToArray());

                            Console.WriteLine("Ordenamiento Completado!");

                            DateTime fchTermino = DateTime.Now;
                            var tiempoDemora = (fchTermino - fchInicio).TotalMilliseconds.ToString();

                            Console.WriteLine("El proceso se demoró: {0} milisegundos", tiempoDemora);
                            Console.ReadLine();
                        }
                        else if (auxInnerMenu == 3)
                        {
                            DateTime fchInicio = DateTime.Now;

                            Console.WriteLine("Ordenando Datos...");

                            Algoritmos.OrdenamientoSeleccion(lstDatos.ToArray());

                            Console.WriteLine("Ordenamiento Completado!");

                            DateTime fchTermino = DateTime.Now;
                            var tiempoDemora = (fchTermino - fchInicio).TotalMilliseconds.ToString();

                            Console.WriteLine("El proceso se demoró: {0} milisegundos", tiempoDemora);
                            Console.ReadLine();
                        }
                        else if (auxInnerMenu == 4)
                        {
                            DateTime fchInicio = DateTime.Now;

                            Console.WriteLine("Ordenando Datos...");

                            Algoritmos.OrdenamientoMezcla(lstDatos.ToArray(), 0, lstDatos.Count() - 1);

                            Console.WriteLine("Ordenamiento Completado!");

                            DateTime fchTermino = DateTime.Now;
                            var tiempoDemora = (fchTermino - fchInicio).TotalMilliseconds.ToString();

                            Console.WriteLine("El proceso se demoró: {0} milisegundos", tiempoDemora);
                            Console.ReadLine();
                        }
                        else if (auxInnerMenu == 5)
                        {
                            DateTime fchInicio = DateTime.Now;

                            Console.WriteLine("Ordenando Datos...");

                            Algoritmos.OrdenamientoRapido(lstDatos.ToArray(), 0, lstDatos.Count() - 1);

                            Console.WriteLine("Ordenamiento Completado!");

                            DateTime fchTermino = DateTime.Now;
                            var tiempoDemora = (fchTermino - fchInicio).TotalMilliseconds.ToString();

                            Console.WriteLine("El proceso se demoró: {0} milisegundos", tiempoDemora);
                            Console.ReadLine();
                        }
                        else if (auxInnerMenu == 6)
                        {
                            DateTime fchInicio = DateTime.Now;

                            Console.WriteLine("Ordenando Datos...");

                            Algoritmos.OrdenamientoMonticulos(lstDatos.ToArray(), lstDatos.Count() - 1);

                            Console.WriteLine("Ordenamiento Completado!");

                            DateTime fchTermino = DateTime.Now;
                            var tiempoDemora = (fchTermino - fchInicio).TotalMilliseconds.ToString();

                            Console.WriteLine("El proceso se demoró: {0} milisegundos", tiempoDemora);
                            Console.ReadLine();
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
        }

        public static void GenerarData()
        {
            int auxData = 0;
            int[] limits = { 20000, 500000, 1000000 };
            string[] ordenes = { "ord", "des" };
            Random rdm = new Random();

            foreach (var limit in limits)
            {
                foreach (var orden in ordenes)
                {
                    List<PersonaDTO> lstDataPersona = new List<PersonaDTO>();

                    if (orden == "ord")
                    {
                        auxData = 1;

                        while (auxData <= limit)
                        {
                            lstDataPersona.Add(new PersonaDTO
                            {
                                Id = auxData,
                                Nombre = "Persona " + auxData
                            });

                            auxData++;
                        }

                        var stringJson = JsonConvert.SerializeObject(lstDataPersona);
                        System.IO.File.WriteAllText(@"D:\Develop\Algorithms-Examples\data\data_" + limit + "_" + orden + ".json", stringJson);
                    }
                    else
                    {
                        auxData = 1;

                        while (auxData <= limit)
                        {
                            var cryptoResult = new byte[4];
                            new System.Security.Cryptography.RNGCryptoServiceProvider().GetBytes(cryptoResult);
                            int seed = BitConverter.ToInt32(cryptoResult, 0);
                            rdm = new Random(seed);

                            int id = rdm.Next(1, 999999999);

                            if (lstDataPersona.Where(d => d.Id == id).Count() == 0)
                            {
                                lstDataPersona.Add(new PersonaDTO
                                {
                                    Id = id,
                                    Nombre = "Persona " + id
                                });

                                auxData++;
                            }
                        }

                        var stringJson = JsonConvert.SerializeObject(lstDataPersona);
                        System.IO.File.WriteAllText(@"D:\Develop\Algorithms-Examples\data\data_" + limit + "_" + orden + ".json", stringJson);
                    }
                }
            }
        }
    }
}
