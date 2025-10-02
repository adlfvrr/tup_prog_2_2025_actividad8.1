using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej.Models;
public class Cuenta : IComparable<Cuenta>
{
    public string Nombre { get; set; }
    public int DNI { get; set; }
    public double Importe { get; set; }
    public Cuenta(string nombre, int dni, double importe)
    {
        this.Nombre = nombre; this.DNI = dni; this.Importe = importe;
    }
    public Cuenta(int dni) {  this.DNI = dni; }
    public override string ToString()
    {
        return this.Nombre + " - " + this.DNI + " - " + $"${this.Importe}";
    }

    public int CompareTo(Cuenta? obj)
    {
        if (obj != null) { return this.DNI.CompareTo(obj.DNI); }
        return -1;
    }
}
