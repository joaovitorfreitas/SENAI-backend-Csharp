using System;
using Aula12.Models;

namespace Aula12.Controllers {
    public class CarrosController {
        CarroModel carro = new CarroModel ();

        MotorModel motor = new MotorModel ();

        public void Ligar () {
            carro.Ligado = true;
            System.Console.WriteLine ("Ligando Carro");

        }
        public void Desligar () {
            carro.Ligado = false;
            System.Console.WriteLine ("Desligando Carro...");
        }

        public void Acelerar () {
            if (carro.Ligado == true) {
                System.Console.WriteLine ("Carro Acelerando");
            } else {
                System.Console.WriteLine ("O carro não está Ligando! Impossível acelera!");
            }
        }
        public void Freiar () {
            if (carro.Ligado == true) {
                System.Console.WriteLine ("Carro freando...");
            } else {
                System.Console.WriteLine ("O carro Não está ligando! Impossível Frear!");
            }
        }
        public void CadastrarMotor () {
            System.Console.WriteLine ("Insira quantos cavalos tem o motor: ");
            motor.Cavalos = int.Parse (Console.ReadLine ());

            System.Console.WriteLine ("Insira quantos cilindros tem o carro: ");
            motor.Cilindros = int.Parse (Console.ReadLine ());

            System.Console.WriteLine ("Insira o modelo do pistão do carro: ");
            motor.Pistao = Console.ReadLine ();
        }
    }
}