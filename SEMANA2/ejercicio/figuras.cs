using System;

// Clase Circulo: tiene un radio y calcula área y perímetro
public class Circulo
{
    private double radio;

    public Circulo(double radio)
    {
        this.radio = radio;
    }

    public double CalcularArea() => Math.PI * radio * radio;

    public double CalcularPerimetro() => 2 * Math.PI * radio;
}


// Clase Rectangulo: tiene base y altura
public class Rectangulo
{
    private double baseRect;
    private double altura;

    public Rectangulo(double baseRect, double altura)
    {
        this.baseRect = baseRect;
        this.altura = altura;
    }

    public double CalcularArea() => baseRect * altura;

    public double CalcularPerimetro() => 2 * (baseRect + altura);
}

