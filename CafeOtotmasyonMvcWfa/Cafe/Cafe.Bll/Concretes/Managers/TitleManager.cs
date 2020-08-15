using Cafe.Bll.Abstracts;
using Cafe.Dal.Abstracts;
using Cafe.Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe.Bll.Concretes.Managers
{
    public class TitleManager : ITitleService
    {
        ITitleDal _titleDal;
        private static TitleManager _titleManager;

        public TitleManager(ITitleDal titleDal)
        {
            _titleDal = titleDal;
        }

        public static TitleManager CreateSingleton(ITitleDal titleDal)
        {
            if (_titleManager == null)
            {
                _titleManager = new TitleManager(titleDal);
            }

            return _titleManager;
        }
        public void AddTitle(Title title)
        {
            if (title != null)
            {
                _titleDal.Add(title);
            }
            else
            {
                throw new Exception("Hata oldu");
            }
        }

        public void DeleteTitle(int id)
        {
            if (id > 1)
            {
                _titleDal.Delete(new Title { TitleID = id });
            }
            else
            {
                throw new Exception("Hata oldu");
            }
        }

        public Title GetTitle(int id)
        {
            return _titleDal.Get(p => p.TitleID == id);
        }

        public List<Title> GetTitles()
        {
            return _titleDal.GetAll();
        }

        public void UpdateTitle(Title title)
        {
            if (title != null)
            {
                _titleDal.Update(title);
            }
            else
            {
                throw new Exception("Hata oldu");
            }
        }
    }
}
