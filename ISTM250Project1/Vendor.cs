using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISYS250HW
{
    public class Vendor
	{
        private string Vname;
        private string Vstreetaddress;
        private string Vcity;
        private string Vstate;
        private string Vzipcode;
        private string Vphone;
        private decimal Vsalestodate;
        private string Vsalesrepname;
        private string Vcomments;
        private int Vdiscount;

        public Vendor() { }

        public Vendor(string Vname, string Vstreetaddress, string Vcity, string Vstate, string Vzipcode, string Vphone, decimal Vsalestodate, string Vsalesrepname, string Vcomments, int Vdiscount)
        {
            this.Name = Vname;
            this.Address = Vstreetaddress;
            this.City = Vcity;
            this.State = Vstate;
            this.Zip = Vzipcode;
            this.Phone = Vphone;
            this.YTD = Vsalestodate;
            this.Contact = Vsalesrepname;
            this.Comment = Vcomments;
            this.DefaultDiscount = Vdiscount;
        }
        public string Name
        {
            get
            {
                return Vname;
            }
            set
            {
                Vname = value;
            }
        }

        public string Address
        {
            get
            {
                return Vstreetaddress;
            }
            set
            {
                Vstreetaddress = value;
            }
        }

        public string City
        {
            get
            {
                return Vcity;
            }
            set
            {
                Vcity = value;
            }
        }

        public string State
        {
            get
            {
                return Vstate;
            }
            set
            {
                Vstate = value;
            }
        }
        public string Zip
        {
            get
            {
                return Vzipcode;
            }
            set
            {
                Vzipcode = value;
            }
        }
        public string Phone
        {
            get
            {
                return Vphone;
            }
            set
            {
                Vphone = value;
            }
        }
        public decimal YTD
        {
            get
            {
                return Vsalestodate;
            }
            set
            {
                Vsalestodate = value;
            }
        }
        public string Contact
        {
            get
            {
                return Vsalesrepname;
            }
            set
            {
                Vsalesrepname = value;
            }
        }
        public string Comment
        {
            get
            {
                return Vcomments;
            }
            set
            {
                Vcomments = value;
            }
        }
        public int DefaultDiscount
        {
            get
            {
                return Vdiscount;
            }
            set
            {
                Vdiscount = value;
            }
        }

        public string GetDisplayText()
        {
            return Vname + ", " + Vstreetaddress + ", " + Vcity + ". " + Vzipcode + ", " + Vphone + ", " + Vsalestodate.ToString()
                + ", " + Vsalesrepname + ", " + Vcomments + ", " + Vdiscount.ToString() + ".";
        }
        public string GetDisplayText(string sep)
        {
            return Vname + sep + Vstreetaddress + sep + Vcity + sep + Vzipcode + sep + Vphone + sep + Vsalestodate.ToString()
                + sep + Vsalesrepname + sep + Vcomments + sep + Vdiscount.ToString() + ".";
        }

    }
}
