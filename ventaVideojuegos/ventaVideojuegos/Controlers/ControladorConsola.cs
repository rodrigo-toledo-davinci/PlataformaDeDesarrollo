using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ventaVideojuegos.Modelo;

namespace ventaVideojuegos
{
    public class ControladorConsola
    {
        public static List<Consola> Consolas { get; set; }
        public static int lastId = 0;


        public static void IniciarRepositorio()
        {
            Consolas = new List<Consola>();

            if (!File.Exists("consolas.txt"))
            {
                StreamWriter archivo = new StreamWriter("consolas.txt");
            }
            else
            {
                StreamReader archivo = new StreamReader("consolas.txt");
                while (!archivo.EndOfStream)
                {
                    string consola = archivo.ReadLine();
                    string[] datos = consola.Split(',');
                    Consola cat = new Consola()
                    {
                        Id = int.Parse(datos[0]),
                        Nombre = datos[1],
                        Vista = bool.Parse(datos[2])
                    };

                    Consolas.Add(cat);
                    lastId = int.Parse(datos[0]);
                }
                archivo.Close();
            }

        }

        public static void AñadirConsola(Consola con)
        {
            Consolas.Add(con);
            lastId++;
            GuardarEnMemoria(con);
        }

        public static Consola GetConsolaByName(string name)
        {
            Consola con = Consolas.FirstOrDefault(x => x.Nombre == name);
            return con;
        }

        public static Consola GetConsolaById(int id)
        {
            Consola con = Consolas.FirstOrDefault(x => x.Id == id);
            return con;
        }

        public static void EliminarConsola(int id)
        {
            Consola con = Consolas.FirstOrDefault(c => c.Id == id);
            con.Vista = false;
            ActualizarConsola(id, con);
        }

        public static void ActualizarConsola(int id, Consola con)
        {
            int index = Consolas.FindIndex(e => e.Id.Equals(id));
            if (index != -1)
            {
                Consolas[index] = con;
            }
            GuardarEnMemoriaLista();
        }

        private static void GuardarEnMemoria(Consola con)
        {
            StreamWriter archivo = new StreamWriter("consolas.txt", true);
            archivo.WriteLine(con.Id + "," + con.Nombre + "," + con.Vista);
            archivo.Close();
        }

        private static void GuardarEnMemoriaLista()
        {
            StreamWriter archivo = new StreamWriter("consolas.txt");
            foreach (Consola con in Consolas)
            {
                archivo.WriteLine(con.Id + "," + con.Nombre + "," + con.Vista);
            }
            archivo.Close();
        }

        public static ListaConsola ListaConsola
        {
            get
            {
                if (_listaCon == null)
                {
                    _listaCon = new ListaConsola();

                    if (!File.Exists("consolas.txt"))
                    {
                        StreamWriter archivoNuevo = new StreamWriter("consolas.txt");
                        archivoNuevo.Close();
                    }
                    else
                    {
                        StreamReader archivo = new StreamReader("consolas.txt");
                        while (!archivo.EndOfStream)
                        {
                            string id = archivo.ReadLine();
                            string nombre = archivo.ReadLine();
                            string vista = archivo.ReadLine();


                            Consola con = new Consola()
                            {
                                Id = int.Parse(id),
                                Nombre = nombre,
                                Vista = bool.Parse(vista)
                            };

                            _listaCon.GuardarEnInstancia(con);
                        }
                        archivo.Close();
                    }

                }
                return _listaCon;
            }
        }

        private static ListaConsola _listaCon;

    }
}
