using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerEntityProject
{
    public class Customer
    {
        int _CustId;
        bool _Status;
        string _CName;
        double _Balance;
        public Customer(int CustId, bool Status, String CName, double Balance)
        {
            this._CustId = CustId;
            this._Status = Status;
            this._CName = CName;
            this._Balance = Balance;
        }
        public int CustId
        {
            get { return _CustId; }
            set { _CustId = value; }
        }
        public bool Status
        {
            get { return _Status; }
            set { _Status = value; }
        }
        public string CName
        {
            get { return _CName; }
            set
            {
                if (_Status ==true){ _CName = value; }

            }
        }
    }
}
