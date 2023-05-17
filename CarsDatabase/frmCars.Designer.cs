namespace CarsDatabase
{
    partial class frmCars
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lblVehicleReg = new System.Windows.Forms.Label();
            this.lblMake = new System.Windows.Forms.Label();
            this.lblEngineSize = new System.Windows.Forms.Label();
            this.lblDateRegistered = new System.Windows.Forms.Label();
            this.lblRentalPerDay = new System.Windows.Forms.Label();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.txtVehicleReg = new System.Windows.Forms.TextBox();
            this.CarsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hireDataSet1 = new CarsDatabase.HireDataSet();
            this.txtEngineSize = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.txtOrder = new System.Windows.Forms.TextBox();
            this.vehicleReg = new System.Windows.Forms.ToolTip(this.components);
            this.make = new System.Windows.Forms.ToolTip(this.components);
            this.txtMake = new System.Windows.Forms.TextBox();
            this.rentalPerDay = new System.Windows.Forms.ToolTip(this.components);
            this.rentPerDay = new System.Windows.Forms.TextBox();
            this.engineSize = new System.Windows.Forms.ToolTip(this.components);
            this.dateRegistered = new System.Windows.Forms.ToolTip(this.components);
            this.dtDateRegistered = new System.Windows.Forms.DateTimePicker();
            this.availableCar = new System.Windows.Forms.ToolTip(this.components);
            this.ckbAvailable = new System.Windows.Forms.CheckBox();
            this.tblCarTableAdapter1 = new CarsDatabase.HireDataSetTableAdapters.tblCarTableAdapter();
            this.tableAdapterManager1 = new CarsDatabase.HireDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.CarsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hireDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bowman Car Hire";
            // 
            // lblVehicleReg
            // 
            this.lblVehicleReg.AutoSize = true;
            this.lblVehicleReg.Location = new System.Drawing.Point(13, 123);
            this.lblVehicleReg.Name = "lblVehicleReg";
            this.lblVehicleReg.Size = new System.Drawing.Size(134, 13);
            this.lblVehicleReg.TabIndex = 1;
            this.lblVehicleReg.Text = "Vehicle registration number";
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Location = new System.Drawing.Point(13, 164);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(34, 13);
            this.lblMake.TabIndex = 2;
            this.lblMake.Text = "Make";
            // 
            // lblEngineSize
            // 
            this.lblEngineSize.AutoSize = true;
            this.lblEngineSize.Location = new System.Drawing.Point(13, 199);
            this.lblEngineSize.Name = "lblEngineSize";
            this.lblEngineSize.Size = new System.Drawing.Size(61, 13);
            this.lblEngineSize.TabIndex = 3;
            this.lblEngineSize.Text = "Engine size";
            // 
            // lblDateRegistered
            // 
            this.lblDateRegistered.AutoSize = true;
            this.lblDateRegistered.Location = new System.Drawing.Point(13, 237);
            this.lblDateRegistered.Name = "lblDateRegistered";
            this.lblDateRegistered.Size = new System.Drawing.Size(79, 13);
            this.lblDateRegistered.TabIndex = 4;
            this.lblDateRegistered.Text = "Date registered";
            // 
            // lblRentalPerDay
            // 
            this.lblRentalPerDay.AutoSize = true;
            this.lblRentalPerDay.Location = new System.Drawing.Point(13, 277);
            this.lblRentalPerDay.Name = "lblRentalPerDay";
            this.lblRentalPerDay.Size = new System.Drawing.Size(76, 13);
            this.lblRentalPerDay.TabIndex = 5;
            this.lblRentalPerDay.Text = "Rental per day";
            // 
            // lblAvailable
            // 
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.Location = new System.Drawing.Point(13, 321);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(50, 13);
            this.lblAvailable.TabIndex = 6;
            this.lblAvailable.Text = "Available";
            // 
            // txtVehicleReg
            // 
            this.txtVehicleReg.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CarsBindingSource, "VehicleRegNo", true));
            this.txtVehicleReg.Location = new System.Drawing.Point(173, 123);
            this.txtVehicleReg.Name = "txtVehicleReg";
            this.txtVehicleReg.Size = new System.Drawing.Size(135, 20);
            this.txtVehicleReg.TabIndex = 7;
            this.vehicleReg.SetToolTip(this.txtVehicleReg, "Enter vehicle registration number");
            // 
            // CarsBindingSource
            // 
            this.CarsBindingSource.DataMember = "tblCar";
            this.CarsBindingSource.DataSource = this.hireDataSet1;
            // 
            // hireDataSet1
            // 
            this.hireDataSet1.DataSetName = "HireDataSet";
            this.hireDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtEngineSize
            // 
            this.txtEngineSize.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CarsBindingSource, "EngineSize", true));
            this.txtEngineSize.Location = new System.Drawing.Point(173, 192);
            this.txtEngineSize.Name = "txtEngineSize";
            this.txtEngineSize.Size = new System.Drawing.Size(135, 20);
            this.txtEngineSize.TabIndex = 9;
            this.engineSize.SetToolTip(this.txtEngineSize, "Enter engine size");
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnUpdate.FlatAppearance.BorderSize = 2;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(447, 101);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(83, 39);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAdd.FlatAppearance.BorderSize = 2;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(447, 146);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(83, 37);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.addButton_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnDelete.FlatAppearance.BorderSize = 2;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(447, 189);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 38);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSearch.FlatAppearance.BorderSize = 2;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(447, 233);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(83, 36);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCancel.FlatAppearance.BorderSize = 2;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(447, 275);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(83, 40);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnExit.FlatAppearance.BorderSize = 2;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(447, 321);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(83, 36);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnFirst.FlatAppearance.BorderSize = 2;
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirst.Location = new System.Drawing.Point(29, 384);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(81, 40);
            this.btnFirst.TabIndex = 19;
            this.btnFirst.Text = "First";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.firstButton_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.AutoSize = true;
            this.btnPrevious.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnPrevious.FlatAppearance.BorderSize = 2;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Location = new System.Drawing.Point(107, 384);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(81, 40);
            this.btnPrevious.TabIndex = 20;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // btnNext
            // 
            this.btnNext.AutoSize = true;
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnNext.FlatAppearance.BorderSize = 2;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Location = new System.Drawing.Point(313, 384);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(81, 40);
            this.btnNext.TabIndex = 21;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // btnLast
            // 
            this.btnLast.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnLast.FlatAppearance.BorderSize = 2;
            this.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast.Location = new System.Drawing.Point(391, 384);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(81, 40);
            this.btnLast.TabIndex = 22;
            this.btnLast.Text = "Last";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.lastButton_Click);
            // 
            // txtOrder
            // 
            this.txtOrder.Location = new System.Drawing.Point(194, 395);
            this.txtOrder.Name = "txtOrder";
            this.txtOrder.Size = new System.Drawing.Size(113, 20);
            this.txtOrder.TabIndex = 23;
            this.txtOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMake
            // 
            this.txtMake.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CarsBindingSource, "Make ", true));
            this.txtMake.Location = new System.Drawing.Point(173, 156);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(182, 20);
            this.txtMake.TabIndex = 24;
            this.make.SetToolTip(this.txtMake, "Enter the make of the vehicle");
            // 
            // rentPerDay
            // 
            this.rentPerDay.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CarsBindingSource, "RentalPerDay ", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.rentPerDay.Location = new System.Drawing.Point(173, 277);
            this.rentPerDay.Name = "rentPerDay";
            this.rentPerDay.Size = new System.Drawing.Size(182, 20);
            this.rentPerDay.TabIndex = 28;
            this.rentalPerDay.SetToolTip(this.rentPerDay, "Enter the price of rent per day");
            // 
            // dtDateRegistered
            // 
            this.dtDateRegistered.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CarsBindingSource, "DateRegistered ", true));
            this.dtDateRegistered.Location = new System.Drawing.Point(173, 229);
            this.dtDateRegistered.Name = "dtDateRegistered";
            this.dtDateRegistered.Size = new System.Drawing.Size(200, 20);
            this.dtDateRegistered.TabIndex = 25;
            this.dateRegistered.SetToolTip(this.dtDateRegistered, "Enter the date of registration");
            // 
            // ckbAvailable
            // 
            this.ckbAvailable.AutoSize = true;
            this.ckbAvailable.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.CarsBindingSource, "Available ", true));
            this.ckbAvailable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ckbAvailable.Location = new System.Drawing.Point(173, 321);
            this.ckbAvailable.Name = "ckbAvailable";
            this.ckbAvailable.Size = new System.Drawing.Size(12, 11);
            this.ckbAvailable.TabIndex = 29;
            this.availableCar.SetToolTip(this.ckbAvailable, "Is car available?");
            this.ckbAvailable.UseVisualStyleBackColor = true;
            // 
            // tblCarTableAdapter1
            // 
            this.tblCarTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.tblCarTableAdapter = this.tblCarTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = CarsDatabase.HireDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(574, 445);
            this.Controls.Add(this.ckbAvailable);
            this.Controls.Add(this.rentPerDay);
            this.Controls.Add(this.dtDateRegistered);
            this.Controls.Add(this.txtMake);
            this.Controls.Add(this.txtOrder);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtEngineSize);
            this.Controls.Add(this.txtVehicleReg);
            this.Controls.Add(this.lblAvailable);
            this.Controls.Add(this.lblRentalPerDay);
            this.Controls.Add(this.lblDateRegistered);
            this.Controls.Add(this.lblEngineSize);
            this.Controls.Add(this.lblMake);
            this.Controls.Add(this.lblVehicleReg);
            this.Controls.Add(this.label1);
            this.Name = "frmCars";
            this.Text = "TaskA Roger O\'Donnell  17/05/2023";
            this.Load += new System.EventHandler(this.frmCars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CarsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hireDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblVehicleReg;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Label lblEngineSize;
        private System.Windows.Forms.Label lblDateRegistered;
        private System.Windows.Forms.Label lblRentalPerDay;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.TextBox txtVehicleReg;
        private System.Windows.Forms.TextBox txtEngineSize;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.TextBox txtOrder;
        private HireDataSet hireDataSet1;
        private HireDataSetTableAdapters.tblCarTableAdapter tblCarTableAdapter1;
        private HireDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingSource CarsBindingSource;
        private System.Windows.Forms.ToolTip vehicleReg;
        private System.Windows.Forms.ToolTip make;
        private System.Windows.Forms.ToolTip engineSize;
        private System.Windows.Forms.ToolTip dateRegistered;
        private System.Windows.Forms.ToolTip rentalPerDay;
        private System.Windows.Forms.ToolTip availableCar;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.DateTimePicker dtDateRegistered;
        private System.Windows.Forms.TextBox rentPerDay;
        private System.Windows.Forms.CheckBox ckbAvailable;
    }
}