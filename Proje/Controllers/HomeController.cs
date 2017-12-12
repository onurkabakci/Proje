using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Proje.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Net.Http;
using Newtonsoft.Json;


namespace Proje.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        public void konumHesapla()
        {
            var centerLatitude = "40.9811925";
            var centerLongitude = "29.0280334";
            HttpClient client = new HttpClient();
            List<string> yolcuLokasyonu = new List<string>();
            yolcuLokasyonu.Add("maltepe");
            yolcuLokasyonu.Add("küçükyalı");
            yolcuLokasyonu.Add("bostancı");
            string url = "http://maps.googleapis.com/api/geocode/json?address={0}&sensor=false";
            var response = await client.GetAsync(string.Format(url, yolcuLokasyonu));
            string result = await response.Content.ReadAsStringAsync();
            RootObject root = JsonConvert.DeserializeObject<RootObject>(result);

            double Latitude = 0.0;
            double longitude = 0.0;
            strimg placeId;
            List<string> konumlar = new List<string>();
            foreach (var item in root.results)
            {
                Latitude = item.geometry.location.lat;
                longitude = item.geometry.location.lng;
                konumlar.Add(item);
                //konumları al listenin içine at
            }
            //varış noktasına, latitude ve longitude ile uzaklığı hesapla
            // küçükten büyüye sırala
            // varış noktasına yapılan km'yi en yakın araçla ve direkt yapıldıgında yolculuğu karşılaştır



        }
    }
}
