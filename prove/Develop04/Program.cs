using System;
using System.ComponentModel.Design;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
//About Info is located starting on Line 69
class Program
{
    
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop04 World!");
        //Create the Activities
        //Listing!
        string _listingOpener = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        string[] _listingPrompts = {"Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?","Who are some people that have helped you this week?", "Who are some of your personal heroes right now?"};
        
        Listing listingActivity = new Listing("Listing", _listingOpener, _listingPrompts);
        //Breathing!
        string _breathingOpener = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        Breathing breathingActivity = new Breathing("Breathing", _breathingOpener);
        //Reflection!
        string _reflectionOpener = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        string[] _reflectionPrompts = {"Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless.", "Recall a moment when you faced a fear and overcame it.", "Consider a situation where you had to step out of your comfort zone.", "Think of a time when you mentored or guided someone.", "Think of a time when you had to make a difficult decision.", "Think of a time when you collaborated with others to achieve a common goal."};
        string[] _reflectionQuestions = {"Why was this experience meaningful to you?", "Had you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different from other similar experiences?", "What is your favorite thing about this experience?", "What did you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future? Do you think it would be helpful to do so?"
        };
        Reflection reflectionActivity = new Reflection("Reflection", _reflectionOpener, _reflectionPrompts, _reflectionQuestions);


        //While they haven't decided to quit the program, open up the menu for them to pick an activity.
        bool _firstRun = true;
        string _selection = "7";
        bool _tryAgain = false;
        while (_selection != "") {
            
            if (_firstRun) {Console.WriteLine("Welcome to the Mindfulness Program!"); _firstRun = false;}
            else if (!_tryAgain) {Console.Clear(); Console.WriteLine("Welcome back!");}
            _tryAgain = false;
            Console.WriteLine($"Please enter a number from the following options:\n1: Begin Reflection Activity\n2: Begin Listing Activity\n3: Begin Breathing Activity\n4: View About Info\nPress Enter to Exit");
            Console.Write("Make Selection -> ");
            _selection = Console.ReadLine();
            if (_selection == "1") {reflectionActivity.RunActivity();}
            else if (_selection == "2") {listingActivity.RunActivity();}
            else if (_selection == "3") {breathingActivity.RunActivity();}
            else if (_selection == "4") {PrintAboutInfo();}
            else if (_selection == ""){}
            else {Console.WriteLine("Sorry, I didn't recognize that option.\n"); _tryAgain = true;}
            // switch (_selection) {
            //     case "1":
            //         reflectionActivity.RunActivity(); break;
            //     case "2":
            //         listingActivity.RunActivity(); break;
            //     case "3":
            //         breathingActivity.RunActivity(); break;
            //     case "4":
            //         Program.PrintAboutInfo(); break;
            //     case "":
            //         break;
            //     default:
            //         Console.WriteLine("Sorry, I didn't recognize that option.");
            //         _tryAgain = true;
            //         break;
            //}
        }

    }
    private static void PrintAboutInfo(){
        //Dynamic About Info
        string _programName = "CSE210 Mindfulness Program";
        string _programVersion = "0.1.0";
        string _programCopy = "2023 Joshua Martinez";
        Console.Clear();
        Console.WriteLine($"{_programName}\nv{_programVersion}\n\nCopyright {_programCopy}");
        //Static Info
        Console.WriteLine("\nThis program was written to fulfill the requirements listed at https://byui-cse.github.io/cse210-course-2023/unit04/develop.html for my CSE210 course at BYU Idaho in November of 2023. For questions, please contact ims@josh47.com");
        Console.WriteLine("\n\nPress Enter to return to menu.");
        Console.ReadLine();
    }
}