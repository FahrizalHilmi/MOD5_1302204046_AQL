using System;

namespace MOD5_1302204046_AQL
{
    class Program
    {
        static void Main(string[] args)
        {
            SayaTubeVideo s = new SayaTubeVideo("REVIEW FILM HORROR INDONESIA");
            SayaTubeVideo MV1 = new SayaTubeVideo("Review 365 Day oleh Fahrizal Hilmi");
            SayaTubeVideo MV2 = new SayaTubeVideo("Review Tali Pocong Perawan oleh Fahrizal Hilmi");
            SayaTubeVideo MV3 = new SayaTubeVideo("Paku Kuntilanak Day oleh Fahrizal Hilmi");
            SayaTubeVideo MV4 = new SayaTubeVideo("Review Bangkit Dari Lumpur oleh Fahrizal Hilmi");
            SayaTubeVideo MV5 = new SayaTubeVideo("Review Arisan Brondong oleh Fahrizal Hilmi");
            SayaTubeVideo MV6 = new SayaTubeVideo("Review Menculik Miyabi oleh Fahrizal Hilmi");
            SayaTubeVideo MV7 = new SayaTubeVideo("Review Arwah Kuntilanak Duyung oleh Fahrizal Hilmi");
            SayaTubeVideo MV8 = new SayaTubeVideo("Review Air Terjun Pengantin oleh Fahrizal Hilmi");
            SayaTubeVideo MV9 = new SayaTubeVideo("Review Pocong Keliling oleh Fahrizal Hilmi");
            SayaTubeVideo MV10 = new SayaTubeVideo("Review Suster Keramas oleh Fahrizal Hilmi");

            SayaTubeUser SJ = new SayaTubeUser("Fahrizal Hilmi");
            s.IncreasePlayCount(1);
            MV1.IncreasePlayCount(2);
            MV2.IncreasePlayCount(3);
            MV3.IncreasePlayCount(4);
            MV4.IncreasePlayCount(5);
            MV5.IncreasePlayCount(6);
            MV6.IncreasePlayCount(7);
            MV7.IncreasePlayCount(8);
            MV8.IncreasePlayCount(9);
            MV9.IncreasePlayCount(10);
            MV10.IncreasePlayCount(11);


            SJ.AddVideo(s);
            SJ.AddVideo(MV1);
            SJ.AddVideo(MV2);
            SJ.AddVideo(MV3);
            SJ.AddVideo(MV4);
            SJ.AddVideo(MV5);
            SJ.AddVideo(MV6);
            SJ.AddVideo(MV7);
            SJ.AddVideo(MV8);
            SJ.AddVideo(MV9);
            SJ.AddVideo(MV10);


            s.PrintVideoDetails();

            SJ.PrintAllVideoPlaycount();
        }
    }
}