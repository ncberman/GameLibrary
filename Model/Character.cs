namespace GameLibrary.Model
{
    public class Character
    {
        private string _CharacterName;
        public string CharacterName { get { return _CharacterName; } set { _CharacterName = value; } }

        private byte _Level;
        public byte Level { get { return _Level; } set { _Level = value; } }

        public Character(string name, byte level) 
        {
            _CharacterName = name; _Level = level;
        }
    }
}
