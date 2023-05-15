using System;

class MainClass {
  public static void Main (string[] args) {

    Console.Write("Enter the first balance amount: ");
    double B1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Enter the second balance amount: ");
    double B2 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Enter the third balance amount: ");
    double B3 = Convert.ToDouble(Console.ReadLine());

    double L = 0;

    Console.WriteLine("Enter payment amounts (enter negative or zero to stop): ");
    while (true) {
      double payment = Convert.ToDouble(Console.ReadLine());

      if (payment <= 0) {
        break;
      }

      if (B1 >= payment) {
        B1 -= payment;
      } else if (B2 >= payment) {
        B2 -= payment;
      } else if (B3 >= payment) {
        B3 -= payment;
      } else {
        L += payment;
      }
    }

    Console.WriteLine("Balance 1: {0}, Balance 2: {1}, Balance 3: {2}", B1, B2, B3);
    Console.WriteLine("Left: {0}", L);
  }
}