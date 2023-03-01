using Project.Data.Entities;
using Project.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.Service.Interface
{
    public interface IMediasService
    {
        IEnumerable<MediasDTO> GetMedias(Expression<Func<Medias, bool>> filter = null, Func<IQueryable<Medias>, IOrderedQueryable<Medias>> orderBy = null, string includeProperties = "");
        IEnumerable<MediasDTO> GetMediasByProductId(int id);
        MediasDTO GetMediasById(int id);
        void InsertMedias(MediasDTO medias);
        void UpdateMedias(MediasDTO medias);
        void DeleteMedias(MediasDTO medias);
        void DeleteMediasById(int id);
    }
}
