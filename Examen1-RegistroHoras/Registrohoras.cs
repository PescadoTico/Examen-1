using System;
using System.Collections.Generic;

class Program
{
    // Configuraciones
    const decimal TARIFA_HORA_ORDINARIA = 10m;
    const decimal TARIFA_HORA_EXTRA = 15m;
    const decimal BONO_SIN_AUSENCIAS = 50m;
    const decimal PENALIZACION_TARDANZA = 5m;
    const decimal DEDUCCION = 0.10m;
    const int HORAS_MINIMAS_DIA = 4;
    const int DIAS_MINIMOS_SEMANA = 2;
    const int HORAS_MAXIMAS_SEMANA = 48;
    const int HORAS_SEMANALES_SIN_RECARGO = 40;

    static void Main()
    {
        List<int> horasPorDia = new List<int>();
        int diasTrabajados = 0;
        bool ausencias = false;
        decimal salarioBruto = 0;
        
        Console.WriteLine("Registro de horas trabajadas:");
        
        for (int dia = 1; dia <= 7; dia++)
        {
            Console.WriteLine($"\nDia {dia}:");
            
            Console.Write("Hora de entrada (0-24): ");
            int entrada = int.Parse(Console.ReadLine());
            
            Console.Write("Hora de salida (0-24): ");
            int salida = int.Parse(Console.ReadLine());

            // Validar horas de entrada y salida
            if (entrada >= salida)
            {
                Console.WriteLine("Error: La hora de entrada debe ser anterior a la de salida.");
                return;
            }

            int horasTrabajadas = salida - entrada;
            
            // Validar horas minimas por dia
            if (horasTrabajadas < HORAS_MINIMAS_DIA)
            {
                Console.WriteLine("Error: No se pueden trabajar menos de " + HORAS_MINIMAS_DIA + " horas por dia.");
                return;
            }
            
            horasPorDia.Add(horasTrabajadas);

            if (horasTrabajadas > 0)
            {
                diasTrabajados++;
            }
            
            // Penalizacion por tardanza o salida anticipada
            if (entrada > 9 || salida < 17)
            {
                Console.WriteLine("Penalizacion por tardanza o salida anticipada aplicada.");
                salarioBruto -= PENALIZACION_TARDANZA;
            }
        }

        // Validar dias minimos trabajados
        if (diasTrabajados < DIAS_MINIMOS_SEMANA)
        {
            Console.WriteLine("Error: Se deben trabajar al menos " + DIAS_MINIMOS_SEMANA + " dias a la semana.");
            return;
        }

        int totalHorasSemanales = 0;
        foreach (int horas in horasPorDia)
        {
            totalHorasSemanales += horas;
        }

        // Validar horas maximas semanales
        if (totalHorasSemanales > HORAS_MAXIMAS_SEMANA)
        {
            totalHorasSemanales = HORAS_MAXIMAS_SEMANA;
            Console.WriteLine("Se ha alcanzado el maximo de horas semanales. Las horas adicionales no se pagaran.");
        }

        // Calcular salario bruto
        if (totalHorasSemanales > HORAS_SEMANALES_SIN_RECARGO)
        {
            int horasExtras = totalHorasSemanales - HORAS_SEMANALES_SIN_RECARGO;
            salarioBruto += HORAS_SEMANALES_SIN_RECARGO * TARIFA_HORA_ORDINARIA;
            salarioBruto += horasExtras * TARIFA_HORA_EXTRA;
        }
        else
        {
            salarioBruto += totalHorasSemanales * TARIFA_HORA_ORDINARIA;
        }

        // Verificar ausencias
        ausencias = diasTrabajados < 7;
        
        // Aplicar bono si no hubo ausencias
        if (!ausencias)
        {
            salarioBruto += BONO_SIN_AUSENCIAS;
            Console.WriteLine("Bono por no ausencias aplicado.");
        }

        // Calcular deducciones
        decimal totalDeducciones = salarioBruto * DEDUCCION;
        decimal salarioNeto = salarioBruto - totalDeducciones;

        // Mostrar resultados
        Console.WriteLine("\nResumen de pago:");
        Console.WriteLine($"Total de horas semanales: {totalHorasSemanales}");
        Console.WriteLine($"Salario bruto: ${salarioBruto}");
        Console.WriteLine($"Total de deducciones: ${totalDeducciones}");
        Console.WriteLine($"Salario neto: ${salarioNeto}");
    }
}
