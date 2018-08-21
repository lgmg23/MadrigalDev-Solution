using MadrigalDev_Model.EmpresaModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MadrigalDev_BL.Interface
{
    interface EmpresaBLInterface
    {
        Task AddEmpresa(EmpresaModel model);
        Task<int> UpdateEmpresa(EmpresaModel model);
        Task<List<EmpresaModel>> GetEmpreas();
        Task<int> DeleteEmpresa(EmpresaModel model);
    }
}
