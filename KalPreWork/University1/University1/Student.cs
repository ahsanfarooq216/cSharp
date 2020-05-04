using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Globalization;

namespace University1
{
    class Student : Person, IDisposable//Inheritance [Student extends(inherits from) Person]
    {
        private static int StudentCount = 0;

        public Student(string fName, string lName,DateTime dob){
            this.FirstName = fName;
            this.LastName = lName;
            this.DOB = dob;
            StudentCount++;
        }
        public static int NumberOfStudents(){
            return StudentCount;
        }
        //flag to check if the object has been disposed
        private bool isDisposed = false;
        StreamReader sr;
        StreamWriter sw;

        public void ReadDetails(string filename)
        {
            sr = new StreamReader(filename);
            try
            {
                using (sr) //open the text file using the StreamReader
                {
                    String line = sr.ReadToEnd();
                    Console.WriteLine(line);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read");
                Console.WriteLine(e.Message);
            }
            finally
            {
                sr.Close();
                sr = null;
            }
        }

        public bool WriteDetails(string filename)
        {
            bool isWriteSuccess = false;
            sw = new StreamWriter(filename);

            //Create a string array with the lines of text
            string[] lines = { this.FirstName, this.LastName, this.DOB.ToString()};
            try
            {
                using (sw)
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line);
                    }
                }
                isWriteSuccess = true;
            }
            catch (Exception e)
            {
                Console.WriteLine("This file could not be written");
                Console.WriteLine(e.Message);
                isWriteSuccess = false;
            }
            finally
            {
                sw.Close();
                sw = null;
            }

            return isWriteSuccess;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!isDisposed)
            {
                if (disposing)
                {
                    if (sr != null)
                    {
                        sr.Close();
                    }
                    if (sw != null)
                    {
                        sw.Close();
                    }
                }
            }
            isDisposed = true;
        }
    }
}
