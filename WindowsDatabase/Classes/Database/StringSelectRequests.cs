using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsDatabase.Classes.Database
{
    public class StringSelectRequests
    {
        private string _mainSelect;
        private string _orderBy;
        private string _page;
        private Queue<(string, bool)> _where;

        public StringSelectRequests(string select)
        {
            _mainSelect = select;
            _orderBy = string.Empty;
            _page = string.Empty;
            _where = new Queue<(string, bool)>();
        }

        public static StringSelectRequests GetNewSelect(string sql) 
            => new StringSelectRequests(sql);

        public string GetRequest()
        {
            string request = _mainSelect;
            var tmpQueue = new Queue<(string, bool)>(_where);

            if (_where.Count > 0)
                request += "WHERE ";
            while(_where.Count > 0)
            {
                var where = _where.Dequeue();
                bool value = where.Item2;
                request += where.Item1;
                if (_where.Count != 0)
                    request += where.Item2 ? "AND " : "OR ";
            }
            request += _orderBy;
            return request + _page;
        }

        public StringSelectRequests SetOrderBy(string nameAttributeOrder, bool isIncreasing = true)
        {
            string _sorting = isIncreasing ? "ASC" : "DESC";
            _orderBy = $"Order by [{nameAttributeOrder}] {_sorting} ";
            return this;
        }
        public StringSelectRequests SetPage(int count, int page)
        {
            _page = $"Offset {page * count} Rows " +
                    $"Fetch Next {count} Rows only";
            return this;
        }

        public StringSelectRequests AddWhereLike(string nameAttributeWhere, string value, bool isAnd = false)
        {
            string newWhere = AddWhere(nameAttributeWhere, "LIKE", value);
            _where.Enqueue((newWhere, isAnd));
            return this;
        }

        public StringSelectRequests AddWhereEqually(string nameAttributeWhere, string value, bool isAnd = true)
        {
            string newWhere = AddWhere(nameAttributeWhere, "=", value);
            _where.Enqueue((newWhere, isAnd));
            return this;
        }

        public StringSelectRequests AddWhereIn(string nameAttributeWhere, StringSelectRequests requests, bool isAnd = true)
        {
            string newWhere = $"[{nameAttributeWhere}] IN ({requests.GetRequest()})";
            _where.Enqueue((newWhere, isAnd));
            return this;
        }

        private string AddWhere(string nameAttributeWhere, string condition, string value) 
            => $"[{nameAttributeWhere}] {condition} '{value}' ";
    }
}
