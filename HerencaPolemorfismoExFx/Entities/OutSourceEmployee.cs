
namespace HerencaPolemorfismoExFx.Entities
{
    /**
     * 
     * ta herdando tudo da classe Employee
     * 
     **/
    internal class OutSourceEmployee : Employee
    {
        //atributos (AutoPropreites)
        public double AddTionalCharge { get; set; }

        //construtor
        public OutSourceEmployee() 
        {

        }

        //fazendo o construtor com os argumentos da classe principal
        public OutSourceEmployee(string name, int hours, double valuePerHour, double addTionalCharge) :
            base(name, hours, valuePerHour)
        {

            AddTionalCharge = addTionalCharge;

        }


        public override double Payment()    //fazendo a sobreposição
        {
            //to fazendo o valor do pagamento multiplicado 1.1 e pelo addTionalCharge
            return base.Payment() + 1.1 * AddTionalCharge;
        }


    }
}
