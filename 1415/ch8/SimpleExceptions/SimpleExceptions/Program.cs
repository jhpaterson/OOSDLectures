using System;
using System.IO;


namespace SimpleExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            InfoSaver info = new InfoSaver();

            // call method with no exception handling
            // info.SaveInfo1("some data", "myfile");

            // call method with try-catch
            info.SaveInfo2("some data", "myfile");

            // call method with try-catch-finally
            info.SaveInfo3("some data", "myfile");

            // call method with no exception handling
            // and handle exception here
            try
            {
                info.SaveInfo1("some data", "myfile");
            }
            catch (FileNotFoundException fnfex)
            {
                Console.WriteLine("File does not exist: {0}\n", fnfex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected exception:{0}\n", ex.Message);
            }

            // call method which handles and rethrows
            // and handle exception here
            try
            {
                info.SaveInfo4("some data", "myfile");
            }
            catch (FileNotFoundException fnfex)
            {
                Console.WriteLine("File does not exist: {0}\n", fnfex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected exception:{0}\n", ex.Message);
            }

            // call method which causes an exception while file open
            // handle exception here
            try
            {
                info.SaveInfo5("some data", "mynewfile");
            }
            catch (FileNotFoundException fnfex)
            {
                Console.WriteLine("File does not exist: {0}\n", fnfex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected exception:{0}\n", ex.Message);
            }

            // try to access the file again
            // handle exception here
            try
            {
                info.SaveInfo5("some data", "mynewfile");
            }
            catch (FileNotFoundException fnfex)
            {
                Console.WriteLine("File does not exist: {0}\n", fnfex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected exception:{0}\n", ex.Message);
            }

            // call method which causes an exception while file open
            // but disposes resources properly with using
            // handle exception here
            try
            {
                info.SaveInfo6("some data", "mynewerfile");
            }
            catch (FileNotFoundException fnfex)
            {
                Console.WriteLine("File does not exist: {0}\n", fnfex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected exception:{0}\n", ex.Message);
            }

            // try to access the file again
            // handle exception here
            try
            {
                info.SaveInfo6("some data", "mynewerfile");
            }
            catch (FileNotFoundException fnfex)
            {
                Console.WriteLine("File does not exist: {0}\n", fnfex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected exception:{0}\n", ex.Message);
            }
        }
    }
}
