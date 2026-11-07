using RRHH.API.Dtos.Common;
using RRHH.API.Dtos.Employees;
using RRHH.API.Entities;

namespace RRHH.API.Services.Employees
{
    public class EmployeeService : IEmployeeService
    {
        public ResponseDto<PageDto<List<EmployeeDto>>> GetPage(string searchTerm = "", int page = 1, int pageSize  = 10)
        {
            throw new NotImplementedException();
        }

        public ResponseDto<EmployeeOneDto> GetOneById(Guid id)
        {
            throw new NotImplementedException();
        }

        public ResponseDto<EmployeeActionResponseDto> Create(EmployeeCreateDto dto)
        {
            throw new NotImplementedException();
        }

        public ResponseDto<EmployeeActionResponseDto> Edit(Guid id, EmployeeEditDto dto)
        {
            throw new NotImplementedException();
        }

        public ResponseDto<EmployeeActionResponseDto> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

    }
}