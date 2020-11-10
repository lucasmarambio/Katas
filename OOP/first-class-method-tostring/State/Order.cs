using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class Order
    {
        private IOrderState _orderState;

        public Order(IOrderState orderState)
        {
            _orderState = orderState;
        }

        public int Id { get; set; }
        public string Customer { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderStatus Status
        {
            get
            {
                return _orderState.Status;
            }
        }
        public bool CanCancel()
        {
            return _orderState.CanCancel(this);
        }
        public void Cancel()
        {
            if (CanCancel())
                _orderState.Cancel(this);
        }
        public bool CanShip()
        {
            return _orderState.CanShip(this);
        }
        public void Ship()
        {
            if (CanShip())
                _orderState.Ship(this);
        }

        void Change(IOrderState orderState)
        {
            _orderState = orderState;
        }
    }
}
