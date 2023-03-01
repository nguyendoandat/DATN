using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Project.Data.Entities;
using Project.Service.File;
using Project.Service.Interface;
using Project.Service.Repository;
using Project.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.Service.implement
{
    public class MediasService : IMediasService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IFileService _file;
        private readonly IHostingEnvironment environment;
        public MediasService(IUnitOfWork unitOfWork, IMapper mapper,IFileService file,IHostingEnvironment environment)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _file = file;
            this.environment = environment;
        }

        public void DeleteMedias(MediasDTO medias)
        {
            var model=_mapper.Map<Medias>(medias);
            _unitOfWork.GenericRepository<Medias>().Delete(model);
            _unitOfWork.Save();
            _file.DeleteFile(medias.Name);
        }

        public void DeleteMediasById(int id)
        {
            _unitOfWork.GenericRepository<Medias>().DeleteById(id);
            _unitOfWork.Save();
        }

        public IEnumerable<MediasDTO> GetMedias(Expression<Func<Medias, bool>> filter = null, Func<IQueryable<Medias>, IOrderedQueryable<Medias>> orderBy = null, string includeProperties = "")
        {
            return ConvertModelToModelViewList((List<Medias>)_unitOfWork.GenericRepository<Medias>().GetAll(filter, orderBy, includeProperties));
        }

        public MediasDTO GetMediasById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MediasDTO> GetMediasByProductId(int id)
        {
            throw new NotImplementedException();
        }

        public void InsertMedias(MediasDTO medias)
        {
            var model = _mapper.Map<Medias>(medias);
           // model.Name = _file.UpLoadFile(medias.File);
            _unitOfWork.GenericRepository<Medias>().Insert(model);
            _unitOfWork.Save();
        }

        public void UpdateMedias(MediasDTO medias)
        {
            throw new NotImplementedException();
        }

        private List<MediasDTO> ConvertModelToModelViewList(List<Medias> list)
        {
            return list.Select(x => _mapper.Map<MediasDTO>(x)).ToList();
        }
    }
}
