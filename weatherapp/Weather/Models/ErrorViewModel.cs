namespace Weather.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }

    public class Rootobject
    {
        public string queryCost { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public string resolvedAddress { get; set; }
        public string address { get; set; }
        public string timezone { get; set; }
        public string tzoffset { get; set; }
        public string description { get; set; }
        public Day[] days { get; set; }
        public object[] alerts { get; set; }
        public Stations stations { get; set; }
        public Currentconditions currentConditions { get; set; }
    }

    public class Stations
    {
        public VIDP VIDP { get; set; }
        public VIDD VIDD { get; set; }
        public AV559 AV559 { get; set; }
    }

    public class VIDP
    {
        public string distance { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public string useCount { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string quality { get; set; }
        public string contribution { get; set; }
    }

    public class VIDD
    {
        public string distance { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public string useCount { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string quality { get; set; }
        public string contribution { get; set; }
    }

    public class AV559
    {
        public string distance { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public string useCount { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string quality { get; set; }
        public string contribution { get; set; }
    }

    public class Currentconditions
    {
        public string datetime { get; set; }
        public string datetimeEpoch { get; set; }
        public string temp { get; set; }
        public string feelslike { get; set; }
        public string humidity { get; set; }
        public string dew { get; set; }
        public object precip { get; set; }
        public string precipprob { get; set; }
        public string snow { get; set; }
        public string snowdepth { get; set; }
        public object preciptype { get; set; }
        public string windgust { get; set; }
        public string windspeed { get; set; }
        public string winddir { get; set; }
        public string pressure { get; set; }
        public string visibility { get; set; }
        public string cloudcover { get; set; }
        public string solarradiation { get; set; }
        public string solarenergy { get; set; }
        public string uvindex { get; set; }
        public string conditions { get; set; }
        public string icon { get; set; }
        public string[] stations { get; set; }
        public string source { get; set; }
        public string sunrise { get; set; }
        public string sunriseEpoch { get; set; }
        public string sunset { get; set; }
        public string sunsetEpoch { get; set; }
        public string moonphase { get; set; }
    }

    public class Day
    {
        public string datetime { get; set; }
        public string datetimeEpoch { get; set; }
        public string tempmax { get; set; }
        public string tempmin { get; set; }
        public string temp { get; set; }
        public string feelslikemax { get; set; }
        public string feelslikemin { get; set; }
        public string feelslike { get; set; }
        public string dew { get; set; }
        public string humidity { get; set; }
        public string precip { get; set; }
        public string precipprob { get; set; }
        public string precipcover { get; set; }
        public string[] preciptype { get; set; }
        public string snow { get; set; }
        public string snowdepth { get; set; }
        public string windgust { get; set; }
        public string windspeed { get; set; }
        public string winddir { get; set; }
        public string pressure { get; set; }
        public string cloudcover { get; set; }
        public string visibility { get; set; }
        public string solarradiation { get; set; }
        public string solarenergy { get; set; }
        public string uvindex { get; set; }
        public string severerisk { get; set; }
        public string sunrise { get; set; }
        public string sunriseEpoch { get; set; }
        public string sunset { get; set; }
        public string sunsetEpoch { get; set; }
        public string moonphase { get; set; }
        public string conditions { get; set; }
        public string description { get; set; }
        public string icon { get; set; }
        public string[] stations { get; set; }
        public string source { get; set; }
        public Hour[] hours { get; set; }
    }

    public class Hour
    {
        public string datetime { get; set; }
        public string datetimeEpoch { get; set; }
        public string temp { get; set; }
        public string feelslike { get; set; }
        public string humidity { get; set; }
        public string dew { get; set; }
        public string precip { get; set; }
        public string precipprob { get; set; }
        public string snow { get; set; }
        public string snowdepth { get; set; }
        public string[] preciptype { get; set; }
        public string windgust { get; set; }
        public string windspeed { get; set; }
        public string winddir { get; set; }
        public string pressure { get; set; }
        public string visibility { get; set; }
        public string cloudcover { get; set; }
        public string solarradiation { get; set; }
        public string solarenergy { get; set; }
        public string uvindex { get; set; }
        public string severerisk { get; set; }
        public string conditions { get; set; }
        public string icon { get; set; }
        public string[] stations { get; set; }
        public string source { get; set; }
    }

}
