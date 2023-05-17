namespace CarsDatabase
{
    partial class frmAdd
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.vehicleRegInput = new System.Windows.Forms.TextBox();
            this.makeInput = new System.Windows.Forms.TextBox();
            this.engineSizeInput = new System.Windows.Forms.TextBox();
            this.availableCheckMark = new System.Windows.Forms.CheckBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.dateRegistered = new System.Windows.Forms.DateTimePicker();
            this.rentPerDay = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.rentPerDay)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vehicle reg number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Make";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Engine Size";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date Registered";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Rental Per Day";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Available";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(249, 369);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(128, 69);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(418, 369);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(128, 69);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // vehicleRegInput
            // 
            this.vehicleRegInput.Location = new System.Drawing.Point(251, 43);
            this.vehicleRegInput.Name = "vehicleRegInput";
            this.vehicleRegInput.Size = new System.Drawing.Size(238, 20);
            this.vehicleRegInput.TabIndex = 9;
            this.vehicleRegInput.TextChanged += new System.EventHandler(this.vehicleRegInput_TextChanged);
            // 
            // makeInput
            // 
            this.makeInput.Location = new System.Drawing.Point(251, 86);
            this.makeInput.Name = "makeInput";
            this.makeInput.Size = new System.Drawing.Size(238, 20);
            this.makeInput.TabIndex = 10;
            this.makeInput.TextChanged += new System.EventHandler(this.makeInput_TextChanged);
            // 
            // engineSizeInput
            // 
            this.engineSizeInput.Location = new System.Drawing.Point(251, 130);
            this.engineSizeInput.Name = "engineSizeInput";
            this.engineSizeInput.Size = new System.Drawing.Size(238, 20);
            this.engineSizeInput.TabIndex = 11;
            this.engineSizeInput.TextChanged += new System.EventHandler(this.engineSizeInput_TextChanged);
            // 
            // availableCheckMark
            // 
            this.availableCheckMark.AutoSize = true;
            this.availableCheckMark.Location = new System.Drawing.Point(251, 264);
            this.availableCheckMark.Name = "availableCheckMark";
            this.availableCheckMark.Size = new System.Drawing.Size(15, 14);
            this.availableCheckMark.TabIndex = 14;
            this.availableCheckMark.UseVisualStyleBackColor = true;
            this.availableCheckMark.CheckedChanged += new System.EventHandler(this.availableCheckMark_CheckedChanged);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(82, 369);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(128, 69);
            this.clearBtn.TabIndex = 17;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // dateRegistered
            // 
            this.dateRegistered.Location = new System.Drawing.Point(251, 172);
            this.dateRegistered.Name = "dateRegistered";
            this.dateRegistered.Size = new System.Drawing.Size(200, 20);
            this.dateRegistered.TabIndex = 18;
            this.dateRegistered.Value = new System.DateTime(2023, 5, 17, 0, 0, 0, 0);
            this.dateRegistered.ValueChanged += new System.EventHandler(this.RentPerDay_ValueChanged);
            // 
            // rentPerDay
            // 
            this.rentPerDay.Location = new System.Drawing.Point(251, 214);
            this.rentPerDay.Name = "rentPerDay";
            this.rentPerDay.Size = new System.Drawing.Size(120, 20);
            this.rentPerDay.TabIndex = 19;
            // 
            // frmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 450);
            this.Controls.Add(this.rentPerDay);
            this.Controls.Add(this.dateRegistered);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.availableCheckMark);
            this.Controls.Add(this.engineSizeInput);
            this.Controls.Add(this.makeInput);
            this.Controls.Add(this.vehicleRegInput);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAdd";
            this.Text = "Task A Roger O\'Donnell 17/05/2023";
            ((System.ComponentModel.ISupportInitialize)(this.rentPerDay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox vehicleRegInput;
        private System.Windows.Forms.TextBox makeInput;
        private System.Windows.Forms.TextBox engineSizeInput;
        private System.Windows.Forms.CheckBox availableCheckMark;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.DateTimePicker dateRegistered;
        private System.Windows.Forms.NumericUpDown rentPerDay;
    }
}