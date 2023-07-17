namespace MVCWeather.Models;

public class Weather
{
    public int id { get; set; }
    public string city { get; set; }
    public int temp { get; set; }

    public Weather(int id, String city, int temp){
        this.id = id;
        this.city = city;
        this.temp = temp;
    }
}