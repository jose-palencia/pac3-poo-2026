using RRHH.API.Dtos.Common;
using RRHH.API.Dtos.Employees;

namespace RRHH.API.Services.Employees
{
    public interface IEmployeeService
    {
        ResponseDto<PageDto<List<EmployeeDto>>> GetPage(string searchTerm = "", int page = 1, int pageSize  = 10);
        ResponseDto<EmployeeOneDto> GetOneById(Guid id);
        ResponseDto<EmployeeActionResponseDto> Create(EmployeeCreateDto dto);
        ResponseDto<EmployeeActionResponseDto> Edit(Guid id, EmployeeEditDto dto);
        ResponseDto<EmployeeActionResponseDto> Delete(Guid id);
    }
}