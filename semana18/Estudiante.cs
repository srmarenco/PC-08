public class Estudiantes{
    public static string AprobacionDelCurso(string[] nombres,int[] notas,int num)
    {
        if (notas[num]>=65)
        {
            return nombres[num] + " ha aprobado el curso con "+notas[num];
        }
        else{
            return null;
        }
    }
    public static string DesaprobacionDelCurso(string[] nombres,int[] notas,int num){
        if (!(notas[num]>=65))
        {
            return nombres[num] + " no ha aprobado el curso con "+notas[num];
        }
        else{
            return null;
        }
    }
}
