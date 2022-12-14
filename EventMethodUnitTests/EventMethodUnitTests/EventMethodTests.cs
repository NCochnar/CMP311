using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMethodUnitTests
{
    public interface IWedding // public interface for id
    {
        void PrintEvent();
    }
    public interface IGraduation // public interface for Discription of the event
    {
        void PrintEvent();
    }
    public interface IBirthday // public interface for Cost of the event
    {
        void PrintEvent();
    }

    public class EventInfo // Class providing information that belongs to the event
    {
        int id;
        string discription;
        double cost;

        public EventInfo(int newId, string newDiscription, double newCost)
        {
            id = newId;
            discription = newDiscription;
            cost = newCost;
        }

        public int Id // property for Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Discription // property for Discription
        {
            get { return discription; }
            set { discription = value; }
        }

        public double Cost // property for Cost
        {
            get { return cost; }
            set { cost = value; }
        }

        public double CostEngine(string choice)
        {
            if(choice.ToLower() == "d")
            {
                return Cost *= 0.9;
            }
            if(choice.ToLower() == "e")
            {
                return Cost *= 0.75;
            }
            if(choice.ToLower() == "f")
            {
                return Cost = 0;
            }
            if(choice.ToLower() == "l")
            {
                return Cost *= 1.1;
            }
            return Cost;
        }

        public override string ToString()
        {
            return "ID: " + id.ToString() + " Discription: " + discription.ToString() + " Cost: " + cost.ToString();
        }
    }

    public class Event : IWedding, IGraduation, IBirthday
    {
        private EventInfo info;

        public Event(int Id, string description, double cost)
        {
            info = new EventInfo(Id, description, cost);
        }

        void IWedding.PrintEvent()
        {
            Console.WriteLine("ID" + info.Id + " " + info.Discription + " " + info.Cost);
            Console.WriteLine("Is this price correct? (Discount = D) (Employee = E) (Late = L) (Free = F)");
            var choice = Console.ReadLine();
            info.CostEngine(choice);
            Console.WriteLine("ID" + info.Id + " " + info.Discription + " " + info.Cost);
        }

        void IGraduation.PrintEvent()
        {
            Console.WriteLine("ID" + info.Id + " " + info.Discription + " " + info.Cost);
            Console.WriteLine("Is this price correct? (Discount = D) (Employee = E) (Late = L) (Free = F)");
            var choice = Console.ReadLine();
            info.CostEngine(choice);
            Console.WriteLine("ID" + info.Id + " " + info.Discription + " " + info.Cost);
        }

        void IBirthday.PrintEvent()
        {
            Console.WriteLine("ID" + info.Id + " " + info.Discription + " " + info.Cost);
            Console.WriteLine("Is this price correct? (Discount = D) (Employee = E) (Late = L) (Free = F)");
            var choice = Console.ReadLine();
            info.CostEngine(choice);
            Console.WriteLine("ID" + info.Id + " " + info.Discription + " " + info.Cost);
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Event Application in C#");
            Console.WriteLine("-----------------------");

            IWedding newWedding = new Event(1, "Wedding", 20.00);
            newWedding.PrintEvent();

            IGraduation newGraduation = new Event(2, "Graduation", 20.00);
            newGraduation.PrintEvent();

            IBirthday newBirthday = new Event(3, "Birthday", 20.00);
            newBirthday.PrintEvent();

        }
    }
}
