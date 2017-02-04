using RedibaScanner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedibaScanner.ViewModels
{
    public class MySpeciesPagePageViewModel
    {
        public List<MySpecies> list { get; set; }

        public MySpeciesPagePageViewModel()
        {
            //dobavljanje podataka
            list = new List<MySpecies>();
            list.Add(new MySpecies() { Name = "Ime vrste 1", Description="Mislim da je slon"});
            list.Add(new MySpecies() { Name = "Ime vrste 2", Description = "Mislim da je tigar" });


        }
    }
}
