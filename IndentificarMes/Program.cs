//IdentificarMes();

static void IdentificarMes(int mes) {
    string[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };

    //Console.WriteLine($"El mes con numero " + mes.ToString() + "es" + meses[(mes - 1)]);
    Console.WriteLine($"El mes con numero {mes} es {meses[(mes - 1)]}");
}
Console.WriteLine("Ingrese el numero del mes: ");
int mes_Recibido = int.Parse(Console.ReadLine());
IdentificarMes(mes_Recibido);

