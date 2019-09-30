using System;
using Aula12.Controllers;

namespace Aula12
{
    class Program
    {
        static void Main(string[] args)
        {
            CarrosController carro = new CarrosController();
            CarrosController carroEletrico = new CarrosController();

            Console.Clear(); // Limpa a tela do terminal.

            carro.Ligar();

            carroEletrico.CarregarBateria(100);
            carroEletrico.CarregarBateria(15);
            System.Console.WriteLine("Cagar do carro: " + CarroEletricoModel.StatusBateria());

            carroEletrico.Bateria;
            

        }
    }
}
