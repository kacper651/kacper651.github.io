using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ZadDomMVC.Models;

namespace ZadDomMVC.Controllers
{
    public class HomeController : Controller
    {
        List<Champion> championsList;
        string descZed = "Całkowicie bezwzględny i pozbawiony litości, Zed jest przywódcą Zakonu Cienia, czyli organizacji," +
            " którą stworzył, kierując się zmilitaryzowaniem sztuk walki Ionii, by wypędzić noxiańskich najeźdźców." +
            " Podczas wojny desperacja sprawiła, że odnalazł sekretną formę cienia — nikczemną magię ducha, równie niebezpieczną i wypaczającą, co potężną." +
            " Zed stał się mistrzem tych zakazanych technik, by niszczyć wszystko, co mogłoby zagrażać jego narodowi lub nowemu zakonowi.";

        string descCait = "Znana jako najlepsza rozjemczyni, Caitlyn jest również najlepszą szansą Piltover na pozbycie się nieuchwytnych elementów kryminalnych z miasta." +
            " Często w parze z Vi, jest przystanią spokoju w porównaniu z żywiołowym charakterem jej partnerki." +
            " Pomimo tego, że korzysta z jedynego w swoim rodzaju karabinu pulsarowego, najpotężniejszą bronią Caitlyn jest jej ponadprzeciętna inteligencja," +
            " która pozwala jej na zastawianie skomplikowanych pułapek na przestępców na tyle głupich, by działać w Mieście Postępu.";

        string descKaisa = "Kai'Sa, dziewczyna porwana przez Pustkę, kiedy była jeszcze dzieckiem, przetrwała tylko dzięki wytrwałości i sile woli." +
            " Jej przeżycia sprawiły, że stała się zabójczą łowczynią, choć dla niektórych jest zwiastunką przyszłości, której nie chcieliby dożyć." +
            " Wdawszy się w niestabilną symbiozę z żywym pancerzem z Pustki, w końcu będzie musiała zdecydować, czy wybaczyć śmiertelnikom, którzy nazywają ją potworem," +
            " i wspólnie z nimi pokonać nadchodzącą ciemność... czy może po prostu zapomnieć, a wtedy Pustka pożre świat, który się od niej odwrócił.";

        string descDraven = "W Noxusie wojownicy znani jako walecznicy mierzą się ze sobą na arenach, gdzie przelewa się krew, a siłę poddaje się próbie." +
            " Jednakże żaden z nich nie był tak sławny jak Draven. Były żołnierz doszedł do wniosku, że tłum docenia jego smykałkę do dramatyczności, jak i niedościgniony kunszt," +
            " z jakim włada wirującymi toporami. Uzależniony od pokazu bezczelnej perfekcji, Draven poprzysiągł pokonać wszystkich, by to jego imię wiecznie powtarzano w całym imperium.";

        string descLucian = "Lucian, dawniej Strażnik Światła, stał się ponurym łowcą nieumarłych duchów. Jest bezwzględny w ściganiu i zabijaniu ich swoimi bliźniaczymi starożytnymi pistoletami." +
            " Gdy nikczemny upiór Thresh zabił jego żonę, Lucian zapragnął zemsty. Jednak nawet po jej powrocie do żywych, nie jest w stanie wyzbyć się gniewu." +
            " Bezwzględny i zaślepiony, nie cofnie się przed niczym, aby obronić żyjących przed nieumarłymi koszmarami Czarnej Mgły.";

        public HomeController()
        {
            championsList = new List<Champion>()
            {
                new Champion("Zed", "Władca Cieni", "Ionia", "Zabójca", "zed.jpg", descZed),
                new Champion("Caitlyn", "Szeryf Piltover", "Piltover", "Strzelec", "caitlyn.jpg", descCait),
                new Champion("Kai'sa", "Córa Pustki", "Pustka", "Strzelec", "kaisa.jpg", descKaisa),
                new Champion("Draven", "Wielki Oprawca", "Noxus", "Strzelec", "draven.jpg", descDraven),
                new Champion("Lucian", "Kleryk Broni", "Runeterra", "Strzelec", "lucian.jpg", descLucian)
            };
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Champions()
        {
            return View(championsList);
        }

        public IActionResult ChampionDetails(string name)
        {
            var champion = championsList.FirstOrDefault(c => c.Name == name);
            return View(champion);
        }

        //[HttpPost] //nie mam pojecia czemu nie dziala jedno z drugim
        //[ValidateAntiForgeryToken] 
        public IActionResult WriteComment([Bind("Content")] Comment comment)
        {
            if(ModelState.IsValid)
            {
                var content = comment.Content;
                ViewBag.comment = content;               
                return View("WrittenComment", comment);
            }
            else
            {
                var content = comment.Content;
                ViewBag.comment = content;
                return View(comment);
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}