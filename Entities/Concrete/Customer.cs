using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Entities.Concrete
{
    [Keyless]
    public class Customer:IEntity
    {
        public int UserId { get; set; }
        public string CompanyName { get; set; }
    }
}
