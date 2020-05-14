using System;
using System.Collections.Generic;
using System.Text;
using Entity = Domain.Clientes;

namespace App.IServices
{
  public interface IReportService
  {
    decimal GerarRelatorio(Entity.Cliente cliente);
  }
}
