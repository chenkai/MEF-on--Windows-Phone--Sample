using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Collections.Generic;

namespace MEFCommon.Data
{
   public interface IAppCatalog
    {
       bool AddCatalog(AppCatalog newAppCatalog);
       List<AppCatalog> GetAllAppCatalogList();
    }
}
