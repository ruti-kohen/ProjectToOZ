using ProjectToOZ.Models;
using System;
using System.Net.Http;

namespace ProjectToOZ.Dal
{
    public class CandidateDal : ICandidateDal
    {
        private readonly HttpClient _httpClient;

        public CandidateDal(HttpClient httpClient)
        {
            this._httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient)); ;
        }

        List<Candidate> candidateList = new List<Candidate>()
        {
            new Candidate(){Id="333",Name="shani",BeginYear=new DateTime(2005, 12, 12),LastUpdateDate=new DateTime(2020, 11, 11),Languages=new List<Languages>{Languages.c,Languages.angular}},
            new Candidate(){Id="444",Name="riki",BeginYear=new DateTime(2003, 12, 12),LastUpdateDate=new DateTime(2018, 11, 11),Languages=new List<Languages>{Languages.c,Languages.python}},
            new Candidate(){Id="555",Name="shani",BeginYear=new DateTime(2008, 12, 12),LastUpdateDate=new DateTime(2023, 11, 11),Languages=new List<Languages>{Languages.java,Languages.js}}
        };
        //הפונקציה הזו מביאה את הנתונים מהקובץ JSON
        public async Task<string> GetCandidates()
        {
            {

                try
                {
                    var client = new HttpClient();
                    var response = await client.GetAsync("https://raw.githubusercontent.com/ozsoftware/canidates/main/db.json");
                    var conect = await response.Content.ReadAsStringAsync();
                    return conect;

                }
                catch (Exception exception)
                {
                    Console.WriteLine("Exception");
                    Console.WriteLine(exception);
                    return null;
                }

            }
        }
        //הפונקציה הזו מביאה את הנתונים מהLIST שנמצא פה
        public async Task<List<Candidate>> GetCandidatesList()
        {

            return candidateList;
                
        }

    }
}





//public async Task<string> GetCandidates()
//{
//    {

//        try
//        {
//            var client = new HttpClient();
//            var response = await client.GetAsync("https://github.com/ozsoftware/canidates/blob/main/db.json");
//            var conect = await response.Content.ReadAsStringAsync();
//            return conect;

//        }
//        catch (Exception exception)
//        {
//            Console.WriteLine("Exception");
//            Console.WriteLine(exception);
//            return null;
//        }

//    }
//}