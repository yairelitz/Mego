using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Custumer
    {
        int idcustumer;
        string firstname;
        string lastname;                //     <=====  הגדרת מחלקה
        string email;
        double credit;

        public Custumer(int idcs, string fn, string ln, string email, double crdt)
        {
            this.idcustumer = idcs;
            this.firstname = fn;
            this.lastname = ln;                   //<========קונסטרקטור   
            this.email = email;
            this.credit = crdt;

        }
            public Custumer() 
        {
        }
        public int Getcustumerid() { return idcustumer; }
        public string Getfirstname() { return firstname; }
        public string Getlastname() { return this.lastname; }
        public string Getemail() { return email; }
        public double Getcredit() { return credit; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Custumer c1 = new Custumer();
            Custumer c2 = new Custumer(123467,"yair","elich","yair89eli@gmail.comm",245000.00);
            c2.
            
        }  

    }
}
