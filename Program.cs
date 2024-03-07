

//tercero
Console.Write("Cantidad de sueldos: ");
int cantidad = int.Parse(Console.ReadLine());
double[] salario = new double[3];

double total, promedio;
total = 0;

for (int i = 0; i < cantidad; i++)
{
    Console.Write("Sueldo del empleado " + (i + 1) + ": ");
    salario[i] = double.Parse(Console.ReadLine());
    total += salario[1];
}

promedio = total / cantidad;
for (int i = 0; i < cantidad; i++)
{
    Console.WriteLine("Sueldo del empleado " + (i + 1) + ":    " + salario[i]);

}

    Console.WriteLine();
Console.WriteLine("El total de sueldos es de " + total);
Console.WriteLine("El sueldo total de un empleado es " + promedio);