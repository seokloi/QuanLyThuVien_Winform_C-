using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL;
using DTO;

namespace BLL
{
    public class BLL_Reader
    {
        DAL_Reader dalReader = new DAL_Reader();

        public DataTable getReader()
        {
            return dalReader.getReader();
        }
        public bool xoaReader(int Reader_ID)
        {
            return dalReader.xoaReader(Reader_ID);
        }
        public bool themReader(DTO_DOCGIA user)
        {
            return dalReader.themReader(user);
        }
        public bool suaReader(DTO_DOCGIA user)
        {
            return dalReader.suaReader(user);
        }
    }
}