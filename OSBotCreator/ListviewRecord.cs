using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OSBotCreator
{
    public class ListviewRecord
    {
        public string name, memory, account,script,jar;        
        public ListviewRecord(string _name, string _memory, string _account, string _script, string _jar)
        {
            this.name = _name;
            this.memory = _memory;
            this.account = _account;
            this.script = _script;
            this.jar = _jar;
        }
    }
}
