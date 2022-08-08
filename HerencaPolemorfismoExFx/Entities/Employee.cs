
namespace HerencaPolemorfismoExFx.Entities
{
    internal class Employee
    {
        //atributos(autoPropries)
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }

        //construtor
        public Employee()
        {


        }

        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        //method
        public virtual double Payment() //liberando para sobreposição
        {
            return Hours * ValuePerHour;
        }

    }
}
