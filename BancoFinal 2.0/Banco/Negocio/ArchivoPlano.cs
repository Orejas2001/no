using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;

namespace Banco.Negocio
{
    [Serializable]
    public static class ArchivoPlano
    {
        public static void write(string archivo, Banco banca)
        {
            try
            {
                FileStream file = new FileStream(archivo, FileMode.Create);
                new BinaryFormatter().Serialize(file, banca);
                file.Close();

            }
            catch (Exception e1)
            {
                throw e1;
            }
    }
        public static Banco read (string archivo)
        {
            Banco mibancote = new Banco();
            try
            {
                FileStream file = new FileStream(archivo, FileMode.Open);
                BinaryFormatter binary = new BinaryFormatter();
                mibancote = (Banco)binary.Deserialize(file);
                file.Close();
            } catch(Exception e2)
            {
                throw e2;
            }
            return mibancote;
            } 
        }
    }