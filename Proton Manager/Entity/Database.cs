using Proton_Manager.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Proton_Manager.Entity
{
    public class Database
    {
        private string hash;

        [JsonIgnore]
        public string Hash
        {
            get => hash;
            set => hash = value;
        }

        private BindingList<Entry> entries;
        public BindingList<Entry> Entries
        {
            get => entries;
            set => entries = value;
        }

        public Database()
        {
            entries = new BindingList<Entry>();
        }
    }
}