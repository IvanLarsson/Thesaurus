using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThesaurusAPI.DataAccess
{
    public class WordDA : IThesaurus
    {
        public void AddSynonyms(IEnumerable<string> synonyms)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> GetSynonyms(string word)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> GetWords()
        {
            throw new NotImplementedException();
        }
    }
}
