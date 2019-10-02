using System;
using System.Text;
using MailSender.lib.Services.InMemory;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MailSender.lib.Entityes.Base;

namespace MailSender.lib.Tests.Services.InMemory
{
    /// <summary>
    /// Сводное описание для InMemoryRecipientDataProvider
    /// </summary>
    [TestClass]
    public class InMemoryRecipientsDataProvider
    {
        [TestMethod]
        public void CreateNewRecipientInEmptyProvider()
        {
            var data_provider = new InMemoryRecipientDataProvider();
            var expected_recipient_name = "Получатель 1";
            var expected_recipient_address = "recipient1@server.com";
            var expected_id = 1;
            var new_recipient = new Recipient
            {
                Name = expected_recipient_name,
                Address = expected_recipient_address

            };

            data_provider.Create(new_recipient);
            var actual_id = new_recipient.Id;
            var actual_recpient = data_provider.GetById(expected_id);

            Assert.AreEqual(expected_id, actual_id);
            Assert.AreEqual(expected_recipient_name, actual_recpient.Name);
            Assert.AreEqual(expected_recipient_address, actual_recpient.Address);
        }
    }
}
