using RedibaScanner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedibaScanner.ViewModels
{
    public class MyResultPageViewModel
    {
        public List<MyResult> list { get; set; }

        public MyResultPageViewModel()
        {
            //dobavljanje podataka
            list = new List<MyResult>();
            list.Add(new MyResult() { Name = "Uzorci u analizi", Count = 2 });
            list.Add(new MyResult() { Name = "Potvrđene vrste", Count = 2 });


        }
    }
}
