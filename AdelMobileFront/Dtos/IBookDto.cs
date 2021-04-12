using System;
using System.Collections.Generic;
using System.Text;

namespace AdelMobileFront.Dtos
{
    //DTO
   public interface IBookDto
    {
         string Title { get; set; }
         int Comments { get; set; }
         int Likes { get; set; }
    }
   internal class BookDto:IBookDto
    {
        public string Title { get; set; }
        public int Comments { get; set; }
        public int Likes { get; set; }
    }
    //MODELS
   internal class Wool : BookDto
    {
     
    }
    internal class Prayer : BookDto
    {
       
    }
    internal class Portrait : BookDto
    {
      
    }
    internal class Rubin : BookDto
    {
    
    }
}
