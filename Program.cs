Pessoa p1 = new Pessoa (); 
Console.WriteLine("Qual o seu nome?");

p1.Nome = Console.ReadLine();  

Console.WriteLine("Qual a sua altura em metros ? Ex. 1,65");
p1.Altura = Convert.ToSingle(Console.ReadLine());

Console.WriteLine ("Qual o seu peso em kg ? Ex: 70,3");
p1.Peso = Convert.ToSingle(Console.ReadLine());

Console.WriteLine ("Seu IMC é: {0} ", p1.CalcularIMC);
Console.WriteLine("Você atualmente está: {0}",  p1.DescobrirFaixa());
Console.WriteLine("O seu peso ideal é: {0}" , p1.CalcularPesoIdeal);
Console.WriteLine(p1.DevePerderOuGanhar());

Console.WriteLine("{0} sua altura é {1} e seu peso {2}", p1.Nome, Math.Round(p1.Altura, 2 ), p1.Peso);

        

              
    
        
    

