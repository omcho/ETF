using RedibaScanner.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedibaScanner.Repository
{
    public static class SpeciesRepository
    {
        private static Random random;

        public static SpeciesSearchInfo GetRandomMonkey()
        {
            //var output = Newtonsoft.Json.JsonConvert.SerializeObject(Monkeys);
            return SpeciesSearchInfoColl[random.Next(0, SpeciesSearchInfoColl.Count)];
        }

        public static ObservableCollection<Grouping<string, SpeciesSearchInfo>> SpeciesSearchInfoCollGrouped { get; set; }
        public static ObservableCollection<SpeciesSearchInfo> SpeciesSearchInfoColl { get; set; }

        static SpeciesRepository()
        {
            random = new Random();
            SpeciesSearchInfoColl = new ObservableCollection<SpeciesSearchInfo>();
            SpeciesSearchInfoColl.Add(new SpeciesSearchInfo
            {
                Name = "Baboon Baboonos",
                LocationImage = new CustomImage()
                {
                    Url = "http://www.drodd.com/images13/world-map12.jpg",
                    ShortDesc = "Lokacija"
                },
                Location = "Jigokudani, u prijevodu “Dolina Pakla”, se nalazi u Yamanouchiu, Shimotakai Distrikt, u Japanu, a područje je poznato po svojoj surovoj klimi, surovom krajoliku, termalnim izvorima – i majmunima. Park je najpoznatiji po svojoj populaciji japanskih makaki majmuna.",
                Hierarchy = "Arthropoda, Malacostraca, Isopoda, Philosciidae, Philoscia, Philoscia muscorum",
                RecordsAvailableText = "Dostupno bilješki: 87514",
                PercentPublicText = "Javno: 34%",
                SpeciesCollectedText = "Sakupljeno vrsta: 301",
                Description = "Majmun je pojam čije se tomačenje na mnogim svjetskim jezicima bitno razlikuje od onog na Engleskom. Za sve repate majmune, Englezi imaju naziv monkey, koji se kod nas prevodi kao majmun, a diferenciraju naziv bezrepih, velikih majmuna (giboni, orangutani, gorile i čimpanze) imenicom ape. Kod nas je ovo odrednica odnosi na sve životinjske vrste iz sisarskog reda primata.Prema klasičnoj sistematizaciji, red primata se dijeli na dva podreda: u prvu grupu se ubrajaju svi polumajmuni (Prosimii), a u drugu repati majmuni i veliki majmuni, uključujući i čovjekolike majmune i ljude (Anthropoidea). Ovdje termin „majmun“ obuhvata Novog svijeta i majmune Starog svijeta (repate, tj psetolike i čovjekolike majmune, odnosno i širokonosne i uskonosne), uključujući i čovjeka i njegove neposredne pretke",
                Image = "http://upload.wikimedia.org/wikipedia/commons/thumb/f/fc/Papio_anubis_%28Serengeti%2C_2009%29.jpg/200px-Papio_anubis_%28Serengeti%2C_2009%29.jpg",
                Images = new List<CustomImage>() { new CustomImage() {

                            Url="http://www.mojportal.ba/slike/novosti/AAA%20ZANIMLJIVOSTI%202012/covjekoliki-majmun.jpg", ShortDesc="Joj"
                         },
                            new CustomImage() {

                            Url="http://www.simboli.rs/wp-content/uploads/majmun-simbolika-300px.jpg", ShortDesc="Joj2"
                            }
                    }
            });

            SpeciesSearchInfoColl.Add(new SpeciesSearchInfo
            {
                Name = "Capuchin Monkey",
                Description = "The capuchin monkeys are New World monkeys of the subfamily Cebinae. Prior to 2011, the subfamily contained only a single genus, Cebus.",
                Image = "http://upload.wikimedia.org/wikipedia/commons/thumb/4/40/Capuchin_Costa_Rica.jpg/200px-Capuchin_Costa_Rica.jpg",
                Images = new List<CustomImage>() { new CustomImage() {

                            Url="IDemo", ShortDesc="Joj"
                         },
                            new CustomImage() {

                            Url="IDemo", ShortDesc="Joj2"
                            }
                    }});

            SpeciesSearchInfoColl.Add(new SpeciesSearchInfo
            {
                Name = "Blue Monkey",
                Description = "The blue monkey or diademed monkey is a species of Old World monkey native to Central and East Africa, ranging from the upper Congo River basin east to the East African Rift and south to northern Angola and Zambia",
                Image = "http://upload.wikimedia.org/wikipedia/commons/thumb/8/83/BlueMonkey.jpg/220px-BlueMonkey.jpg",
                Images = new List<CustomImage>() { new CustomImage() {

                            Url="IDemo", ShortDesc="Joj"
                         },
                            new CustomImage() {

                            Url="IDemo", ShortDesc="Joj2"
                            }
                    }
            });


            SpeciesSearchInfoColl.Add(new SpeciesSearchInfo
            {
                Name = "Squirrel Monkey",
               Description = "The squirrel monkeys are the New World monkeys of the genus Saimiri. They are the only genus in the subfamily Saimirinae. The name of the genus Saimiri is of Tupi origin, and was also used as an English name by early researchers.",
                Image = "http://upload.wikimedia.org/wikipedia/commons/thumb/2/20/Saimiri_sciureus-1_Luc_Viatour.jpg/220px-Saimiri_sciureus-1_Luc_Viatour.jpg",
                Images = new List<CustomImage>() { new CustomImage() {

                            Url="IDemo", ShortDesc="Joj"
                         },
                            new CustomImage() {

                            Url="IDemo", ShortDesc="Joj2"
                            }
                    }
            });
            SpeciesSearchInfoColl.Add(new SpeciesSearchInfo
            {
                Name = "Golden Lion Tamarin",
                Description = "The golden lion tamarin also known as the golden marmoset, is a small New World monkey of the family Callitrichidae.",
                Image = "http://upload.wikimedia.org/wikipedia/commons/thumb/8/87/Golden_lion_tamarin_portrait3.jpg/220px-Golden_lion_tamarin_portrait3.jpg",
                Images = new List<CustomImage>() { new CustomImage() {

                            Url="IDemo", ShortDesc="Joj"
                         },
                            new CustomImage() {

                            Url="IDemo", ShortDesc="Joj2"
                            }
                    }
            });

            SpeciesSearchInfoColl.Add(new SpeciesSearchInfo
            {
                Name = "Howler Monkey",
                Description = "Howler monkeys are among the largest of the New World monkeys. Fifteen species are currently recognised. Previously classified in the family Cebidae, they are now placed in the family Atelidae.",
                Image = "http://upload.wikimedia.org/wikipedia/commons/thumb/0/0d/Alouatta_guariba.jpg/200px-Alouatta_guariba.jpg",
                Images = new List<CustomImage>() { new CustomImage() {

                            Url="IDemo", ShortDesc="Joj"
                         },
                            new CustomImage() {

                            Url="IDemo", ShortDesc="Joj2"
                            }
                    }
            });

            var sorted = from monkey in SpeciesSearchInfoColl
                         orderby monkey.Name
                         group monkey by monkey.NameSort into SpeciesGroup
                         select new Grouping<string, SpeciesSearchInfo>(SpeciesGroup.Key, SpeciesGroup);

            SpeciesSearchInfoCollGrouped = new ObservableCollection<Grouping<string, SpeciesSearchInfo>>(sorted);

        }
    }
}
