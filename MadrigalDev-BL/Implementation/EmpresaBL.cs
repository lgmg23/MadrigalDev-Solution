using MadrigalDev_BL.Interface;
using MadrigalDev_Model.EmpresaModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.Mappers;
using MadrigalDev_DAL;

namespace MadrigalDev_BL.Implementation
{
    public class EmpresaBL : EmpresaBLInterface
    {
        public EmpresaBL()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMissingTypeMaps = true;
                cfg.CreateMap<t_empresa, EmpresaModel>();
                cfg.CreateMap<EmpresaModel, t_empresa>();
            }
            );
        }
        
        public Task AddEmpresa(EmpresaModel model)
        {
            try
            {
                var _context = new madrigaldev_testEntities();
                var empresaAdded = new t_empresa();
                var empresaToAdd = Mapper.Map<t_empresa>(model);
                empresaAdded = _context.t_empresa.Add(empresaToAdd);
                _context.SaveChanges();
                return Task.FromResult(empresaAdded);
            }
            catch(Exception ex)
            {
                throw ex;
            }            
        }

        public Task<int> DeleteEmpresa(EmpresaModel model)
        {
            throw new NotImplementedException();
        }

        public Task<List<EmpresaModel>> GetEmpreas()
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateEmpresa(EmpresaModel model)
        {
            throw new NotImplementedException();
        }
    }
}
