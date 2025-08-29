internal class Program
{
    private static void Main(string[] args)
    {
        //        Console.WriteLine("complejidad de algoridmos");
        //       
        //        var nombres = new List<String>() { "ileny","alondra","jose","juan","alejandro","karla"};
        //        var primero = (List<String>arreglo)=>arreglo != null&& arreglo.Count>0?

        //arreglo[1]:"lista vacia";
        //        Console.WriteLine(primero(nombres));
        Console.WriteLine("complejidad big 0(1)");
        var numeros = new List<int>() { 45,22,53,500,2000,10000,0,1 };
        var numeroMayor = (List<int> arreglo) => { 
            if (arreglo == null || arreglo.Count == 0)
            {
                return 0;
             
            }
           
                int mayor = arreglo[0];
                for (int i = 1; i < arreglo.Count; i++)
                {
                    if (arreglo[i] > mayor)
                    {
                        mayor = arreglo[i];
                    }
                }
            
            return mayor;
        };
        int may=numeroMayor(numeros);
        Console.WriteLine("el numero mayor es:"+may);



        Console.ReadKey(); 
    }
}