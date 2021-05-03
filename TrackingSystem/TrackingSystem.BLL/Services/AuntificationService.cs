using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackingSystem.BLL.DTO;
using TrackingSystem.DAL.EF;
using TrackingSystem.DAL.Interfaces;

namespace TrackingSystem.BLL.Services
{
    
    public class AuntificationService
    {
        private readonly EFUnitOfWork _unitOfWork;
        public AuntificationService(EFUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void SignIn(UserDTO user)
        {

        }
        public void PasswordSignIN()
        {

        }
    }
}
