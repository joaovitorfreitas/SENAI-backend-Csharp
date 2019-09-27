using System;

namespace Exercicios3
{
    class Program
    {
        static void Main(string[] args)
        {
            MonstraInfo();
 
            Console.WriteLine(MonstraInfo("João", "Vitor"));

            Console.WriteLine(MonstraInfo(30, 50.50, 1.80));
        }   
        static void MonstraInfo(){
            Console.WriteLine("razão social da escola senai de informática");   
            
        }
        static String MonstraInfo(string nome, string sobrenome){

            
            return $"{nome} {sobrenome}";
        }
        static string MonstraInfo(int idade, double peso, double altura){
            return $"\nPeso: {peso.ToString("F2")}\n Idade: {idade}\n  Altura: {altura.ToString("F2")}";
            }
}
