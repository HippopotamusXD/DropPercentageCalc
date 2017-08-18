using System;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;
using System.Drawing;
namespace Drop_Precentage
{
    public partial class FormMain : Form
    {
        OleDbConnection MainConnection = new OleDbConnection();

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            ConnectLocalDatabase("DropPercentage.mdb");
        }

        #region Connecting to the database
        private bool ConnectLocalDatabase(string database)
        {
            string connetionString = "";
            try
            {
                connetionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + database + ";" + "Mode=ReadWrite;";
                MainConnection.ConnectionString = connetionString;
                if (!OpenDatabase())
                {
                    connetionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + database + ";" + "Mode=ReadWrite;";
                    MainConnection.ConnectionString = connetionString;
                    if (!OpenDatabase())
                    {
                        return false;
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                return false;
            }
            return true;
        }

        private bool OpenDatabase()
        {
            try
            {
                MainConnection.Open();
                return true;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                return false;
            }
        }
        #endregion

        private void btnAdd_Click(object sender, EventArgs e)
        {
            float perc;
            if (float.TryParse(tbInput.Text, out perc) && perc <= 100 && perc >= 2)
            {
                try
                {
                    string sql = "";
                    sql = "INSERT INTO Percentages (Dropped, Percentage) VALUES (" + cbDropped.Checked + ", " + perc + ")";

                    OleDbCommand cmd = new OleDbCommand(sql, MainConnection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Added");
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.ToString());
                }
                calcAverage();
                calcYour();
                updateColor();
                tbInput.Text = "";
                cbDropped.Checked = false;
            }
            else
            {
                MessageBox.Show("Invalid input");
            }
        }

        #region Calculating percentages
        private void calcAverage()
        {
            try
            {
                string sql = "SELECT ROUND(AVG(Percentage), 2) FROM Percentages";
                using (IDbCommand command = new OleDbCommand(sql, MainConnection))
                {
                    object result = command.ExecuteScalar();
                    lblAveragePercentage.Text = Convert.ToString(result);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        private void calcYour()
        {
            float total;
            float dropped;
            float percentage;
            try
            {
                string sql = "SELECT COUNT(Percentage) FROM Percentages";
                using (IDbCommand command = new OleDbCommand(sql, MainConnection))
                {
                    object result = command.ExecuteScalar();
                    total = (int)(result);
                }
                sql = "SELECT Count(Percentage) FROM Percentages WHERE dropped = true";
                using (IDbCommand command = new OleDbCommand(sql, MainConnection))
                {
                    object result = command.ExecuteScalar();
                    dropped = (int)(result);
                }
                percentage = dropped / total * 100;

                if (!float.IsNaN(percentage))
                {
                    lblYourPercentage.Text = percentage.ToString("0.00");
                }
                else
                {
                    lblYourPercentage.Text = "No record";
                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }
        #endregion

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete everything?", "Are you sure you want to delete everything?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                UseWaitCursor = true;
                string sql = "";
                sql = "DELETE FROM Percentages";

                OleDbCommand cmd = new OleDbCommand(sql, MainConnection);
                cmd.ExecuteNonQuery();
                UseWaitCursor = false;

                lblAveragePercentage.Text = "0.00";
                lblYourPercentage.Text = "0.00";
                lblYourPercentage.BackColor = Color.White;
            }
        }

        private void updateColor()
        {
            float yourPerc;
            float avgPerc;

            yourPerc = float.Parse(lblYourPercentage.Text);
            avgPerc = float.Parse(lblAveragePercentage.Text);

            if (yourPerc > 1.1 * avgPerc)
            {
                lblYourPercentage.BackColor = Color.Green;
            }
            else if (avgPerc > 1.1 * yourPerc)
            {
                lblYourPercentage.BackColor = Color.Red;
            }
            else
            {
                lblYourPercentage.BackColor = Color.Yellow;
            }
        }

    }
}
