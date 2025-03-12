using BusinnesLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinnesLayer.Concrete
{
    public class WriterMessageManager : IWriterMessageService
    {
        private readonly IWriterMesasgeDal _writerMesasgeDal;

        public WriterMessageManager(IWriterMesasgeDal writerMesasgeDal)
        {
            _writerMesasgeDal = writerMesasgeDal;
        }

        public void TAdd(WriterMessage entity)
        {
            _writerMesasgeDal.Insert(entity);
        }

        public void TDelete(WriterMessage entity)
        {
            _writerMesasgeDal.Delete(entity);
        }

        public List<WriterMessage> TGetbyFilter(string p)
        {
            return _writerMesasgeDal.GetbyFilter(x=> x.Receiver == p);
        }

        public WriterMessage TGetByID(int id)
        {
            return _writerMesasgeDal.GetByID(id);
        }

        public List<WriterMessage> TGetList()
        {
            return _writerMesasgeDal.GetList();
        }

        public List<WriterMessage> TGetListReeiverMessage(string p)
        {
            return _writerMesasgeDal.GetbyFilter(x => x.Receiver == p);
        }

        public List<WriterMessage> TGetListSenderMessage(string p)
        {
            return _writerMesasgeDal.GetbyFilter(x => x.Sender == p);
        }

        public void TUpdate(WriterMessage entity)
        {
            _writerMesasgeDal.Update(entity);
        }
    }
}
