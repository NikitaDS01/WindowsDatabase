namespace WindowsDatabase.Classes.Database.Table
{
    public class PointIssue
    {
        private string _address;
        private string _index;

        public PointIssue(string address, string index)
        {
            _address = address;
            _index = index;
        }

        public string Address => _address;
        public string Index => _index;
    }
}
