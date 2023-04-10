class Profecayo{
    static void Main(string[] args){

        double promedio = 0.0;
        double nota = 0.0;
        double total = 0.0;
        string nombre;
        int cantidad = 0;

        Console.WriteLine("Ingresar nombre: ");
        nombre = Console.ReadLine();

        while(true){
            Console.WriteLine("(introducir -1 para terminar)\n Ingresar nota: ");
            nota = double.Parse(Console.ReadLine());

            if(nota == -1){
                break;
            }

            else if(nota <= 7.0 && nota >= 1.0){
                total += nota;
                cantidad++;
                Console.WriteLine("ingresado");
            }
            else{
                Console.WriteLine("nota invalida");
            }
        }

        promedio=total/cantidad;

        if(cantidad == 0){
            Console.WriteLine("ingresar una nota o eres un inteer fracasado");
        }
            if(promedio >= 4.0){
                Console.WriteLine("Felicidades"+nombre+", aprobo!\nTu promedio es: "+promedio.ToString("0.0"));
            }
            else{
                Console.WriteLine("Lo siento "+nombre+", reprobo\nTu promedio es: "+promedio.ToString("0.0"));
            }


    }
}