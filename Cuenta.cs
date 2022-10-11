class Cuenta{
    string titular;
    double cantidad;
    public Cuenta(string tit, double cant){
        titular = tit;
        cantidad = cant;
    }
    public Cuenta(string tit){
        titular=tit;
    }

    public void setCantidad(double cant){
        cantidad = cant;
    }
    public double getCantidad(){
        return cantidad;
    }

    public string getTitular(){
        return titular;
    }

    public void setTitular(string tit){
        titular = tit;
        Console.WriteLine($"El titular es: {titular}");
    }

    public override string ToString()
    {
        return $"Titular: {titular}, Cantidad: {cantidad}$";
    }
    public void datosCuenta(){
        Console.WriteLine($"El cliente es: {titular}");
        Console.WriteLine(ToString());
    }
    public void ingresar(double cant){
        if(cant > 0) {
        cantidad += cant;
        Console.WriteLine("El monto a sido ingresado..!");
        }
        else
        {
        Console.WriteLine("No se permiten montos negativos..! "+cant);
        }
    }
    public void retirar(double cant){
        double valor=0;
        double resultado = cantidad - cant;
        if(resultado > 0) valor=resultado;
        Console.WriteLine($"El saldo actual es: {resultado}"); 
    }
}