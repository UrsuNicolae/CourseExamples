using System.Text;

namespace Exemple.Genercs
{
    internal class PhoneDictionary
    {
        private readonly Dictionary<string, List<string>> _phoneDictionary;

        public PhoneDictionary()
        {
            _phoneDictionary = new Dictionary<string, List<string>>();
        }

        public void Add(string name, string phone)
        {
            if (_phoneDictionary.ContainsKey(name))
            {
                _phoneDictionary[name].Add(phone);
            }
            else
            {
                _phoneDictionary.Add(name, new List<string> { phone });
            }
        }

        public List<string> GetPhoneByName(string name)
        {
            return _phoneDictionary[name];
        }

        public void Remove(string name)
        {
            if (_phoneDictionary.ContainsKey(name))
            {
                _phoneDictionary.Remove(name);
            }
        }

        public void RemovePhone(string name, string phone)
        {
            if (_phoneDictionary.ContainsKey(name))
            {
                _phoneDictionary[name].Remove(phone);
            }
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            foreach (var item in _phoneDictionary)
            {
                result.Append(item.Key + ": ");
                foreach (var phone in item.Value)
                {
                    result.Append(phone + ",");
                }
                result.Append("\n");
            }
            return result.ToString();
        }
    }
}
