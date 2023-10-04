using System;

namespace WindowsDatabase.Classes.Database.Table
{
    public class Order
    {
        private int _id;
        private DateTime _dateOrder;
        private DateTime _dateDelivery;
        private PointIssue _pointIssue;
        private User _user;
        private int _code;
        private StatusOrder _status;
        private CollectionOrder _collectionOrder;

        public Order(int id, DateTime dateOrder, DateTime dateDelivery, PointIssue pointIssue, int code, 
            StatusOrder status, CollectionOrder collectionOrder, User user = null)
        {
            _id = id;
            _dateOrder = dateOrder;
            _dateDelivery = dateDelivery;
            _pointIssue = pointIssue;
            _code = code;
            _status = status;
            _collectionOrder = collectionOrder;
            _user = user;
            if (_user == null)
                _user = User.DefaultUser;
        }

        public int Id => _id;
        public DateTime DateOrder => _dateOrder;
        public DateTime DateDelivery => _dateDelivery;
        public PointIssue PointIssue => _pointIssue;
        public User User => _user;
        public int Code => _code;
        public StatusOrder Status => _status;
    }
}
