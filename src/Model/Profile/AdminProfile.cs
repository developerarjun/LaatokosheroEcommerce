using System.ComponentModel.DataAnnotations;

namespace LaatokosheroBackEnd.src.Model.Profile
{
    public class AdminProfile
    {
        public int Id {get;set;}
        public byte[]  logoImage { get; set;}
        public string ContactNumber {get;set;}
        public string ContactAddress {get;set;}
        public string ContactAvailableTime {get;set;}
        public string FacebookUrl {get; set;}
        public string TwitterUrl {get;set;}
        public string YoutubeUrl {get;set;}
        public string InstagramUrl {get;set;}
    }
}