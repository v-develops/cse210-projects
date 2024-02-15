using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        // Lecture Event //
        Address address1 = new Address("Caminho Foz do Jordão 280", "Campo Grande", "Rio de Janeiro", "Brazil");
        string lectureAddress = address1.GetAddress();

        Lectures lecture = new Lectures("Learning about the Solar System", "A dynamic and fun lecture to teach everyone about the fascinating magic of Astronomy!", "10/01/2025", "8:30 pm", "Lecture", lectureAddress, "Victor Andrade", "35");

        
        Console.WriteLine("--------------------------------------------------------------------------------------");
        
        Console.WriteLine("STANDART DETAILS:");
        lecture.GetStandardDetails();
        Console.WriteLine();
        Console.WriteLine("FULL DETAILS:");
        lecture.GetFullDetailsLecture();
        Console.WriteLine();
        Console.WriteLine("SHORT DETAILS:");
        lecture.GetShortDetails();

        Console.WriteLine("--------------------------------------------------------------------------------------");
        Console.WriteLine();

        // Reception Event //
        Address address2 = new Address("Rua Bento Rodrigues Noia 68", "Seropédica", "Rio de janeiro", "brazil");
        string receptionAddress = address2.GetAddress();

        Receptions reception = new Receptions("Juan Jasmond & Jessica Scarlet Wedding", "Prepare yourself for this explendid wedding.", "25/08/2024", "3:00 pm", "reception", receptionAddress, "myperfectweddingprogram@gmail.com");


        Console.WriteLine("--------------------------------------------------------------------------------------");

        Console.WriteLine("STANDART DETAILS:");
        reception.GetStandardDetails();
        Console.WriteLine();
        Console.WriteLine("FULL DETAILS:");
        reception.GetFullDetailsReception();
        Console.WriteLine();
        Console.WriteLine("SHORT DETAILS:");
        reception.GetShortDetails();

        Console.WriteLine("--------------------------------------------------------------------------------------");
        Console.WriteLine();

        // Outdoor Event //
        Address address3 = new Address("42 Wallaby Way", "Sydney", "New South Wales", "Australia");
        string outdoorAdress = address3.GetAddress();

        Outdoors outdoor = new Outdoors("Exotic fish Aquarium", "Come to see the most diverse and strange fishes in the world!", "30/03/2024", "8:30 am ~ 21:00 pm", "Outdoor", outdoorAdress, "Heavy Rain");


        Console.WriteLine("--------------------------------------------------------------------------------------");

        Console.WriteLine("STANDART DETAILS:");
        outdoor.GetStandardDetails();
        Console.WriteLine();
        Console.WriteLine("FULL DETAILS:");
        outdoor.GetFullDetailsOutdoor();
        Console.WriteLine();
        Console.WriteLine("SHORT DETAILS:");
        outdoor.GetShortDetails();

        Console.WriteLine("--------------------------------------------------------------------------------------");
    }
}