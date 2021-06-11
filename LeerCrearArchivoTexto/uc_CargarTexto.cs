using System;
using System.Data;
using System.IO;
using System.Text;


namespace LeerCrearArchivoTexto
{
  public  class uc_CargarTexto
    {

        public static DataTable TextoATabla(string archivo, char separador )
        {

            DataTable tabla = new DataTable();
        
            tabla.Columns.Add("Vigilancia", typeof(string));
            tabla.Columns.Add("idObligacion", typeof(string));
            tabla.Columns.Add("Ejercicio", typeof(string));  //DateTime
            tabla.Columns.Add("Periodo", typeof(string));
            tabla.Columns.Add("Regimen", typeof(string));
            tabla.Columns.Add("Nombre_Obligacion", typeof(string));
            tabla.Columns.Add("Nombre_Fundamento", typeof(string));
            tabla.Columns.Add("Fecha_Vencimiento", typeof(string));

            tabla.Columns.Add("idObligacionSH", typeof(string));
            tabla.Columns.Add("Usuario", typeof(string));
            tabla.Columns.Add("FechaCarga", typeof(DateTime));




            // https://msdn.microsoft.com/es-es/library/cc463982(v=vs.71).aspx



            if (File.Exists(archivo))
            {
                using (StreamReader sr = new StreamReader(archivo))
                {
                    string[] cabeceras = sr.ReadLine().Split(separador);
                    Console.WriteLine(cabeceras.Length);

                    DateTime Fecha = DateTime.Now;

                    // if (cabeceras != null && cabeceras.Length > 0)
                    //{
                    //    for (int i = 0; i < cabeceras.Length; i++)
                    //    {
                    //    tabla.Columns.Add(cabeceras[i], Type.GetType("System.String"));
                    //     }

                    DataRow fila = null;
                    string[] campos = null;
                    while (!sr.EndOfStream)
                    {
                        fila = tabla.NewRow();
                        campos = sr.ReadLine().Split(separador);
                        //     Console.WriteLine(campos.Length);

                        int j = 0;
                        string s = campos[0];
                        bool result = int.TryParse(s, out j); 
                        if (result)
                        {
                            if (campos != null && campos.Length > 0)
                            {
                                for (int i = 0; i < campos.Length; i++)
                                {
                                    fila[i] = campos[i];
                                }
                            }
                            tabla.Rows.Add(fila);
                        }

                    }
                    //}
                }
            }
            return (tabla);


        }



       


    }
}

