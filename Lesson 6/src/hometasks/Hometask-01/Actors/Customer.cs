using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace artem_buzinov.Hometask_01.Actors
{
    class Customer
    {
        #region FIELDS
        private string name;
        #endregion
        public Customer(string name)
        {
            this.name = name;
            _comeIntoCentre comeInto = EComeIntoCentre();
        }
        #region PROPERTIES
        public string Name
        {
            get { return name; }
        }
        #endregion
        #region DELEGATES
        public delegate void _comeIntoCentre();
        #endregion
        #region METHODS
        
        #endregion
        #region EVENTS
        public event _comeIntoCentre EComeIntoCentre;
        #endregion
        #region EVENT_HANDLERS
        
        #endregion

    }
}
