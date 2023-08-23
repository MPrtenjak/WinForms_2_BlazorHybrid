using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_CRUD.Data
{
    internal class ConnectionStringHolder
    {
        public string ConnectionString
        {
            get
            {
                if (_connectionString == null)
                    throw new ArgumentException("Connection string is not set");

                return _connectionString;
            }
            set
            {
                _connectionString = value;
            }
        }

        private string _connectionString = null;
    }
}
