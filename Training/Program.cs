using System;
class IndaneCustomers
{
    int customerid;
    string name;
    float unitconsumed;
    float billamaount;
    float charge;

    void calculate_bill()
    {
        if (unitconsumed <= 199)
        {
            charge = (float)1.20;
            billamaount = (unitconsumed * charge);
        }
        else if (unitconsumed > 199 && unitconsumed < 400)
        {
            charge = (float)1.50;
            billamaount = (unitconsumed * charge);

        }
        else if (unitconsumed > 399 && unitconsumed < 600)
        {
            charge = (float)1.80;
            billamaount = (unitconsumed * charge);
        }
        else if (unitconsumed > 599)
        {
            charge = (float)2.00;
            billamaount = (unitconsumed * charge);
        }

        Console.WriteLine("Amount Charges @Rs.{0} per unit : {1}",charge, billamaount);
        if (billamaount >= 400)
        {
            billamaount = (float)(billamaount + (0.15 * billamaount));
            Console.WriteLine("Surcharge Amount : 240.00");
        }
        
        Console.WriteLine("Net amount paid by the customer : {0}", billamaount);

    }

    public void getdata()
    {
        Console.WriteLine("Enter the Customer ID");
        customerid = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Name");
        name = Console.ReadLine();
        Console.WriteLine("Enter the Units Consumed");
        unitconsumed = (float)Convert.ToInt32(Console.ReadLine());
        calculate_bill();

    }
}
class Program
{
    static void Main()
    {
        IndaneCustomers s = new IndaneCustomers();
        s.getdata();
    }
}