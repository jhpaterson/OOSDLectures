using System;
using System.IO;
using System.Diagnostics;

namespace SimpleExceptions
{
    public class InfoSaver
    {
        public void SaveInfo1(string data, string filename)
        {
            // file doesn't exist, so trying to open it like this will cause exception
            FileStream fs = File.Open(filename, FileMode.Open);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(data);
            sw.Close();
        }


        public void SaveInfo2(string data, string filename)
        {
            try
            {
                FileStream fs = File.Open(filename, FileMode.Open);
                StreamWriter sw = new StreamWriter(fs);
                sw.Write(data);
                sw.Close();
            }
            catch (FileNotFoundException fnfex)
            {
                Console.WriteLine("File does not exist: {0}\n", 
                    fnfex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected exception:{0}\n", 
                    ex.Message);
            }
        }

        public void SaveInfo3(string data, string filename)
        {
            StreamWriter sw = null;
            try
            {
                FileStream fs = File.Open(filename, FileMode.Open);
                sw = new StreamWriter(fs);
                sw.Write(data);
                sw.Close();
            }
            catch (FileNotFoundException fnfex)
            {
                Console.WriteLine("File does not exist: {0}\n", 
                    fnfex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected exception:{0}\n", 
                    ex.Message);
            }
            finally
            {
                if (sw != null)
                {
                    sw.Close();
                }
            }
        }

        public void SaveInfo4(string data, string filename)
        {
            StreamWriter sw = null;
            try
            {
                FileStream fs = File.Open(filename, FileMode.Open);
                sw = new StreamWriter(fs);
                sw.Write(data);
                sw.Close();
            }
            catch (FileNotFoundException fnfex)
            {
                Debug.WriteLine("File does not exist: {0}\n", 
                    fnfex.Message);
                throw new Exception(
                    "Something happened - you deal with it!\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected exception:{0}\n", ex.Message);
            }
            finally
            {
                if (sw != null)
                {
                    sw.Close();
                }
            }
        }

        public void SaveInfo5(string data, string filename)
        {
            // this creates file if it doesn't exist, so opening it won't cause an exception
            FileStream fs = File.Open(filename, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(data);
            int x = 0;
            int y = 1 / x;   // create an exception
            sw.Close();
        }

        public void SaveInfo6(string data, string filename)
        {
            FileStream fs = File.Open(filename, FileMode.Create);

            using (StreamWriter sw = new StreamWriter(fs))
            {
                sw.Write(data);
                int x = 0;
                int y = 1 / x;   // create an exception
                sw.Close();
            }
        }
    }
}
