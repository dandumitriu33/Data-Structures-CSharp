using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresPractice.Trie
{
    public class TrieNode
    {
        public Dictionary<char, TrieNode> children = new Dictionary<char, TrieNode>();
        public bool endOfWord;
    }
}
