using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL;
using DTO;

namespace BLL
{
    public class BLL_Book
    {
        DAL_Book dalBook = new DAL_Book();

        public DataTable getBook()
        {
            return dalBook.getBook();
        }
        public bool xoaBook(int Book_ID)
        {
            return dalBook.xoaBook(Book_ID);
        }
        public bool themBook(DTO_SACH book)
        {
            return dalBook.themBook(book);
        }
        public bool suaBook(DTO_SACH book)
        {
            return dalBook.suaBook(book);
        }
    }
}