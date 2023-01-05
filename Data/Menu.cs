using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WTF.api.Data
{
    public class Menu
    {
        [Key]
        public int Id { get; set; }
        public string MenuName { get; set; }= "Default Menu Name";
        public List<Item> Items { get; set; }
    }
}