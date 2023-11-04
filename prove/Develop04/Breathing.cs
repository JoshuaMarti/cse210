using System.Security.Cryptography;

public class Breathing : Activity {
    public Breathing(string name, string description) :base(name ,description){}
    public void RunActivity() {
        StartActivity();
        //Set up timer
        DateTime _now = DateTime.Now;
        DateTime _endTime = _now.AddSeconds(_duration);
        int _cycles = 0;
        Console.WriteLine("\n\n");
        while (_now < _endTime) {
            _cycles = _cycles + 1;
            Console.Write("Breathe In  ");
            ShowCountup(8);
            Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
            Console.Write("Breathe Out ");
            ShowCountdown(8);
            Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
            _now = DateTime.Now;
        }
        //Revised End Message for this one.
        if (_duration != (_cycles*16)){_endMessage = $"Nicely done! That was {_cycles*16} seconds in the {_activityName} activity (You asked for {_duration} seconds, but we had to make sure you had a chance to breathe out!).\n\nPress Enter when you're ready to return to the menu.";}
        Console.WriteLine(_endMessage);
        Console.ReadLine();
    }
}