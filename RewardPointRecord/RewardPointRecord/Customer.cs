using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RewardPointRecord
{
    class Customer
    {
        //fields
        private int _customerID;
        
        private TransactionRecord[] _month1Record;
        private TransactionRecord[] _month2Record;
        private TransactionRecord[] _month3Record;
        private int _month1Points;
        private int _month2Points;
        private int _month3Points;
        private int _totalPoints;

        //constructor
        public Customer(int customerID)
        {
            _customerID = customerID;
            
        }
        //getters
        public int GetCustomerID()
        {
            return _customerID;
        }

        public TransactionRecord[] GetMonth1Record()
        {
            return _month1Record;
        }

        public TransactionRecord[] GetMonth2Record()
        {
            return _month2Record;
        }
        public TransactionRecord[] GetMonth3Record()
        {
            return _month3Record;
        }
        //setters
        public void setArrays(int[] month1Values, int[] month2Values, int[] month3Values)
        {
            _month1Record = new TransactionRecord[month1Values.Length];
            for(int i = 0; i < _month1Record.Length; ++i)
            {
                _month1Record[i] = new TransactionRecord(month1Values[i]);
            }

            _month2Record = new TransactionRecord[month2Values.Length];
            for (int i = 0; i < _month2Record.Length; ++i)
            {
                _month2Record[i] = new TransactionRecord(month2Values[i]);
            }
            _month3Record = new TransactionRecord[month3Values.Length];
            for (int i = 0; i < _month3Record.Length; ++i)
            {
                _month3Record[i] = new TransactionRecord(month3Values[i]);
            }

        }

       public int CalculateMonth1Points()
        {
            int month1Points = 0;
            for (int i = 0; i < _month1Record.Length; ++i)
            {               
                month1Points += _month1Record[i].CalculatePointValue();                    
            }
            _month1Points = month1Points;
            return _month1Points;
        }
        public int CalculateMonth2Points()
        {
            int month2Points = 0;
            for (int i = 0; i < _month2Record.Length; ++i)
            {
               
                month2Points += _month2Record[i].CalculatePointValue();
            }
            _month2Points = month2Points;
            return _month2Points;
        }
        public int CalculateMonth3Points()
        {
            int month3Points = 0;
            for (int i = 0; i < _month3Record.Length; ++i)
            {
                month3Points += _month3Record[i].CalculatePointValue();
            }
            _month3Points = month3Points;
            return _month3Points;
        }
        public int CalculateTotalPoints()
        {
            _totalPoints = CalculateMonth1Points() + CalculateMonth2Points() + CalculateMonth3Points();
            return _totalPoints;
        }
    }
}
