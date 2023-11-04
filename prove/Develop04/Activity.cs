public class Activity {
    protected String _activityName;
    private string _activityDescription;
    protected int _duration;
    protected string _endMessage;
    public Activity(string name, string description){
        _activityName = name;
        _activityDescription = description;
    }
    public static void Countdown(int length_in_seconds){

    }
    public void StartActivity(){
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName} Activity!\n{_activityDescription}");
        Console.WriteLine($"How long would you like to do the {_activityName} Activity? I recommend at least 10 seconds.");
        Console.Write("Time in Seconds -> ");
        _duration = int.Parse(Console.ReadLine());

        //Set the ending message while we're at it.
        _endMessage = $"Nicely done! That was {_duration} seconds in the {_activityName} activity.\n\nPress Enter when you're ready to return to the menu.";
        }
    public static void ClearCountdown(){Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b");}
    public static void ShowCountdown(int duration_in_seconds){
        int _d = duration_in_seconds * 1000;
        int _wait = _d/20;
        Console.Write("[==========]\b");
        while (_d > 0) {
            Thread.Sleep(_wait);
            Console.Write("\b-");
            Thread.Sleep(_wait);
            Console.Write("\b \b");
            _d = _d - (_wait*2);
        }
    }
    public static void ShowCountup(int duration_in_seconds){
        int _d = duration_in_seconds * 1000;
        int _wait = _d/20;
        Console.Write("[          ]");
        Console.Write("\b\b\b\b\b\b\b\b\b\b\b");
        while (_d > 0) {
            Thread.Sleep(_wait);
            Console.Write("-");
            Thread.Sleep(_wait);
            Console.Write("\b=");
            _d = _d - (_wait*2);
        }
    }
}