using System.ComponentModel.DataAnnotations;
using System.Net;
public class LoadScriptureFiles{
    // public static void LoadScriptures(){
    //     List<string> urls = new List<string>();
    //     //urls.Add("https://wa.josh47.com/a/edu/cse210/kjv-scriptures.csv");
    //     urls.Add("https://wa.josh47.com/a/edu/cse210/lds-scriptures-rev.csv");
    //     foreach(string link in urls){
    //         int _linecounter = 0;
    //         WebRequest request = WebRequest.Create(link);
    //         request.Method = "GET";
    //         using var webResponse = request.GetResponse();
    //         using var webStream = webResponse.GetResponseStream();
    //         using var reader = new StreamReader(webStream);
    //         //var data = reader.ReadToEnd();
    //         {
    //         string line; 
    //         while (!reader.EndOfStream){
    //             line = reader.ReadLine();
    //             if (_linecounter > 0){
    //                 string[] X = line.Split('|');
    //                 foreach(string thing in X){
    //                     AddScriptureToLibrary
    //                     Console.WriteLine(thing);
    //                 }

    //             }
    //             _linecounter = _linecounter + 1;

    //         //Separating columns to array
            

    //         /* Do something with X */
    //     }
    // }

//Console.WriteLine(data);
    //}}
}