class Estudiantes2{
    private static int PromedioGeneral(int[] notas){
        int cont = 0;
        for (int i = 0; i < 10; i++){
            cont+=notas[i];
            
        }
        cont = cont/10;
        return cont;
    }
}