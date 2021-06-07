
namespace szachforms
{
    partial class szachownicaform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        ///
        /*
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }*/

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.ruchyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.szachyDataSet1 = new szachy_winform_framework.SzachyDataSet();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ruchyTableAdapter1 = new szachy_winform_framework.SzachyDataSetTableAdapters.RuchyTableAdapter();
            this.gryTableAdapter1 = new szachy_winform_framework.SzachyDataSetTableAdapters.GryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ruchyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.szachyDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(0, 478);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // ruchyBindingSource
            // 
            this.ruchyBindingSource.DataMember = "Ruchy";
            this.ruchyBindingSource.DataSource = this.bindingSource1;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.szachyDataSet1;
            this.bindingSource1.Position = 0;
            // 
            // szachyDataSet1
            // 
            this.szachyDataSet1.DataSetName = "SzachyDataSet";
            this.szachyDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.listBox1.Enabled = false;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(974, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 478);
            this.listBox1.TabIndex = 1;
            // 
            // ruchyTableAdapter1
            // 
            this.ruchyTableAdapter1.ClearBeforeFill = true;
            // 
            // gryTableAdapter1
            // 
            this.gryTableAdapter1.ClearBeforeFill = true;
            // 
            // szachownicaform
            // 
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(1094, 507);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "szachownicaform";
            this.Deactivate += new System.EventHandler(this.szachownicaform_Deactivate);
            this.Load += new System.EventHandler(this.szachownicaform_Load);
            this.Scroll += new System.Windows.Forms.ScrollEventHandler(this.szachownicaform_Scroll);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.szachownicaform_Paint_1);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.szachownicaform_KeyDown);
            this.Leave += new System.EventHandler(this.szachownicaform_Leave);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.szachownicaform_MouseClick_1);
            ((System.ComponentModel.ISupportInitialize)(this.ruchyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.szachyDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private szachy_winform_framework.SzachyDataSet szachyDataSet1;
        private szachy_winform_framework.SzachyDataSetTableAdapters.RuchyTableAdapter ruchyTableAdapter1;
        private szachy_winform_framework.SzachyDataSetTableAdapters.GryTableAdapter gryTableAdapter1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource ruchyBindingSource;
        private System.Windows.Forms.ListBox listBox1;
    }
}