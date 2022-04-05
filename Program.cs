using System;

namespace CalculadoraIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o seu nome?");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual a sua altura em metros ? Ex. 1,65");
            float altura = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine ("Qual o seu peso em kg ? Ex: 70,3");
            float peso = Convert.ToSingle(Console.ReadLine());

            double imc = Math.Round(peso / (altura*altura), 2);
            
            Console.WriteLine("{0} sua altura é {1} e seu peso {2}", nome, altura,peso);
            Console.WriteLine("Seu IMC é {0}", imc);

            if (imc < 17){
                Console.WriteLine ("Muito abaixo do peso");
                }
                else if (imc <= 18.49) {
                    Console.WriteLine ("Abaixo do peso");
                }
                else if (imc <= 24.99){
                    Console.WriteLine ("Peso normal");
                }
                 else if (imc <= 29.99){
                    Console.WriteLine ("Acima do peso");
                }
                   else if (imc <= 34.99){
                    Console.WriteLine ("Obesidade I");
                }
                else if (imc <= 39.99){
                    Console.WriteLine ("Obesidade II (severa)");
                }
                else if (imc >= 40){
                    Console.WriteLine ("Obesidade II (mórbida)");
                }

                double  pesoideal  = Math.Round ( 21.7 * (altura*altura ) , 2) ;
                if (imc >= 25 ){
                  Console.WriteLine ("Você precisa perder {0} kg.", peso - pesoideal);
                }else if ( imc < 18.5) {
                    Console.WriteLine ("Você precisa ganhar {0} kg.",  pesoideal - peso);
                }else {
                Console.WriteLine ("Você está no peso ideal!");
                }
        }
    }
}
