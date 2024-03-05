namespace Herencia;

internal class Vaca : Mamifero
{
    private double litrosDeLeche { get; set; }

    public Vaca(string n, double p, double l) : base(n, p)
    {
        this.litrosDeLeche = l; 
    }

    public void CalcularCantidadComida()
    {
        double kComida = 0;
        kComida = peso / litrosDeLeche;
        Console.WriteLine("La cantidad de comida es: " + kComida);
    }

    public void mostrarVaca()
    {
        Console.WriteLine("El nombre de la vaca es: " + getNombre());
        Console.WriteLine("El peso de la vaca es: " + peso);
        Console.WriteLine("Los litros de leche son: " + litrosDeLeche);
    }
    
}