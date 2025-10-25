using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Emplyee
    {
        public double Tax;
        public string Fname;
        public string Lname;
        public double Wage;
        public double Loggedhours;
        public double calculate() => Wage * Loggedhours;
        public double calctax() => calculate() * Tax;
        public double calcnet() => calculate() - calctax();

        public string print_emplouee()
        {
            return $"\nfirst name : {Fname} " +
                    $"\nlast name : {Lname} " +
                    $"\nsalary : {calculate()} " +
                    $"\nyour tax persent : {calctax()} " +
                    $"\nnet salary : {calcnet()} ";

        }
        
    }
}
