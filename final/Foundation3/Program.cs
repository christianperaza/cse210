using System;

class Program
{
    static void Main(string[] args)
    {
        
        string titleLecture = "Reading The Book of Mormon";
        string descriptionLecture = "We will reading 1 chapter of The Book of Mormon and analize together";
        string dateLecture = "November 27, 2023";
        string timeLecture = "8:00 a. m.";

        string streetLecture = "Uripata St.";
        string cityLecture = "Guayana";
        string stateLecture = "Bolivar";
        string countryLecture = "Venezuela";

        string speakerLecture = "Jose Ortega Lopez";
        int capacityLecture = 25;
        Lecture lecture = new Lecture(titleLecture, descriptionLecture, dateLecture, timeLecture, streetLecture, cityLecture, stateLecture, countryLecture, speakerLecture, capacityLecture);

        lecture.DisplayMarketingMessages();
    }
}