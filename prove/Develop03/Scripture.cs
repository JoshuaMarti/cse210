using System.Dynamic;

public class Scripture {
    public string scriptureText;
    public string scriptureReference;
    public Scripture(string reference, string text) {
        scriptureText = text;
        scriptureReference = reference;
    }
    // public string get() {
    //     return scriptureText;
    // }
}