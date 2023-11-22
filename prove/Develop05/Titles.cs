public class Titles{
public static string GetTitle(int points){
    if (points < 0) return "Invalid Points";
    else if(points <= 5) return "Beginner";
    else if(points <= 50) return "Esquire";
    else if(points <= 100) return "Maestro";
    else if(points <= 500) return "Esteemed";
    else if(points <= 1000) return "Paragon";
    else if(points <= 2000) return "Sublime";
    else if(points <= 5000) return "Ineffable";
    else if(points <= 7000) return "Excellency";
    else if(points <= 10000) return "Ambassador";
    else if(points <= 20000) return "Baron";
    else if(points <= 30000) return "Viscount";
    else if(points <= 50000) return "Immaculate";
    else if(points <= 75000) return "Profound";
    else if(points <= 100000) return "Unbridled";
    else if(points <= 200000) return "Respendent";
    else if(points <= 300000) return "Grandiose";
    else if(points <= 400000) return "Grand Poohbah";
    else if(points <= 500000) return "Grand Master";
    else if(points <= 750000) return "Imperial Majesty";
    else if(points <= 900000) return "Royal Majesty";
    else if(points <= 1000000) return "Serene Majesty";
    else if(points <= 2000000) return "Most Honorable";
    else if(points <= 3000000) return "Sovereign";
    else if(points <= 4000000) return "Eminent";
    else if(points <= 5000000) return "Most Distinguished";
    else if(points <= 6000000) return "High Sovereign";
    else if(points <= 7000000) return "Grand Commander";
    else if(points <= 8000000) return "Most Sublime";
    else if(points <= 9000000) return "Grand Sovereign";
    else if(points <= 10000000) return "Paramount Sovereign";
    else if(points <= 50000000) return "Grand Seraph";
    else if(points <= 100000000) return "Celestial Soverign";
    else if(points <= 500000000) return "Eternal Sovereign";
    else return "Infinite Sovereign";
}
}