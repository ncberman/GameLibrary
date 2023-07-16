namespace GameLibrary.Model
{
    public class SharedCharacter
    {
        private string _CharacterName;
        public string CharacterName { get { return _CharacterName; } set { _CharacterName = value; } }

        private byte _Level;
        public byte Level { get { return _Level; } set { _Level = value; } }

        public SharedCharacter(string name, byte level) 
        {
            _CharacterName = name; _Level = level;
        }
    }
}
