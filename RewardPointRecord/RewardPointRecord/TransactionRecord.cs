using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RewardPointRecord
{
    class TransactionRecord
    {
        //fields
 private int _monthOfPurchase;
        private int _purchaseValue;
        private int _pointValue;

        //constructor
        public TransactionRecord( int purchaseValue)
        {
           
            _purchaseValue = purchaseValue;
        }
        //getters 
        public Double GetPurchaseValue()
        {
            return _purchaseValue;
        }

        public int CalculatePointValue()
        {
            //calculates and returns the point Value

            if (_purchaseValue > 50 && _purchaseValue <= 100)
            {  
                _pointValue = _purchaseValue - 50;
            }
            else if(_purchaseValue > 100)
            {
                _pointValue = 50 + ((_purchaseValue - 100) * 2);
            }
            else
            {
                _pointValue = 0;
            }
            return _pointValue;
        }
    }
}
