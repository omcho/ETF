using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RedibaScanner.Models
{
    public class CustomImage
    {
        public string Url { get; set; }
        public string ShortDesc { get; set; }
        public ICommand PictureTapCommand { get; set; }
        public string ImageLocation { get; set; }
}
}
