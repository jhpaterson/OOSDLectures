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
            Console.WriteLine("CALL METHOD WITH TRY-CATCH");
            info.SaveInfo2("some data", "myfile");

            // call method with try-catch-finally
            Console.WriteLine("CALL METHOD WITH TRY-CATCH-FINALLY");
            info.SaveInfo3("some data", "myfile");

            // call method with no exception handling
            // and handle exception here
            Console.WriteLine("CALL METHOD WITH NO EXCEPTION HANDLING AND HANDLE HERE");
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
            Console.WriteLine("CALL METHOD WHICH HANDLES AND THROWS NEW AND HANDLE HERE");
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
            Console.WriteLine("CALL METHOD WHICH CAUSES EXCEPTION WHILE FILE OPEN AND HANDLE HERE");
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
            Console.WriteLine("TRY TO ACCESS FILE AGAIN AND HANDLE HERE");
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
            Console.WriteLine("CALL METHOD WHICH CAUSES EXCEPTION WHILE FILE OPEN WITH USING AND HANDLE HERE");
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
            Console.WriteLine("TRY TO ACCESS FILE AGAIN AND HANDLE HERE");
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

            Console.ReadLine();
        }
    }
}
