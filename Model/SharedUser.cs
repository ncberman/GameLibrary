namespace GameLibrary.Model
{
    public class SharedUser
    {
        private string _Username;
        public string Username { get { return _Username; } set { _Username = value; } }

        private List<string> _Characters;
        public List<string> Characters { get { return _Characters; } set { _Characters = value; } }

        public SharedUser(string name, List<string> characters) 
        {
            _Username = name; _Characters = characters;
        }
    }
}
