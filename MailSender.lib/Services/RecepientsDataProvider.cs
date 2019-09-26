﻿using MailSender.lib.Data.Linq2SQL;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSender.lib.Services
{
    public class RecipientsDataProvider
    {
        private readonly MailSenderDBDataContext _db;
        public RecipientsDataProvider(MailSenderDBDataContext db) { _db = db; }

        public IEnumerable<Recepient> GetAll()
        {
            _db.Refresh(RefreshMode.OverwriteCurrentValues);
            return _db.Recepients.ToArray();
        }

        public int Create(Recepient recipient)
        {
            if (recipient is null) throw new ArgumentException(nameof(recipient));
            _db.Recepients.InsertOnSubmit(recipient);
            SaveChanges();
            return recipient.Id;
        }

        public void SaveChanges()
        {
            _db.SubmitChanges();
        }



    }
}
