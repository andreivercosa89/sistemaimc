using System;
namespace sistemaimc
{
    public class Imc
    {
        public string Nome {set;get;}

        public double Peso {set; get;}

        public double Altura {set; get;}

        public double testImc(){
            return (Peso/Math.Pow(Altura,2));
        }

        public string getImc(){
           if(testImc() < 18.5)
            {
                return  "Abaixo";
            }else if (testImc() < 25){
                return "Normal";
            }else if (testImc() < 35)
            {
                return "Ob. Leve";
            }else if (testImc() < 40)
            {
                return "Ob. Moderado";
            }else{
                return "Ob. Morbido";
            }
        }
    }
}
