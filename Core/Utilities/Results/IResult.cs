using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //Temel voidler için  başlangıc
  public  interface IResult
    {
        bool Success { get; }//get sadece okunabilir Sonuç basarılı{get;}ysa 
        string Message { get; }//Bilgilendirme 


    }
}
