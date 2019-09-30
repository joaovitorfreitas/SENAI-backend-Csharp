using Aula12.Models;

namespace Aula12.Controllers {
    public class CarrosEletricosController : CarrosController {
        CarroEletricoModel carroEletrico = new CarroEletricoModel ();

        MotorModel motor = new MotorModel ();

        public void CarregarBateria (float carga) {
            if (carroEletrico.Bateria < 100) {
                carroEletrico.Bateria += carga;
            } else {
                System.Console.WriteLine ("A bateria do carro já está completa! Pode Viajar");
            }

        }
        public float StatusBateria () {
            return carroEletrico.Bateria;
        }

    }
}