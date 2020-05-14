using App.IServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Exceptions
{
  public class InvalidParametersException<T> : Exception 
    where T: IService
  {
  }
}