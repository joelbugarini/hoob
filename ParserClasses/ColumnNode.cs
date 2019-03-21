﻿using System;
using System.Collections.Generic;

using System.Text;


namespace hix
{
    class ColumnNode
    {
       
        private string original;

        public string Original
        {
            get { return original; }
            set { original = value; }
        }
        private string content;

        public string Content
        {
            get { return content; }
            set { content = value; }
        }

        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        private string scheme;

        public string Scheme
        {
            get { return scheme; }
            set { scheme = value; }
        }
        private Column column;

        internal Column Column
        {
            get { return column; }
            set { column = value; }
        }
        private Database db;

        internal Database Db
        {
            get { return db; }
            set { db = value; }
        }

        public List<string> Ignored { get; set; }

        public void Create(string text, string type, List<string> ignoreds)
        {
            this.Type = type;

            if(ignoreds != null)
                this.Ignored = ignoreds;

            this.Original = text;
            this.Content = text.Replace("[[column]]", "").Replace("[[/column]]", "");
            this.Scheme = content;
        }

        
    }
}
