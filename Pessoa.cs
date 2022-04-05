public class Pessoa
{
    public string Nome { get; set; }
    public double Peso { get; set; }
    public double Altura { get; set; }
    public double CalcularIMC { get => Math.Round(Peso / (Altura*Altura), 2); }
    public double CalcularPesoIdeal { get => Math.Round ( 21.7 * (Altura*Altura ) , 2) ; }

    public string Faixa()
    {
        double IMC = CalcularIMC;

        if (IMC < 17)
        {
        return "Muito abaixo do peso";
        }
            else if ( IMC <= 18.49) {
                return "Abaixo do peso";
            }
            else if (IMC <= 24.99){
                return "Peso normal";
            }
                else if (IMC <= 29.99){
                return "Acima do peso";
            }
                else if (IMC <= 34.99){
                return "Obesidade I";
            }
            else if (IMC <= 39.99){
                return "Obesidade II (severa)";
            }
            else if (IMC >= 40){
                return "Obesidade II (mórbida)";
            }
     }

     public double DevePerder() 
    { 
        double IMC = CalcularIMC;

        double PesoIdeal = CalcularPesoIdeal;
        if (IMC >= 25 ){
                  return  Peso - PesoIdeal;
                }else if ( IMC < 18.5) {
                    return  PesoIdeal - Peso;
                }else {
                return 0;
                }
    }

    public Pessoa(string nome, double peso, double altura)
    {
        Nome = nome;
        Peso = peso;
        Altura = altura; 
    }
}