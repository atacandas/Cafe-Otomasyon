using Cafe.Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe.Bll.Abstracts
{
    public interface ITitleService
    {
        List<Title> GetTitles();
        Title GetTitle(int id);
        void AddTitle(Title title);
        void UpdateTitle(Title title);
        void DeleteTitle(int id);
    }
}
