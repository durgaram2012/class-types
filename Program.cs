using System;


namespace Properties
{
    class Employee
    {
        int _eno;
        public int Eno
        {
            get { return _eno; }
            set { _eno = value; }
        }

        string _ename;
        public string Ename
        {
            get { return _ename; }
            set { _ename = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Eno = 1001;
            employee.Ename = "Ashok";

            Console.WriteLine("{0} \t {1}", employee.Eno, employee.Ename);
        }
    }
}
 