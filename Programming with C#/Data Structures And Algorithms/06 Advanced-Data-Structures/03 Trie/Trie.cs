﻿using System.Collections.Generic;
using System.Text;

namespace _03_Trie
{
    /// <summary>
    /// Trie data structure.
    /// </summary>
    internal class Trie : ITrie
    {
        #region Data Members

        /// <summary>
        /// Root TrieNode.
        /// </summary>
        private TrieNode rootTrieNode { get; set; }

        #endregion

        #region Ctors

        /// <summary>
        /// Create a new Trie instance.
        /// </summary>
        /// <param name="rootTrieNode">The root TrieNode.</param>
        internal Trie(TrieNode rootTrieNode)
        {
            this.rootTrieNode = rootTrieNode;
        }

        #endregion

        #region ITrie methods

        /// <summary>
        /// Add a word to the Trie.
        /// </summary>
        public void AddWord(string word)
        {
            AddWord(rootTrieNode, word.ToCharArray());
        }

        /// <summary>
        /// Remove word from the Trie.
        /// </summary>
        public void RemoveWord(string word)
        {
            var trieNode = GetTrieNode(word);
            if (trieNode != null && trieNode.IsWord)
            {
                trieNode.WordCount = 0;
                RemoveNode(trieNode);
            }
        }

        /// <summary>
        /// Get all words in the Trie.
        /// </summary>
        public ICollection<string> GetWords()
        {
            var words = new List<string>();
            var buffer = new StringBuilder();
            GetWords(rootTrieNode, words, buffer);
            return words;
        }

        /// <summary>
        /// Get words for given prefix.
        /// </summary>
        public ICollection<string> GetWords(string prefix)
        {
            ICollection<string> words;
            if (string.IsNullOrEmpty(prefix))
            {
                words = GetWords();
            }
            else
            {
                var trieNode = GetTrieNode(prefix);
                // Empty list if no prefix match
                words = new List<string>();
                if (trieNode != null)
                {
                    var buffer = new StringBuilder();
                    buffer.Append(prefix);
                    GetWords(trieNode, words, buffer);
                }
            }
            return words;
        }

        /// <summary>
        /// Returns true or false if the word is present in the Trie.
        /// </summary>
        public bool HasWord(string word)
        {
            var trieNode = GetTrieNode(word);
            return trieNode != null && trieNode.IsWord;
        }

        /// <summary>
        /// Returns the count for the word in the Trie.
        /// </summary>
        public int WordCount(string word)
        {
            var trieNode = GetTrieNode(word);
            return (trieNode == null ? 0 : trieNode.WordCount);
        }

        #endregion

        #region Private methods

        /// <summary>
        /// Get the equivalent TrieNode in the Trie for given prefix. 
        /// If prefix not present, then return null.
        /// </summary>
        private TrieNode GetTrieNode(string prefix)
        {
            var trieNode = rootTrieNode;
            foreach (var prefixChar in prefix.ToCharArray())
            {
                trieNode.Children.TryGetValue(prefixChar, out trieNode);
                if (trieNode == null)
                {
                    break;
                }
            }
            return trieNode;
        }

        /// <summary>
        /// Recursive method to add word. Gets the first char of the word, 
        /// creates the child TrieNode if null, and recurses with the first
        /// char removed from the word. If the word length is 0, return.
        /// </summary>
        private void AddWord(TrieNode trieNode, char[] word)
        {
            if (word.Length == 0)
            {
                trieNode.WordCount++;
            }
            else
            {
                var c = Utilities.FirstChar(word);
                TrieNode child;
                trieNode.Children.TryGetValue(c, out child);
                if (child == null)
                {
                    child = TrieFactory.GetTrieNode(c, trieNode);
                    trieNode.Children[c] = child;
                }
                var cRemoved = Utilities.FirstCharRemoved(word);
                AddWord(child, cRemoved);
            }
        }

        /// <summary>
        /// Recursive method to get all the words starting from given TrieNode.
        /// </summary>
        private void GetWords(TrieNode trieNode, ICollection<string> words,
            StringBuilder buffer)
        {
            if (trieNode.IsWord)
            {
                words.Add(buffer.ToString());
            }
            foreach (var child in trieNode.Children.Values)
            {
                buffer.Append(child.Character);
                GetWords(child, words, buffer);
                // Remove recent character
                buffer.Length--;
            }
        }

        /// <summary>
        /// Recursive method to remove word. Remove only if node does not 
        /// have children and is not a word node and has a parent node.
        /// </summary>
        private void RemoveNode(TrieNode trieNode)
        {
            if (trieNode.Children.Count == 0 // should not have any children
                && !trieNode.IsWord // should not be a word
                && trieNode != rootTrieNode // do not remove root node
                )
            {
                var parent = trieNode.Parent;
                trieNode.Parent.Children.Remove(trieNode.Character);
                trieNode.Parent = null;
                RemoveNode(parent);
            }
        }

        #endregion
    }
}