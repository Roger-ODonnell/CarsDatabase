using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace CarsDatabase
{
    public partial class frmCars : Form
    {
        string connectionString = "Data Source=C:\\data\\hire.db;Version=3;";

        public void ReloadData()
        {
            LoadData();
            UpdatePosition();
            UpdateCarDetails();
        }

        public frmCars()
        {
            InitializeComponent();
        }

        private void frmCars_Load(object sender, EventArgs e)
        {
            LoadData();
            UpdatePosition();
            UpdateCarDetails();
        }

        private void LoadData()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM tblCar";
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection))
                {
                    hireDataSet1.tblCar.Clear();
                    hireDataSet1.EnforceConstraints = false;
                    adapter.Fill(hireDataSet1.tblCar);

                }
            }

            txtMake.DataBindings.Clear();
            txtMake.DataBindings.Add("Text", hireDataSet1.tblCar, "Make");

            rentPerDay.DataBindings.Clear();
            rentPerDay.DataBindings.Add("Text", hireDataSet1.tblCar, "RentalPerDay");

            dtDateRegistered.DataBindings.Clear();
            dtDateRegistered.DataBindings.Add("Value", hireDataSet1.tblCar, "DateRegistered");
        }


        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtVehicleReg.Text != "")
                {
                    using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                    {
                        connection.Open();
                        string query = "SELECT * FROM tblCar";
                        using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection))
                        {
                            SQLiteCommandBuilder commandBuilder = new SQLiteCommandBuilder(adapter);
                            adapter.UpdateCommand = commandBuilder.GetUpdateCommand();
                            adapter.Update(hireDataSet1.tblCar);
                        }
                    }
                    MessageBox.Show("Update successful");
                }
                else
                {
                    MessageBox.Show("Vehicle Registration Number can't be empty");
                }
            }
            catch (ConstraintException)
            {
                MessageBox.Show("That Vehicle Registration Number already exists");
            }
        }

        private void UpdateCarDetails()
        {
            DataRowView currentRow = (DataRowView)CarsBindingSource.Current;
            txtMake.Text = currentRow["Make"].ToString();
            rentPerDay.Text = currentRow["RentalPerDay"].ToString();
            dtDateRegistered.Text = currentRow["DateRegistered"].ToString();
            currentRow["DateRegistered"] = dtDateRegistered.Value;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            CarsBindingSource.MoveNext();
            UpdatePosition();
            UpdateCarDetails();
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            CarsBindingSource.MovePrevious();
            UpdatePosition();
            UpdateCarDetails();
        }

        private void firstButton_Click(object sender, EventArgs e)
        {
            CarsBindingSource.MoveFirst();
            UpdatePosition();
            UpdateCarDetails();
        }

        private void lastButton_Click(object sender, EventArgs e)
        {
            CarsBindingSource.MoveLast();
            UpdatePosition();
            UpdateCarDetails();
        }

        private void UpdatePosition()
        {
            txtOrder.Text = (CarsBindingSource.Position + 1) + " of " + CarsBindingSource.Count;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            frmSearch searchForm = new frmSearch();
            searchForm.ShowDialog();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            frmAdd addForm = new frmAdd();
            addForm.ShowDialog();
            LoadData();
            UpdatePosition();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this car?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int currentPosition = CarsBindingSource.Position;
                DataRowView currentRow = (DataRowView)CarsBindingSource.Current;

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string deleteQuery = "DELETE FROM tblCar WHERE VehicleRegNo = @VehicleRegNo";

                    using (SQLiteCommand command = new SQLiteCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@VehicleRegNo", currentRow["VehicleRegNo"]);
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Car deleted successfully.");

                LoadData();

                if (currentPosition >= CarsBindingSource.Count)
                    currentPosition--;

                if (currentPosition >= 0)
                    CarsBindingSource.Position = currentPosition;

                UpdatePosition();
            }
        }


        private void cancelButton_Click(object sender, EventArgs e)
        {
            hireDataSet1.RejectChanges();
            CarsBindingSource.ResetBindings(false);
            UpdatePosition();
            UpdateCarDetails();
        }
    }
}
