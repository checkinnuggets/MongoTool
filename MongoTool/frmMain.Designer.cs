using System.ComponentModel;
using System.Windows.Forms;

namespace MongoTool
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.lblServer = new System.Windows.Forms.Label();
            this.tbServer = new System.Windows.Forms.TextBox();
            this.lblCollection = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.cbCollection = new System.Windows.Forms.ComboBox();
            this.txtSelectedRecord = new System.Windows.Forms.TextBox();
            this.lbRecords = new System.Windows.Forms.ListBox();
            this.btnDeleteCollection = new System.Windows.Forms.Button();
            this.cbDatabase = new System.Windows.Forms.ComboBox();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.btnDeleteDatabase = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDeleteRecord = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(8, 5);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(38, 13);
            this.lblServer.TabIndex = 0;
            this.lblServer.Text = "Server";
            // 
            // tbServer
            // 
            this.tbServer.Location = new System.Drawing.Point(72, 5);
            this.tbServer.Name = "tbServer";
            this.tbServer.Size = new System.Drawing.Size(120, 20);
            this.tbServer.TabIndex = 1;
            this.tbServer.Text = "localhost:27017";
            // 
            // lblCollection
            // 
            this.lblCollection.AutoSize = true;
            this.lblCollection.Location = new System.Drawing.Point(488, 8);
            this.lblCollection.Name = "lblCollection";
            this.lblCollection.Size = new System.Drawing.Size(53, 13);
            this.lblCollection.TabIndex = 2;
            this.lblCollection.Text = "Collection";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(200, 5);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(40, 23);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Con";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // cbCollection
            // 
            this.cbCollection.FormattingEnabled = true;
            this.cbCollection.Location = new System.Drawing.Point(552, 8);
            this.cbCollection.Name = "cbCollection";
            this.cbCollection.Size = new System.Drawing.Size(121, 21);
            this.cbCollection.TabIndex = 4;
            this.cbCollection.SelectedIndexChanged += new System.EventHandler(this.cbCollection_SelectedIndexChanged);
            // 
            // txtSelectedRecord
            // 
            this.txtSelectedRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSelectedRecord.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSelectedRecord.Location = new System.Drawing.Point(0, 0);
            this.txtSelectedRecord.Multiline = true;
            this.txtSelectedRecord.Name = "txtSelectedRecord";
            this.txtSelectedRecord.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSelectedRecord.Size = new System.Drawing.Size(483, 531);
            this.txtSelectedRecord.TabIndex = 8;
            this.txtSelectedRecord.WordWrap = false;
            // 
            // lbRecords
            // 
            this.lbRecords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbRecords.FormattingEnabled = true;
            this.lbRecords.Location = new System.Drawing.Point(0, 0);
            this.lbRecords.Name = "lbRecords";
            this.lbRecords.Size = new System.Drawing.Size(241, 477);
            this.lbRecords.TabIndex = 9;
            this.lbRecords.SelectedIndexChanged += new System.EventHandler(this.lbRecords_SelectedIndexChanged);
            // 
            // btnDeleteCollection
            // 
            this.btnDeleteCollection.Location = new System.Drawing.Point(680, 8);
            this.btnDeleteCollection.Name = "btnDeleteCollection";
            this.btnDeleteCollection.Size = new System.Drawing.Size(40, 23);
            this.btnDeleteCollection.TabIndex = 11;
            this.btnDeleteCollection.Text = "Del";
            this.btnDeleteCollection.UseVisualStyleBackColor = true;
            this.btnDeleteCollection.Click += new System.EventHandler(this.btnDeleteCollection_Click);
            // 
            // cbDatabase
            // 
            this.cbDatabase.FormattingEnabled = true;
            this.cbDatabase.Location = new System.Drawing.Point(312, 5);
            this.cbDatabase.Name = "cbDatabase";
            this.cbDatabase.Size = new System.Drawing.Size(121, 21);
            this.cbDatabase.TabIndex = 13;
            this.cbDatabase.SelectedIndexChanged += new System.EventHandler(this.cbDatabase_SelectedIndexChanged);
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.Location = new System.Drawing.Point(248, 5);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(53, 13);
            this.lblDatabase.TabIndex = 12;
            this.lblDatabase.Text = "Database";
            // 
            // btnDeleteDatabase
            // 
            this.btnDeleteDatabase.Location = new System.Drawing.Point(440, 5);
            this.btnDeleteDatabase.Name = "btnDeleteDatabase";
            this.btnDeleteDatabase.Size = new System.Drawing.Size(40, 23);
            this.btnDeleteDatabase.TabIndex = 14;
            this.btnDeleteDatabase.Text = "Del";
            this.btnDeleteDatabase.UseVisualStyleBackColor = true;
            this.btnDeleteDatabase.Click += new System.EventHandler(this.btnDeleteDatabase_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblServer);
            this.panel1.Controls.Add(this.btnDeleteDatabase);
            this.panel1.Controls.Add(this.tbServer);
            this.panel1.Controls.Add(this.cbDatabase);
            this.panel1.Controls.Add(this.lblCollection);
            this.panel1.Controls.Add(this.lblDatabase);
            this.panel1.Controls.Add(this.btnConnect);
            this.panel1.Controls.Add(this.btnDeleteCollection);
            this.panel1.Controls.Add(this.cbCollection);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(728, 40);
            this.panel1.TabIndex = 15;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 40);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel4);
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtSelectedRecord);
            this.splitContainer1.Size = new System.Drawing.Size(728, 531);
            this.splitContainer1.SplitterDistance = 241;
            this.splitContainer1.TabIndex = 16;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbRecords);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(241, 477);
            this.panel4.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 531);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(241, 0);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.Controls.Add(this.splitContainer2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 477);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(241, 54);
            this.panel3.TabIndex = 12;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRefresh.Location = new System.Drawing.Point(0, 0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(241, 23);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "Refresh List";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDeleteRecord
            // 
            this.btnDeleteRecord.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeleteRecord.Location = new System.Drawing.Point(0, 0);
            this.btnDeleteRecord.Name = "btnDeleteRecord";
            this.btnDeleteRecord.Size = new System.Drawing.Size(241, 23);
            this.btnDeleteRecord.TabIndex = 10;
            this.btnDeleteRecord.Text = "Delete Record";
            this.btnDeleteRecord.UseVisualStyleBackColor = true;
            this.btnDeleteRecord.Click += new System.EventHandler(this.btnDeleteRecord_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.btnRefresh);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.btnDeleteRecord);
            this.splitContainer2.Size = new System.Drawing.Size(241, 54);
            this.splitContainer2.SplitterDistance = 25;
            this.splitContainer2.TabIndex = 12;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 571);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(744, 610);
            this.Name = "frmMain";
            this.Text = "Mongo Tool";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblServer;
        private TextBox tbServer;
        private Label lblCollection;
        private Button btnConnect;
        private ComboBox cbCollection;
        private TextBox txtSelectedRecord;
        private ListBox lbRecords;
        private Button btnDeleteCollection;
        private ComboBox cbDatabase;
        private Label lblDatabase;
        private Button btnDeleteDatabase;
        private Panel panel1;
        private SplitContainer splitContainer1;
        private Panel panel2;
        private Panel panel4;
        private Panel panel3;
        private SplitContainer splitContainer2;
        private Button btnRefresh;
        private Button btnDeleteRecord;
    }
}

