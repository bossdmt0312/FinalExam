using System;

class MainClass {
  public static void Main (string[] args) {

    Console.Write("Enter the maximum tank capacity: ");
    double Vmax = Convert.ToDouble(Console.ReadLine());

    Console.Write("Enter the average water consumption during break time: ");
    double tdrink = Convert.ToDouble(Console.ReadLine());

    Console.Write("Enter the amount of water that can be refilled in each round: ");
    double tfill = Convert.ToDouble(Console.ReadLine());

    Console.Write("Enter the duration of break time: ");
    int breaktime = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter the duration between rounds: ");
    int roundtime = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter the total duration of the activity for the day: ");
    int totaltime = Convert.ToInt32(Console.ReadLine());

    int[] refillTime = new int[3];
    refillTime[0] = breaktime;
    refillTime[1] = breaktime + roundtime;
    refillTime[2] = breaktime + (roundtime * 2);


    double Vstart = Vmax / 2;


    double V = Vstart;
    bool enoughWater = true;
    for (int i = 0; i < totaltime; i++) {
      if (Array.IndexOf(refillTime, i) != -1) {
        V += tfill;
        if (V > Vmax) {
          Console.WriteLine("Overflow Water");
          break;
        }
      }
      if (enoughWater) {
        V -= tdrink;
        if (V < 0) {
          enoughWater = false;
          Console.WriteLine("Not Enough Water");
        }
      }
    }
    if (enoughWater) {
      Console.WriteLine("Enough Water, {0} left", V);
    }
  }
}