using System;

class Program {
    static void Main(string[] args) {
        bool continuar = true;

        while (continuar) {
            Console.WriteLine("Digite o preço da gasolina:");
            double precoGasolina = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o preço do álcool:");
            double precoAlcool = double.Parse(Console.ReadLine());

            double relacao = precoAlcool / precoGasolina;

            if (relacao > 0.7) {
                Console.WriteLine("Abasteça com gasolina.");
            } else if (relacao < 0.7) {
                Console.WriteLine("Abasteça com álcool.");
            } else {
                Console.WriteLine("Tanto faz abastecer com gasolina ou álcool.");
            }

            Console.WriteLine("Deseja efetuar um novo cálculo? (s/n)");
            string resposta = Console.ReadLine();

            if (resposta.ToLower() == "n") {
                continuar = false;
            }
        }
    }
}
