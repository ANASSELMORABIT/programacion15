internal class Program
{
    private static void Main(string[] args)
    {
        // /*Tarea1*/
        int[] numeros = new int [6];
        int i;
        for(i=0;i<=5;i++){
            Console.WriteLine("ingresa un numero:");
            numeros[i] =Convert.ToInt32(System.Console.ReadLine());
        }
        Console.WriteLine("Inverse:");
        for(i=5;i>=0;i--){
            Console.WriteLine("{0}",numeros[i]);
        }
        /*Tarea2*/
        string[] nombres = new string[10];
        int i;
        for(i=0;i<=99;i++){
            Console.WriteLine("ingresa un nombre:");
            string nombre =Console.ReadLine();
            if(nombre=="stop"){
                break;
            }
            nombres[i]=nombre;
        }
        Console.WriteLine("los nombres son:");
        for(i=0;i<=99;i++){
            Console.WriteLine("{0}",nombres[i]);
        }
        // /*Tarea3*/
        int[] meses = {31,28,31,30,31,30,31,31,30,31,30,31};
        int i;
        Console.WriteLine("ingresa un mes:");
        i=Convert.ToInt32(System.Console.ReadLine());
        Console.WriteLine("numeros de dias de este mes son:{0}",meses[i-1]);
        // /*Tarea4*/
        float [] Numeros_dec = new float [7];
        int i,j;
        for(i=0;i<=6;i++){
            Console.WriteLine("ingresa un numero:");
            Numeros_dec[i] =Convert.ToInt32(System.Console.ReadLine());
        }
        for (i=0;i<=6;i++){
            for(j=i+1;j<=6;j++){
                if(Numeros_dec[i]<Numeros_dec[j]){
                    float aux=Numeros_dec[i];
                    Numeros_dec[i]=Numeros_dec[j];
                    Numeros_dec[j]=aux;
                }
            }
        }
        for(i=0;i<=6;i++){
            Console.WriteLine("{0}",Numeros_dec[i]);
        }
        // /*tarea5*/
        int [] Numeros_Pares = new int [10];
        int i,comptador;
        comptador=0;
        for (i=0;i<=9;i++){
            Console.WriteLine("ingresa un numero:");
            Numeros_Pares[i] =Convert.ToInt32(System.Console.ReadLine());
        }
        for(i=0;i<=9;i++){
            if  (Numeros_Pares[i] % 2 == 0 ){
                comptador++;
            }
        }
        Console.WriteLine("hay {0} numeros pares",comptador);
    }
}