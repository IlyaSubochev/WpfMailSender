using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSender.lib.Entityes.Base
{
    public class Recipient : HumanEntity, IDataErrorInfo
    
    {
      
        public override string Name
        {
            get => base.Name;
            set
            {
                base.Name = value;
            }
        }

        string IDataErrorInfo.Error => "";

        string IDataErrorInfo.this[string PropertyName]
        {
            get
            {
                switch (PropertyName)
                {
                    default: return string.Empty;

                    case nameof(Name):
                        var name = Name;
                        if (name is null) return "Отсутсвует ссылка на строку с именем";
                        if (name.Length < 4) return "Имя должно быть длиннее 3-х символов";
                        if (!char.IsLetter(name[0])) return "Имя должно начинаться с буквы";
                        return string.Empty;

                }
            }

        }
    }
}
