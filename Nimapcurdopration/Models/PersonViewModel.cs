using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nimapcurdopration.Models
{
    public class PersonViewModel
    {
        public List<Person> ListPerson { get; set; }
        public Pager pager { get; set; }
    }
}