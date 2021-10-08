using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class NewsLetterManager : INewsLetterService
    {
        INewsLetterDal _newsLetter;

        public NewsLetterManager(INewsLetterDal newsLetter)
        {
            _newsLetter = newsLetter;
        }

        public NewsLetter GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<NewsLetter> GetList()
        {
            throw new NotImplementedException();
        }

        public void NewsLetterAdd(NewsLetter newsLetter)
        {
            _newsLetter.Insert(newsLetter);
        }

        public void NewsLetterDelete(NewsLetter newsLetter)
        {
            throw new NotImplementedException();
        }

        public void NewsLetterUpdate(NewsLetter newsLetter)
        {
            throw new NotImplementedException();
        }
    }
}
