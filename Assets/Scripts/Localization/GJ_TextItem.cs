﻿/*==========================================================*\
 *                                                          *
 *       Script made by Manuel Rodríguez Matesanz           *
 *       for Game Makers Game Jam in 31 / 08 / 2018         *    
 *                                                          *
 *==========================================================*/

namespace GameJam.Localization
{
    /// <summary>
    /// Text item saved in a dictionary in TextManager. Has key and text for access every text in every language
    /// </summary>
    [System.Serializable]
    public class GJ_TextItem
    {
        /// <summary>
        /// Variables - Key-Text
        /// </summary>
        private string m_text = "";
        private string m_key = "";
        /// <summary>
        /// properties
        /// </summary>
        public string Text { get { return m_text; } }
        public string Key { get { return m_key; } }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="key"></param>
        /// <param name="text"></param>
        public GJ_TextItem(string key, string text)
        {
            m_key = key;
            m_text = text;
        }

    }
}
