using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentOperations
{
    public class Options
    {
        private ICommand openCommand;
        private ICommand saveCommand;
        private ICommand closeCommand;
        public Options(ICommand open, ICommand save, ICommand close)
        {
            this.openCommand = open;
            this.saveCommand = save;
            this.closeCommand = close;
        }
        public void clickOpen()
        {
            openCommand.Execute();
        }
        public void clickSave()
        {
            saveCommand.Execute();
        }
        public void clickClose()
        {
            closeCommand.Execute();
        }
    }
}
