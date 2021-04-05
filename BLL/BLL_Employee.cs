using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL;
using DTO;

namespace BLL
{
    public class BLL_Employee
    {
        DAL_Employee dalEmployee = new DAL_Employee();

        public string login(string username, string pass)
        {
            return dalEmployee.getID(username, pass);
        }
    }
}
