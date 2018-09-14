using System;
using System.Linq;
using System.Collections.Generic;

namespace RosterManagement
{
    public class CodeSchool
    {
        Dictionary<int, List<string>> _roster;

        public CodeSchool()
        {
            _roster = new Dictionary<int, List<String>>();
        }
        
        // <summary>
        // Should be able to Add Student to a Particular Wave
        // </summary>
        // <param name="cadet">Refers to the name of the Cadet</param> 
        // <param name="wave">Refers to the Wave number</param>
        public void Add(string cadet, int wave)
        {
            if(_roster.ContainsKey(wave))
            {
                _roster[wave].Add(cadet);
            }
            else
            {
                List<string> name= new List<string>();
                name.Add(cadet);
                _roster.Add(wave,name);
            }
        }

        // <summary>
        // Returns all the Cadets in a given wave
        //</summary>
        // <param name="wave">Refers to the wave number from where cadet list is to be fetched</param>
        // <returns>List of Cadet's Name</returns>
    public List<string> Grade(int wave)
        {
            var list = new List<string>();
            if(_roster.ContainsKey(wave))
            { 
                foreach(string s in _roster[wave])
                {
                    list.Add(s);
                }
                list.Sort();
            }
            return list;
          //  if (_roster.ContainsKey(wave))
       // return dic[key].Contains(val);
        //return false;
        }

        // <summary>
        // Return all the cadets in the CodeSchool
        // </summary>
        // <returns>List of Cadet's Name</returns>
        public List<string> Roster()
        {
           var keys = _roster.Keys.ToList();
            keys.Sort();
            var cadets = new List<string>();
            //_roster r= new _roster();
            foreach(int i in keys)
            {
                _roster[i].Sort();
                foreach(var st in _roster[i])
                {
                    cadets.Add(st);
                }
            }
           // cadets.Sort();
            return cadets;
        }
    }
}
