using System;


namespace Assignment2
{
    class LitwareLib
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your emp no ?");
            int empno=int.Parse(Console.ReadLine());
            
            Console.WriteLine("What is your name ?");
            string empname=Console.ReadLine();
            
            Console.WriteLine("What is your salary?");
            float salary=float.Parse(Console.ReadLine());

            if (salary<5000)
            {
                double HRA = (salary*0.1);
                double TA = (salary*0.05);
                double DA = (salary*0.15);
                double GrossSalary = (salary+HRA+TA+DA);
                Console.WriteLine("Your HRA is "+HRA);
                Console.WriteLine("Your TA is "+TA);
                Console.WriteLine("Your DA is "+DA);
                Console.WriteLine("Your Gross Salary is"+GrossSalary);
            }
            else if (salary>5000 && salary<10000)
            {
                double HRA = (salary*0.15);
                double TA = (salary*0.10);
                double DA = (salary*0.20);
                double GrossSalary = (salary+HRA+TA+DA);
                Console.WriteLine("Your HRA is" +HRA);
                Console.WriteLine("Your TA is "+TA);
                Console.WriteLine("Your DA is "+DA);
                Console.WriteLine("Your Gross Salary is"+GrossSalary);

            }
            else if(salary>10000 && salary<15000)
            {
                double HRA = (salary*0.20);
                double TA = (salary*0.15);
                double DA = (salary*0.25);
                double GrossSalary = (salary+HRA+TA+DA);
                Console.WriteLine("Your HRA is" +HRA);
                Console.WriteLine("Your TA is "+TA);
                Console.WriteLine("Your DA is "+DA);
                Console.WriteLine("Your Gross Salary is"+GrossSalary);

            }
            else if(salary>15000 && salary<20000)
            {
                double HRA = (salary*0.25);
                double TA = (salary*0.20);
                double DA = (salary*0.30);
                double GrossSalary = (salary+HRA+TA+DA);
                Console.WriteLine("Your HRA is" +HRA);
                Console.WriteLine("Your TA is "+TA);
                Console.WriteLine("Your DA is "+DA);
                Console.WriteLine("Your Gross Salary is"+GrossSalary);
            }
            else if(salary>=20000)
            {
                double HRA = (salary*0.30);
                double TA = (salary*0.25);
                double DA = (salary*0.35);
                double GrossSalary = (salary+HRA+TA+DA);
                Console.WriteLine("Your HRA is" +HRA);
                Console.WriteLine("Your TA is "+TA);
                Console.WriteLine("Your DA is "+DA);
                Console.WriteLine("Your Gross Salary is"+GrossSalary);
                
             
            }
        }
    }
    enum CalculateGrossSalary
    {
        float PF=(float)((1/100)*GrossSalary);
        Console.WriteLine("Your PF is"+PF);
        float TDS = (float)((18/100)*GrossSalary);
        Console.WriteLine("Your TDS is"+TDS);
        float NetSalary = (float)(CalculateGrossSalary-(PF+TDS);
        Console.WriteLine("Your NetSalary is"+NetSalary);

    }
}
