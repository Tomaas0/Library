namespace Library
{
    partial class DarbuotojoLangas
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
            this.knygosDataSet1 = new Library.KnygosDataSet1();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new Library.KnygosDataSet1TableAdapters.TableTableAdapter();
            this.tableAdapterManager = new Library.KnygosDataSet1TableAdapters.TableAdapterManager();
            this.tableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBoxAutorius = new System.Windows.Forms.TextBox();
            this.textBoxPavadinimas = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.knygosDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // knygosDataSet1
            // 
            this.knygosDataSet1.DataSetName = "KnygosDataSet1";
            this.knygosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.knygosDataSet1;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TableTableAdapter = this.tableTableAdapter;
            this.tableAdapterManager.UpdateOrder = Library.KnygosDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tableDataGridView
            // 
            this.tableDataGridView.AutoGenerateColumns = false;
            this.tableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.tableDataGridView.DataSource = this.tableBindingSource;
            this.tableDataGridView.Location = new System.Drawing.Point(0, 38);
            this.tableDataGridView.Name = "tableDataGridView";
            this.tableDataGridView.Size = new System.Drawing.Size(550, 220);
            this.tableDataGridView.TabIndex = 1;
            this.tableDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Autorius";
            this.dataGridViewTextBoxColumn2.HeaderText = "Autorius";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Pavadinimas";
            this.dataGridViewTextBoxColumn3.HeaderText = "Pavadinimas";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Zmogus";
            this.dataGridViewTextBoxColumn4.HeaderText = "Zmogus";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Grazinimo Laikas";
            this.dataGridViewTextBoxColumn5.HeaderText = "Grazinimo Laikas";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(475, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Gražinti";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(374, 273);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Pratesti";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(96, 519);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Prideti";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBoxAutorius
            // 
            this.textBoxAutorius.Location = new System.Drawing.Point(34, 427);
            this.textBoxAutorius.Name = "textBoxAutorius";
            this.textBoxAutorius.Size = new System.Drawing.Size(210, 20);
            this.textBoxAutorius.TabIndex = 16;
            this.textBoxAutorius.Text = "Autorius";
            // 
            // textBoxPavadinimas
            // 
            this.textBoxPavadinimas.Location = new System.Drawing.Point(34, 473);
            this.textBoxPavadinimas.Name = "textBoxPavadinimas";
            this.textBoxPavadinimas.Size = new System.Drawing.Size(210, 20);
            this.textBoxPavadinimas.TabIndex = 17;
            this.textBoxPavadinimas.Text = "Pavadinimas";
            // 
            // DarbuotojoLangas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 615);
            this.Controls.Add(this.textBoxPavadinimas);
            this.Controls.Add(this.textBoxAutorius);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableDataGridView);
            this.Name = "DarbuotojoLangas";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.DarbuotojoLangas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.knygosDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KnygosDataSet1 knygosDataSet1;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private KnygosDataSet1TableAdapters.TableTableAdapter tableTableAdapter;
        private KnygosDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBoxAutorius;
        private System.Windows.Forms.TextBox textBoxPavadinimas;
    }
}