

Queue<int> fila = new Queue<int>();

fila.Enqueue(6);
fila.Enqueue(5);
fila.Enqueue(4);
fila.Enqueue(3);
fila.Enqueue(2);
fila.Enqueue(1);
fila.Enqueue(0);

foreach(int item in fila){
    Console.WriteLine(item);
}













try{

    string[] texto = File.ReadAllLines("text");

    foreach (string linhas in texto){
        Console.WriteLine(linhas);
    }
}catch(Exception){
    Console.WriteLine($"Deu erro xara");
}