using System;

public class IndaneCustomer
{
    int customerid;
    string name;
    float unitconsumed;
    float billamaount;
    float netbillamaount;
    float charge;

    void calculate_bill()
    {
        if (unitconsumed <= 199)
        {
            charge = (float)1.20;
        }
        else if (unitconsumed > 199 && unitconsumed < 400)
        {
            charge = (float)1.50;
        }
        else if (unitconsumed > 399 && unitconsumed < 600)
        {
            charge = (float)1.80;
        }
        else if (unitconsumed > 599)
        {
            charge = (float)2.00;
        }
        billamaount = (unitconsumed * charge);

        if (billamaount >= 400)
        {
            netbillamaount = (float)(billamaount + (0.15 * billamaount));
        }
        else if (billamaount < 400)
        {
            netbillamaount = billamaount;
        }
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

    public void showdata()
    {
        Console.WriteLine("Amount Charges @Rs.{0} per unit : Rs. {1}", charge, billamaount);
        if (unitconsumed > 400)
        {
            Console.WriteLine("Surcharge Amount above 400 units : 240.00");
        }
        Console.WriteLine("Net amount paid by the customer : Rs. {0}", netbillamaount);

    }
}