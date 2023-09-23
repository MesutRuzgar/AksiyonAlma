using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class StandardStances : IEntity
    {
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }      
        public string? ReasonForStopping { get; set; }
    }
}
