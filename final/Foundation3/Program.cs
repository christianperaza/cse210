using System;

class Program
{
    static void Main(string[] args)
    {
        string typeLecture = "Lecture";
        string titleLecture = "Reading The Book of Mormon";
        string dateLecture = "November 27, 2023";
        Lecture lecture = new Lecture(typeLecture, titleLecture, dateLecture);

        lecture.DisplayShortDescription();
    }
}