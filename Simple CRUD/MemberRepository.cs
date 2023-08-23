using System.Data.SQLite;

namespace Simple_CRUD
{
    internal class MemberRepository
    {
        public MemberRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Add(Member member)
        {
            using (var conn = createConnection())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"INSERT INTO member (firstname, lastname, address) VALUES(@firstname, @lastname, @address)";
                    cmd.Parameters.Add(new SQLiteParameter("@firstname", member.FirstName));
                    cmd.Parameters.Add(new SQLiteParameter("@lastname", member.LastName));
                    cmd.Parameters.Add(new SQLiteParameter("@address", member.Address));
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void AddInitialMembers()
        {
            foreach (var member in InitialMembers.GetInitialMembers())
                Add(member);
        }

        private SQLiteConnection createConnection() => new SQLiteConnection(_connectionString);

        private readonly string _connectionString;
    }
}
