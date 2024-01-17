namespace Visual
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.veterinarioDataSet2 = new Visual.VeterinarioDataSet2();
            this.veterinarioTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.veterinario_TblTableAdapter = new Visual.VeterinarioDataSet2TableAdapters.Veterinario_TblTableAdapter();
            this.idVeterinarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.códigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nacimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.géneroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cédulaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teléfonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celularDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especialidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direcciónDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterinarioDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterinarioTblBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idVeterinarioDataGridViewTextBoxColumn,
            this.códigoDataGridViewTextBoxColumn,
            this.nombresDataGridViewTextBoxColumn,
            this.nacimientoDataGridViewTextBoxColumn,
            this.géneroDataGridViewTextBoxColumn,
            this.cédulaDataGridViewTextBoxColumn,
            this.teléfonoDataGridViewTextBoxColumn,
            this.celularDataGridViewTextBoxColumn,
            this.especialidadDataGridViewTextBoxColumn,
            this.correoDataGridViewTextBoxColumn,
            this.direcciónDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.veterinarioTblBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(185, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // veterinarioDataSet2
            // 
            this.veterinarioDataSet2.DataSetName = "VeterinarioDataSet2";
            this.veterinarioDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // veterinarioTblBindingSource
            // 
            this.veterinarioTblBindingSource.DataMember = "Veterinario_Tbl";
            this.veterinarioTblBindingSource.DataSource = this.veterinarioDataSet2;
            // 
            // veterinario_TblTableAdapter
            // 
            this.veterinario_TblTableAdapter.ClearBeforeFill = true;
            // 
            // idVeterinarioDataGridViewTextBoxColumn
            // 
            this.idVeterinarioDataGridViewTextBoxColumn.DataPropertyName = "idVeterinario";
            this.idVeterinarioDataGridViewTextBoxColumn.HeaderText = "idVeterinario";
            this.idVeterinarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idVeterinarioDataGridViewTextBoxColumn.Name = "idVeterinarioDataGridViewTextBoxColumn";
            this.idVeterinarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.idVeterinarioDataGridViewTextBoxColumn.Width = 125;
            // 
            // códigoDataGridViewTextBoxColumn
            // 
            this.códigoDataGridViewTextBoxColumn.DataPropertyName = "Código";
            this.códigoDataGridViewTextBoxColumn.HeaderText = "Código";
            this.códigoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.códigoDataGridViewTextBoxColumn.Name = "códigoDataGridViewTextBoxColumn";
            this.códigoDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombresDataGridViewTextBoxColumn
            // 
            this.nombresDataGridViewTextBoxColumn.DataPropertyName = "Nombres";
            this.nombresDataGridViewTextBoxColumn.HeaderText = "Nombres";
            this.nombresDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombresDataGridViewTextBoxColumn.Name = "nombresDataGridViewTextBoxColumn";
            this.nombresDataGridViewTextBoxColumn.Width = 125;
            // 
            // nacimientoDataGridViewTextBoxColumn
            // 
            this.nacimientoDataGridViewTextBoxColumn.DataPropertyName = "Nacimiento";
            this.nacimientoDataGridViewTextBoxColumn.HeaderText = "Nacimiento";
            this.nacimientoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nacimientoDataGridViewTextBoxColumn.Name = "nacimientoDataGridViewTextBoxColumn";
            this.nacimientoDataGridViewTextBoxColumn.Width = 125;
            // 
            // géneroDataGridViewTextBoxColumn
            // 
            this.géneroDataGridViewTextBoxColumn.DataPropertyName = "Género";
            this.géneroDataGridViewTextBoxColumn.HeaderText = "Género";
            this.géneroDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.géneroDataGridViewTextBoxColumn.Name = "géneroDataGridViewTextBoxColumn";
            this.géneroDataGridViewTextBoxColumn.Width = 125;
            // 
            // cédulaDataGridViewTextBoxColumn
            // 
            this.cédulaDataGridViewTextBoxColumn.DataPropertyName = "Cédula";
            this.cédulaDataGridViewTextBoxColumn.HeaderText = "Cédula";
            this.cédulaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cédulaDataGridViewTextBoxColumn.Name = "cédulaDataGridViewTextBoxColumn";
            this.cédulaDataGridViewTextBoxColumn.Width = 125;
            // 
            // teléfonoDataGridViewTextBoxColumn
            // 
            this.teléfonoDataGridViewTextBoxColumn.DataPropertyName = "Teléfono";
            this.teléfonoDataGridViewTextBoxColumn.HeaderText = "Teléfono";
            this.teléfonoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.teléfonoDataGridViewTextBoxColumn.Name = "teléfonoDataGridViewTextBoxColumn";
            this.teléfonoDataGridViewTextBoxColumn.Width = 125;
            // 
            // celularDataGridViewTextBoxColumn
            // 
            this.celularDataGridViewTextBoxColumn.DataPropertyName = "Celular";
            this.celularDataGridViewTextBoxColumn.HeaderText = "Celular";
            this.celularDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.celularDataGridViewTextBoxColumn.Name = "celularDataGridViewTextBoxColumn";
            this.celularDataGridViewTextBoxColumn.Width = 125;
            // 
            // especialidadDataGridViewTextBoxColumn
            // 
            this.especialidadDataGridViewTextBoxColumn.DataPropertyName = "Especialidad";
            this.especialidadDataGridViewTextBoxColumn.HeaderText = "Especialidad";
            this.especialidadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.especialidadDataGridViewTextBoxColumn.Name = "especialidadDataGridViewTextBoxColumn";
            this.especialidadDataGridViewTextBoxColumn.Width = 125;
            // 
            // correoDataGridViewTextBoxColumn
            // 
            this.correoDataGridViewTextBoxColumn.DataPropertyName = "Correo";
            this.correoDataGridViewTextBoxColumn.HeaderText = "Correo";
            this.correoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.correoDataGridViewTextBoxColumn.Name = "correoDataGridViewTextBoxColumn";
            this.correoDataGridViewTextBoxColumn.Width = 125;
            // 
            // direcciónDataGridViewTextBoxColumn
            // 
            this.direcciónDataGridViewTextBoxColumn.DataPropertyName = "Dirección";
            this.direcciónDataGridViewTextBoxColumn.HeaderText = "Dirección";
            this.direcciónDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.direcciónDataGridViewTextBoxColumn.Name = "direcciónDataGridViewTextBoxColumn";
            this.direcciónDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterinarioDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterinarioTblBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private VeterinarioDataSet2 veterinarioDataSet2;
        private System.Windows.Forms.BindingSource veterinarioTblBindingSource;
        private VeterinarioDataSet2TableAdapters.Veterinario_TblTableAdapter veterinario_TblTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVeterinarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn códigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nacimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn géneroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cédulaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teléfonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn celularDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn especialidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direcciónDataGridViewTextBoxColumn;
    }
}