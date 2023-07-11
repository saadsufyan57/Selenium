using System;


namespace Project
{
    class namePrint
    {
        string name;
        string lName;

        //public namePrint(string name)
        //{
        //    this.name = name;
        //}

        public namePrint(string fName, string lName)
        {
            this.name = fName;
            this.lName = lName;
        }

        public void getName()
        {
            Console.WriteLine("My name is " + this.name + " "+ this.lName);
        }
        static void Main(string[] args)
        {
            //namePrint p = new namePrint("Saad");
            namePrint p1 = new namePrint("Saad","Sufyan");


            //p.getName();
            p1.getName();  
        }
    }
}