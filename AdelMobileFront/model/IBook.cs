using System;
using System.Collections.Generic;
using System.Text;

namespace AdelMobileFront.model
{
   public interface IBook
    {
         string title { get; set; }
         int comments { get; set; }
         int likes { get; set; }
    }
   internal class Wool : IBook
    {
        public string title { get; set; }
        public int comments { get; set; }
        public int likes { get; set; }
    }
    internal class Prayer : IBook
    {
        public string title { get; set; }
        public int comments { get; set; }
        public int likes { get; set; }
    }
    internal class Portrait : IBook
    {
        public string title { get; set; }
        public int comments { get; set; }
        public int likes { get; set; }
    }
    internal class Rubin : IBook
    {
        public string title { get; set; }
        public int comments { get; set; }
        public int likes { get; set; }
    }
}
