using System;
using System.Collections.Generic;
using System.Text;

namespace Reports {
    public class Data {
        int _id;
        string _name;
        public int ID {
            get { return this._id; }
            set { this._id = value; }
        }
        public string Name {
            get { return this._name; }
            set { this._name = value; }
        }
        public Data(int id, string name) {
            this._id = id;
            this._name = name;
        }
    }
}
