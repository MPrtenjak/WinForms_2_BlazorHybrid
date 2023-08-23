using Microsoft.Extensions.DependencyInjection;
using Simple_CRUD.Data;
using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;
using System.Linq;
using Microsoft.AspNetCore.Components.WebView.WindowsForms;

namespace Simple_CRUD
{
    public partial class Main : Form
    {
        SQLiteConnection conn;
        SQLiteCommand cmd;
        SQLiteDataAdapter adapter;
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        int id;
        bool isDoubleClick = false;
        String connectString;

        public Main()
        {
            InitializeComponent();

            connectString = @"Data Source=" + Application.StartupPath + @"\Database\crud.db;version=3";
            var connectionStringHolder = Program.serviceProvider.GetService<ConnectionStringHolder>();
            connectionStringHolder.ConnectionString = connectString;

            GenerateDatabase();

            var messageBroker = Program.serviceProvider.GetService<MessageBroker>();
            messageBroker.EditMemberEvent += EditMember;
            messageBroker.DeleteMemberEvent += DeleteMember;
            messageBroker.AddMemberEvent += AddMember;
            messageBroker.UpdateMemberEvent += UpdateMember;
            messageBroker.ClearMemberEvent += ClearMember;

            this.FormClosing += (sender, e) =>
            {
                messageBroker.EditMemberEvent -= EditMember;
                messageBroker.DeleteMemberEvent -= DeleteMember;
                messageBroker.AddMemberEvent -= AddMember;
                messageBroker.UpdateMemberEvent -= UpdateMember;
                messageBroker.ClearMemberEvent -= ClearMember;
            };

            blazorWebView1.Dock = DockStyle.Fill;

            blazorWebView1.HostPage = "wwwroot\\index.html";
            blazorWebView1.Services = Program.serviceProvider;
            blazorWebView1.RootComponents.Add<Members>("#app");

            tabControl1.SelectedIndex = 1;
        }

        private void DeleteMember(object sender, EventArgs e)
        {
            long memberId = ((MemberIdEventArgs)e).MemberId;
            if (selectDataRowWithMemberId(memberId))
            {
                id = (int)memberId;
                Delete(this, null);
            }
        }

        private void EditMember(object sender, EventArgs e)
        {
            long memberId = ((MemberIdEventArgs)e).MemberId;
            if (selectDataRowWithMemberId(memberId))
            {
                Edit(this, null);
                txt_firstname.Focus();
            }
        }

        private void AddMember(object sender, EventArgs e)
        {
            Member member = ((MemberEventArgs)e).Member;

            if (member != null)
            {
                txt_firstname.Text = member.FirstName;
                txt_lastname.Text = member.LastName;
                txt_address.Text = member.Address;
                Add(this, null);
            }
        }

        private void UpdateMember(object sender, EventArgs e)
        {
            Member member = ((MemberEventArgs)e).Member;

            if (member != null)
            {
                txt_firstname.Text = member.FirstName;
                txt_lastname.Text = member.LastName;
                txt_address.Text = member.Address;
                Update(this, null);
            }
        }

        private void ClearMember(object sender, EventArgs e)
        {
            Clear(this, null);
        }

        private bool selectDataRowWithMemberId(long memberId)
        {
            var row = dataGridView1.Rows
                .Cast<DataGridViewRow>()
                .FirstOrDefault(row => (long)row.Cells[0].Value == memberId);

            if (row == null)
                return false;

            row.Selected = true;
            return true;
        }

        private void Add(object sender, EventArgs e)
        {

            if (txt_firstname.Text != "" || txt_lastname.Text != "" || txt_address.Text != "")
            {
                try
                {
                    conn = new SQLiteConnection(connectString);
                    cmd = new SQLiteCommand();
                    cmd.CommandText = @"INSERT INTO member (firstname, lastname, address) VALUES(@firstname, @lastname, @address)";
                    cmd.Connection = conn;
                    cmd.Parameters.Add(new SQLiteParameter("@firstname", txt_firstname.Text));
                    cmd.Parameters.Add(new SQLiteParameter("@lastname", txt_lastname.Text));
                    cmd.Parameters.Add(new SQLiteParameter("@address", txt_address.Text));
                    conn.Open();

                    int i = cmd.ExecuteNonQuery();

                    if (i == 1)
                    {
                        MessageBox.Show("Successfully Created!");
                        txt_firstname.Text = "";
                        txt_lastname.Text = "";
                        txt_address.Text = "";
                        ReadData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Required Field!");
            }

        }

        private void GenerateDatabase()
        {
            String path = Application.StartupPath + @"\Database\crud.db";
            if (!File.Exists(path))
            {
                // Create Folder if does not exists
                var dbFolder = Application.StartupPath + @"\Database";
                if (!Directory.Exists(dbFolder))
                    Directory.CreateDirectory(dbFolder);

                conn = new SQLiteConnection(connectString);
                conn.Open();
                string sql = "CREATE TABLE member (ID INTEGER PRIMARY KEY AUTOINCREMENT, firstname TEXT, lastname TEXT, address TEXT)";
                cmd = new SQLiteCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                // Add initial members
                var memberRepository = new MemberRepository(connectString);
                memberRepository.AddInitialMembers();
            }
        }

        private void ReadData()
        {
            try
            {
                conn = new SQLiteConnection(connectString);
                conn.Open();
                cmd = new SQLiteCommand();
                String sql = "SELECT * FROM member";
                adapter = new SQLiteDataAdapter(sql, conn);
                ds.Reset();
                adapter.Fill(ds);
                dt = ds.Tables[0];
                dataGridView1.DataSource = dt;
                conn.Close();
                dataGridView1.Columns[1].HeaderText = "Firstname";
                dataGridView1.Columns[2].HeaderText = "Lastname";
                dataGridView1.Columns[3].HeaderText = "Address";
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                var _messageBroker = Program.serviceProvider.GetService<MessageBroker>();
                _messageBroker.NotifyDatabaseChange();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            ReadData();
        }

        private void Edit(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            txt_firstname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txt_lastname.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txt_address.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            isDoubleClick = true;
        }

        private void GetIdToDelete(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            isDoubleClick = false;
            txt_firstname.Text = "";
            txt_lastname.Text = "";
            txt_address.Text = "";
        }


        private void Update(object sender, EventArgs e)
        {
            if (isDoubleClick)
            {
                try
                {
                    conn.Open();
                    cmd = new SQLiteCommand();
                    cmd.CommandText = @"UPDATE member set firstname=@firstname, lastname=@lastname, address=@address WHERE ID='" + id + "'";
                    cmd.Connection = conn;
                    cmd.Parameters.AddWithValue("@firstname", txt_firstname.Text);
                    cmd.Parameters.AddWithValue("@lastname", txt_lastname.Text);
                    cmd.Parameters.AddWithValue("@address", txt_address.Text);
                    int i = cmd.ExecuteNonQuery();

                    if (i == 1)
                    {
                        MessageBox.Show("Successfully Updated!");
                        txt_firstname.Text = "";
                        txt_lastname.Text = "";
                        txt_address.Text = "";
                        ReadData();
                        id = 0;
                        dataGridView1.ClearSelection();
                        dataGridView1.CurrentCell = null;
                        isDoubleClick = false;
                    }

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Delete(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you to delete this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    conn = new SQLiteConnection(connectString);
                    conn.Open();
                    cmd = new SQLiteCommand();
                    cmd.CommandText = @"DELETE FROM member WHERE ID='" + id + "'";
                    cmd.Connection = conn;
                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                    {
                        MessageBox.Show("Successfully Deleted!");
                        id = 0;
                        dataGridView1.ClearSelection();
                        dataGridView1.CurrentCell = null;
                        ReadData();
                        dataGridView1.ClearSelection();
                        dataGridView1.CurrentCell = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (dialogResult == DialogResult.No)
            {

            }

        }

        private void Clear(object sender, EventArgs e)
        {
            id = 0;
            txt_firstname.Text = "";
            txt_lastname.Text = "";
            txt_address.Text = "";
            dataGridView1.ClearSelection();
            dataGridView1.CurrentCell = null;
            isDoubleClick = false;
        }

        private void btn_blazor_Click(object sender, EventArgs e)
        {
            var blazorForm = new BlazorForm();
            blazorForm.Show();
        }
    }
}
