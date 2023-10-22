using System.Net;
public class Library{
    private List<Scripture> _libList = new List<Scripture>();
    private Random _random = new Random();

    public Scripture GetScripture(string reference){
        return _libList.Find(scripture => scripture.scriptureReference == reference);
    }
    public void AddScriptureToLibrary(string reference, string text){
        Scripture scripture = new Scripture(reference, text);
        _libList.Add(scripture);
    }
    public Scripture GetRandomScripture(){
        int _range = _libList.Count();
        int _randIndex = _random.Next(0, _range);
        return _libList[_randIndex];
    }


    public void LoadScriptures(){
        List<string> urls = new List<string>();
        //urls.Add("https://wa.josh47.com/a/edu/cse210/kjv-scriptures.csv");
        urls.Add("https://wa.josh47.com/a/edu/cse210/lds-scriptures-rev.csv");
        foreach(string link in urls){
            int _linecounter = 0;
            WebRequest request = WebRequest.Create(link);
            request.Method = "GET";
            using var webResponse = request.GetResponse();
            using var webStream = webResponse.GetResponseStream();
            using var reader = new StreamReader(webStream);
            //var data = reader.ReadToEnd();
            {
            string line; 
            while (!reader.EndOfStream){
                line = reader.ReadLine();
                if (_linecounter > 0){
                    string[] X = line.Split('|');
                    //foreach(string thing in X){
                    AddScriptureToLibrary(X[4], X[3]);
                    //Console.WriteLine(X[3]);
                    //Console.WriteLine(thing);
                    //}
                //Scripture scripture = new Scripture(X[4], X[3]);
                //_libList.Add(scripture);
                }
                _linecounter = _linecounter + 1;

            //Separating columns to array
            

            /* Do something with X */
        }
    }
    
}}}