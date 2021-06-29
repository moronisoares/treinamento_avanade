﻿using Avanade.SubTCSE.Projeto.Application.DTOs.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanade.SubTCSE.Projeto.Application.Interfaces.Employee
{
    public interface IEmployeeAppService
    {
        Task<EmployeeDTO> AddEmployee(EmployeeDTO employeeDTO);
    }
}
