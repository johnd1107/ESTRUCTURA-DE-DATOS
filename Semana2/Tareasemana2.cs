using System;

namespace FigurasGeometricas
{
    // Clase Circulo representa un círculo con su radio
    class Circulo
    {
        private double radio; // Atributo privado que representa el radio del círculo

        // Constructor que recibe el valor del radio
        public Circulo(double radio)
        {
            this.radio = radio;
        }

        // CalcularArea es una función que devuelve un valor double,
        // se utiliza para calcular el área de un círculo
        public double CalcularArea()
        {
            return Math.PI * radio * radio;
        }

        // CalcularPerimetro devuelve el perímetro del círculo (longitud de la circunferencia)
        public double CalcularPerimetro()
        {
            return 2 * Math.PI * radio;
        }
    }

    // Clase Rectangulo representa un rectángulo con base y altura
    class Rectangulo
    {
        private double baseRectangulo;  // Atributo privado para la base
        private double altura;          // Atributo privado para la altura

        // Constructor que recibe los valores de base y altura
        public Rectangulo(double baseRectangulo, double altura)
        {
            this.baseRectangulo = baseRectangulo;
            this.altura = altura;
        }

        // CalcularArea devuelve el área del rectángulo
        public double CalcularArea()
        {
            return baseRectangulo * altura;
        }

        // CalcularPerimetro devuelve el perímetro del rectángulo
        public double CalcularPerimetro()
        {
            return 2 * (baseRectangulo + altura);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Crear un objeto de tipo Circulo con radio 5
            Circulo miCirculo = new Circulo(5);
            Console.WriteLine("Área del círculo: " + miCirculo.CalcularArea());
            Console.WriteLine("Perímetro del círculo: " + miCirculo.CalcularPerimetro());

            // Crear un objeto de tipo Rectangulo con base 4 y altura 6
            Rectangulo miRectangulo = new Rectangulo(4, 6);
            Console.WriteLine("Área del rectángulo: " + miRectangulo.CalcularArea());
            Console.WriteLine("Perímetro del rectángulo: " + miRectangulo.CalcularPerimetro());
        }
    }
}
