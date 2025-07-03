using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMS.AccessData.Entites.Enums
{
        public enum enStatus 
        {
            Pending = 0 ,
            InProgress = 1  ,
            Completed = 2   ,
            Delayed = 4
        };

        public enum enPriority
        {
            Low =0,
            Medium = 1,
            High = 2

        }

       
    
}
