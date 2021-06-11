using System;
using System.Data;
using System.IO;
using System.Text;

namespace LeerCrearArchivoTexto
{
    public class ucTextoTabla
    {
        public static DataTable TextoATabla(string archivo, char separador, string Numerocarga, string Obligacion)
        {

            DataTable tabla = new DataTable();
            //    DataTable table = new DataTable();
            tabla.Columns.Add("ALSC", typeof(int));   //

            tabla.Columns.Add("RFC", typeof(string));
            tabla.Columns.Add("NO_CONTROL", typeof(string));
            tabla.Columns.Add("NOMBRE_COMPLETO", typeof(string));  //DateTime
            tabla.Columns.Add("CALLE", typeof(string));
            tabla.Columns.Add("NUM_EXT", typeof(string));
            tabla.Columns.Add("NUM_INT", typeof(string));
            tabla.Columns.Add("COLONIA", typeof(string));
            tabla.Columns.Add("LOCALIDAD", typeof(string));
            tabla.Columns.Add("REFERENCIA", typeof(string));

            tabla.Columns.Add("idObligacion01", typeof(Int32));
            tabla.Columns.Add("Ejercicio01", typeof(string));
            tabla.Columns.Add("Periodo01", typeof(string));
            tabla.Columns.Add("Regimen01", typeof(string));

            tabla.Columns.Add("idObligacion02", typeof(string));  // typeof(string));
            tabla.Columns.Add("Ejercicio02", typeof(string));
            tabla.Columns.Add("Periodo02", typeof(string));
            tabla.Columns.Add("Regimen02", typeof(string));

            tabla.Columns.Add("idObligacion03", typeof(string));
            tabla.Columns.Add("Ejercicio03", typeof(string));
            tabla.Columns.Add("Periodo03", typeof(string));
            tabla.Columns.Add("Regimen03", typeof(string));

            tabla.Columns.Add("idObligacion04", typeof(string));
            tabla.Columns.Add("Ejercicio04", typeof(string));
            tabla.Columns.Add("Periodo04", typeof(string));
            tabla.Columns.Add("Regimen04", typeof(string));

            tabla.Columns.Add("idObligacion05", typeof(string));
            tabla.Columns.Add("Ejercicio05", typeof(string));
            tabla.Columns.Add("Periodo05", typeof(string));
            tabla.Columns.Add("Regimen05", typeof(string));

            tabla.Columns.Add("idObligacion06", typeof(string));
            tabla.Columns.Add("Ejercicio06", typeof(string));
            tabla.Columns.Add("Periodo06", typeof(string));
            tabla.Columns.Add("Regimen06", typeof(string));

            tabla.Columns.Add("idObligacion07", typeof(string));
            tabla.Columns.Add("Ejercicio07", typeof(string));
            tabla.Columns.Add("Periodo07", typeof(string));
            tabla.Columns.Add("Regimen07", typeof(string));

            tabla.Columns.Add("idObligacion08", typeof(string));
            tabla.Columns.Add("Ejercicio08", typeof(string));
            tabla.Columns.Add("Periodo08", typeof(string));
            tabla.Columns.Add("Regimen08", typeof(string));

            tabla.Columns.Add("MEDIO_EVIO", typeof(int));
            tabla.Columns.Add("FECHA", typeof(DateTime));
            tabla.Columns.Add("CP", typeof(int));
            tabla.Columns.Add("idMunicipio", typeof(int));
            //tabla.Columns.Add("Dato", typeof(string));


            tabla.Columns.Add("idObligacion", typeof(int));
            tabla.Columns.Add("Ejercicio_Emision", typeof(int));
            tabla.Columns.Add("NoCarga", typeof(int));
            tabla.Columns.Add("idTakin", typeof(string));
            tabla.Columns.Add("idTakinMov", typeof(string));
            tabla.Columns.Add("idEstado", typeof(int));
            tabla.Columns.Add("idSolventacion", typeof(int));
            tabla.Columns.Add("idNoLocalizado", typeof(int));
            tabla.Columns.Add("Usuario", typeof(string));
            tabla.Columns.Add("FechaCarga", typeof(DateTime));

            // https://msdn.microsoft.com/es-es/library/cc463982(v=vs.71).aspx

            if (File.Exists(archivo))
            {
                using (StreamReader sr = new StreamReader(archivo))
                {
               //     string[] cabeceras = sr.ReadLine().Split(separador);
               //     Console.WriteLine(cabeceras.Length);

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
                       //     NumeroCampos = campos.Length;
                       //     Console.WriteLine(campos.Length);
                        int j = 0;
                        string s = campos[0];
                        bool result = int.TryParse(s, out j); //i now = 108  
                        if (result)
                        {
                            if (campos != null && campos.Length > 0)
                            {
                                for (int i = 0; i < campos.Length - 1; i++)
                                {
                                    fila[i] = campos[i];
                                }
                            }
                            tabla.Rows.Add(fila);
                        }
                     }
                    //frmPrueba form = new frmPrueba();
                    //form.lblColumnas.Text = NumeroCampos.ToString();
                }
            }
            return (tabla);
        }



        public static void TablaATexto(DataTable tabla, string archivo,char separador)
        {
            using(FileStream fs = new FileStream(archivo, FileMode.Create, FileAccess.Write, FileShare.Write))
            {
                using(StreamWriter sw = new StreamWriter(fs, Encoding.Default))
                {
                    //for(int i = 0;i< tabla.Columns.Count;i++)
                    //{
                    //    sw.Write(tabla.Columns[i].ColumnName);
                    //    if(i<tabla.Columns.Count - 1) sw.Write(separador);
                    //}
                   // sw.WriteLine();
                    for(int j = 0;j< tabla.Rows.Count;j++)
                    {
                        for(int i = 0;i< tabla.Columns.Count;i++)
                        {
                            sw.Write(tabla.Rows[j][i].ToString());
                            if(i<tabla.Columns.Count - 1) sw.Write(separador);
                        }
                        sw.Write(separador);
                        sw.WriteLine();
                    }
                }
            }
        }



    }
}
