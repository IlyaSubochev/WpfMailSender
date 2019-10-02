
using MailSender.lib.Entityes.Base;
using MailSender.lib.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSender.lib.Services
{
    public class Linq2SqlRecipientsDataProvider : IRecipientsDataProvider
    {
        private readonly Data.Linq2SQL.MailSenderDBDataContext _db;
        public Linq2SqlRecipientsDataProvider(Data.Linq2SQL.MailSenderDBDataContext db) { _db = db; }

        public IEnumerable<Recipient> GetAll() => _db.Recepients.ToArray().Select(r => new Recipient
        {
            Id = r.Id,
            Name = r.Name,
            Address = r.Adress
        });
        
        

        public int Create(Recipient recipient)
        {
            if (recipient is null) throw new ArgumentException(nameof(recipient));
            if (recipient.Id != 0) return recipient.Id;
            var entity = new Data.Linq2SQL.Recepient
            {
                Name = recipient.Name,
                Adress = recipient.Address
            };
            _db.Recepients.InsertOnSubmit(entity);
            SaveChanges();
            return recipient.Id;
        }

        public void SaveChanges() => _db.SubmitChanges();

        public Recipient GetById(int id)
        {
            var db_item = _db.Recepients.FirstOrDefault(r => r.Id == id);
            return db_item is null
                ? null
                : new Recipient
                {
                    Id = db_item.Id,
                    Name = db_item.Name,
                    Address = db_item.Adress
                };
        }

        public void Edit(int id, Recipient item)
        {
            var db_item = _db.Recepients.FirstOrDefault(r => r.Id == id);
            if (db_item is null) return;
            db_item.Name = item.Name;
            db_item.Adress = item.Address;

            SaveChanges();
        }

        public bool Remove(int id)
        {
            var db_item = _db.Recepients.FirstOrDefault(r => r.Id == id);
            if (db_item is null) return false;

            _db.Recepients.DeleteOnSubmit(db_item);
            SaveChanges();
            return true;

        }
    }
}
