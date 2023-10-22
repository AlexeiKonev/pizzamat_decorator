using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzeria
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    //componet
    public abstract class Pizza
    {
      protected  string Description = "uknown description ";

        public abstract string GetDescription();

        public abstract decimal GetCost();

       
    }

    public abstract class ContentDecorator : Pizza
    {
        public Pizza Pizza;

        public override decimal GetCost()
        {
            throw new NotImplementedException();
        }

        public override string GetDescription()
        {
            return Description;
        }
    }

    public class Peperoni : Pizza
    {
       public Peperoni()
        {
            Description = " Peperoni ";
        }


        public override decimal GetCost()
        {
            return 1.25m;
        }

        public override string GetDescription()
        {
            return Description;
        }
    }

    public class Pommodoro : Pizza
    {
       public Pommodoro()
        {
            Description =  " Pommodoro ";
        }


        public override decimal GetCost()
        {
            return 1.25m;
        }

        public override string GetDescription()
        {
            return Description;
        }
    }

    public class Cheese : ContentDecorator
    {
        public Cheese(Pizza pizza)
        {
            Pizza = pizza ;
        }

        public override string GetDescription()
        {
            return Pizza.GetDescription() + " , Cheese ";
        }
        public override decimal  GetCost()
        {
            return Pizza.GetCost() + 0.50m;
        }
       
    }
    public class Ananas : ContentDecorator
    {
        public Ananas(Pizza pizza)
        {
            Pizza = pizza ;
        }

        public override string GetDescription()
        {
            return Pizza.GetDescription() + " , Ananas ";
        }
        public override decimal  GetCost()
        {
            return Pizza.GetCost() + 0.50m;
        }
       
    }

    public class Mushrum : ContentDecorator
    {
        public Mushrum(Pizza pizza)
        {
            Pizza = pizza;
        }

        public override string GetDescription()
        {
            return Pizza.GetDescription() + " , Mushrum";
        }
        public override decimal GetCost()
        {
            return Pizza.GetCost() + 0.30m;
        }

    }
}
