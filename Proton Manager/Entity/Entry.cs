using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proton_Manager.Entity
{
    public class Entry: ICloneable
    {
        private string uuid;

        [Browsable(false)]
        public string UUID
        {
            get => uuid;
            set => uuid = value;
        }

        private string title;

        [DisplayName("Title")]
        public string Title
        {
            get => title;
            set => title = value;
        }

        private string username;

        [DisplayName("Username")]
        public string Username
        {
            get => username;
            set => username = value;
        }

        private string password;

        [DisplayName("Password")]
        public string Password
        {
            get => password;
            set => password = value;
        }

        private string link;

        [DisplayName("Link(URL")]
        public string Link
        {
            get => link;
            set => link = value;
        }

        private DateTime createdAt;

        [DisplayName("Creation Date")]
        public DateTime CreatedAt
        {
            get => createdAt;
            set => createdAt = value;
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}