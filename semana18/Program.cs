using System;
using System.Diagnostics;
using Microsoft.VisualBasic;

class Raiz{
    static void Main(){
        string[] Nombres = new string[10];
        int[] Notas = new int[10];
        bool VF = true;
        Estudiantes2 Estudiante2 = new Estudiantes2();
        
        Console.WriteLine("Ingrese 10 nombres y las notas de esos estudiantes");
        for (int i = 0; i <10;i++){
            Console.WriteLine("Nombre #"+(i+1));
            try{
                Nombres[i] = Convert.ToString(Console.ReadLine()); //Ingresa nombre del estudiante
            }
            catch (Exception ex){
                Console.WriteLine("La nota ingresada no está en el formato adecuado"); //ERROR si lo ingresa de forma errónea
                Console.WriteLine("Ingresela de nuevo");
                i = i - 1;
                continue;
            }
            Console.WriteLine("Nota #"+(i+1));
            try{
                Notas[i] = Convert.ToInt32(Console.ReadLine()); //Ingresa nota del estudiante
            }
            catch (Exception ex){
                Console.WriteLine("La nota ingresada no está en el formato adecuado"); //ERROR si lo ingresa de forma errónea
                Console.WriteLine("Ingresela de nuevo");
                i = i - 1;
                continue;
            }
            if (Notas[i]>100 || Notas[i]<0){
                Console.WriteLine("La nota ingresada no está en el rango de 0 a 100"); //ERROR si lo ingresa fuera del rango
                Console.WriteLine("Ingresela de nuevo");
                i = i - 1;

            }
        }
        while(VF){
        Console.WriteLine("Elija una opción");
        Console.WriteLine("1. Mostra nombre y notas aprobadas para cada alumno");
        Console.WriteLine("2. Mostrar nombre y notas no aprobadas para cada alumno");
        Console.WriteLine("3. Mostrar el promedio de notas del grupo");
        Console.WriteLine("4. Salir del programa");
        int op = Convert.ToInt32(Console.ReadLine());
        switch(op){
            case 1: 
                for (int i = 0; i < 10; i++){
                    string res = Estudiantes.AprobacionDelCurso(Nombres, Notas, i);
                    Console.WriteLine(res);
                }
                break;
            case 2:
                for (int i = 0; i < 10; i++){
                    string res1 = Estudiantes.DesaprobacionDelCurso(Nombres, Notas, i);
                    Console.WriteLine(res1);
                }
                break;
            case 3:
                int prom = Estudiantes2.PromedioGeneral(Notas);
                Console.WriteLine("El promedio general del grupo es de: "+prom);
                break;
            case 4:
                VF = false;
                break;
        }
        }

    }

}
