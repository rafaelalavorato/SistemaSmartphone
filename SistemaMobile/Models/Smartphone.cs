using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMobile.Models;

public abstract class Smartphone
{
    public string Numero { get; set; }
    protected string Modelo { get; set; }
    protected int Memoria { get; set; }
    private string Imei { get; set; }

    public Smartphone(string numero, string modelo, string imei, int memoria) 
    { 
        Numero = numero;
        Modelo = modelo;
        Imei = imei;
        Memoria = memoria;
    }

    public void Ligar() 
    {
        Console.WriteLine("Ligando...");
    }

    public void ReceberLigacao() 
    {
        Console.WriteLine("Recebendo ligação...");
    }

    public void ExibirDados()
    {
        Console.WriteLine("Número: " + Numero);
        Console.WriteLine("Modelo: " + Modelo);
        Console.WriteLine("Memória: " + Memoria);
    }
    public abstract void InstalarAplicativo(string nomeApp);
}
