using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cutomers
{
    public class CustomerBase
    {
        private DataObject dataObject;
        public DataObject Data
        {
            set { dataObject = value; }
            get { return dataObject; }
        }
        public virtual void Next()
        {
            dataObject.NextRecord();
        }
        public virtual void Prior()
        {
            dataObject.PriorRecord();
        }
        public virtual void Add(string customer)
        {
            dataObject.AddRecord(customer);
        }
        public virtual void Delete(string customer)
        {
            dataObject.DeleteRecord(customer);
        }
        public virtual void Show()
        {
            dataObject.ShowRecord();
        }
        public virtual void ShowAll()
        {
            dataObject.ShowAllRecords();
        }
    }
}
