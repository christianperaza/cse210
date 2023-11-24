using System;

class Program
{
    static void Main(string[] args)
    {
        // ---------- LECTURE ---------- //
        string titleLecture = "Reading The Book of Mormon";
        string descriptionLecture = "Come to read 1 chapter of The Book of Mormon and analize together";
        string dateLecture = "November 27, 2023";
        string timeLecture = "5:30 p. m.";

        string streetLecture = "Uripata St.";
        string cityLecture = "Guayana";
        string stateLecture = "Bolivar";
        string countryLecture = "Venezuela";

        string speakerLecture = "Jose Ortega Lopez"; // speaker
        int capacityLecture = 25; // capacity

        Lecture lecture = new Lecture(titleLecture, descriptionLecture, dateLecture, timeLecture, streetLecture, cityLecture, stateLecture, countryLecture, speakerLecture, capacityLecture);

        
        // ---------- RECEPTION ---------- //
        string titleReception = "Summer's Pool";
        string descriptionReception = "Do you want to swim in the amazing Summer's Pool? Register for reservation and enjoy with us during all day";
        string dateReception = "December 13, 2023";
        string timeReception = "8:00 a. m. - 5:00 p. m.";

        string streetReception = "Congonha St.";
        string cityReception = "Congonha";
        string stateReception = "Sao Paulo";
        string countryReception = "Brazil";

        string emailReception = "eventsinfo@gmail.com"; // email for reservation

        Reception reception = new Reception(titleReception, descriptionReception, dateReception, timeReception, streetReception, cityReception, stateReception, countryReception, emailReception);


        // ---------- OUTDOOR ---------- //
        string titleOutdoor = "Welcome 2024!";
        string descriptionOutdoor = "Big party to give welcome to 2024 year. Big lights, music, and artists.";
        string dateOutdoor = "December 31, 2023";
        string timeOutdoor = "7:00 p. m. - 2:00 a. m.";

        string streetOutdoor = "View West St.";
        string cityOutdoor = "Kingston";
        string stateOutdoor = "New York";
        string countryOutdoor = "USA";

        string weatherOutdoor = "Cloudy"; // weather statement

        Outdoor outdoor = new Outdoor(titleOutdoor, descriptionOutdoor, dateOutdoor, timeOutdoor, streetOutdoor, cityOutdoor, stateOutdoor, countryOutdoor, weatherOutdoor);


        // ---------- DISPLAY MARKETING MESSAGES ---------- //
        // add event objects to base class called Event...
        List<Event> events = new()
        {
            lecture,
            reception,
            outdoor
        };
        // iterate on each object to call the method to display marketing messages...
        foreach (Event item in events)
        {
            item.DisplayMarketingMessages();
        }
        
    }
}