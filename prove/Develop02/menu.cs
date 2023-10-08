//Displays the menu options and lets the user pick one and calls the appropriate class.
//Menu options are: Write New Entry, View Journal Entries, Export Journal Entries, Load Journal Entries, Create File, Quit
// using System;
// class Menu {
//     string options = "Welcome to the Journal Program!\nPlease type the number for your desired option.\n1: Write New Journal Entry\n2: View Journal Entries\n3: Export Journal Entries\n4: Load Journal Entries\n5: Create File\n0: Exit\n\nSelection: ";
//     string input = "";
//     public int Main() {
//         while (input != "0") {
//             Console.WriteLine(options);
//             input = Console.ReadLine();
//             if (input == "1"){WriteNewEntry();}
//             else if (input == "2"){DisplayEntries();}
//             else if (input == "3"){SaveEntries();}
//             else if (input == "4"){LoadEntries();}
//             else if (input == "5"){CreateNewFile();}
//             else {}
//         }
//         return 0;
//     }
// }

//This file is deprecated and the functionality was implemented into Program.cs