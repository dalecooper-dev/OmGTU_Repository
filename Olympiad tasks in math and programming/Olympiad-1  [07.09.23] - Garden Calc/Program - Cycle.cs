using System;
class Garden {
  static void Main() {
    int N, K, L, P ,S;
    Console.WriteLine("Введите количество грядок: (N)");
    N = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Длина грядок: (K)");
    K = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ширина грядок: (L)");
    L = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Расстояние до колодца: (P)");
    P = Convert.ToInt32(Console.ReadLine());
    
    S = 0;
    for (int i = 0; i < N; i++) {
        S += 2 * (P + K + L) + L * (N - 1);
    }
    
    Console.WriteLine("Пройденное расстояние: " +S);
    Console.ReadKey();
  }
}