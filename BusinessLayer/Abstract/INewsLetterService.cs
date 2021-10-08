using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface INewsLetterService
    {
        void NewsLetterAdd(NewsLetter newsLetter);
        void NewsLetterDelete(NewsLetter newsLetter);
        void NewsLetterUpdate(NewsLetter newsLetter);
        NewsLetter GetById(int id);
        List<NewsLetter> GetList();
    }
}
