namespace MVCWeather.Models;

public class Weather
{
    public int id { get; set; }
    public string city { get; set; }
    public int temp { get; set; }
    public string condition { get; set; }

    public Weather(){}

    public Weather(int id, String city, int temp, string condition){
        this.id = id;
        this.city = city;
        this.temp = temp;
        this.condition = condition;
    }
}