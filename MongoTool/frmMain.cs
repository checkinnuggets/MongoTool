using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace MongoTool
{
    // ReSharper disable once InconsistentNaming
    public partial class frmMain : Form
    {
        private IMongoStuff _mongoStuff;
        private IFileStuff _fileStuff;

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            var server = tbServer.Text;

            _fileStuff = new FileStuff();
            _mongoStuff = new MongoStuff(server);

            cbDatabase.DataSource = _mongoStuff.GetDatabaseNames();
            
            var allowDeletes = server.Contains("localhost");
            cmsRecords.Items["deleteRecordToolStripMenuItem"].Enabled = allowDeletes;
        }

        private void cbDatabase_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbCollection.DataSource = _mongoStuff.GetCollectionsNames(cbDatabase.Text).ToList();
        }

        private void cbCollection_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void lbRecords_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSelectedRecord.Text = lbRecords.SelectedItem == null
                ? string.Empty
                : _mongoStuff
                    .GetDocument(cbDatabase.Text, cbCollection.Text, lbRecords.SelectedItem.ToString())
                    .FormatJson();
        }

        private void btnDeleteCollection_Click(object sender, EventArgs e)
        {
            _mongoStuff.DeleteCollection(cbDatabase.Text, cbCollection.Text);
            btnConnect_Click(null, null);
        }

        private void btnDeleteDatabase_Click(object sender, EventArgs e)
        {
            _mongoStuff.DeleteDatabase(cbDatabase.Text);
            btnConnect_Click(null, null);
        }


        private void RefreshList()
        {
            lbRecords.DataSource = null;
            lbRecords.Items.Clear();

            var documents = _mongoStuff.GetDocumentsForCollection(cbDatabase.Text, cbCollection.Text).ToList();

            foreach (var doc in documents)
                lbRecords.Items.Add(doc);

            documentCount.Text = string.Format("{0} documents", documents.Count());
        }

        
        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void deleteRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lbRecords.SelectedItem == null)
                return;

            var selectedIndex = lbRecords.SelectedIndex;

            _mongoStuff.DeleteDocument(cbDatabase.Text, cbCollection.Text, lbRecords.SelectedItem.ToString());

            lbRecords.Items.RemoveAt(selectedIndex);

            if (selectedIndex >= lbRecords.Items.Count)
                selectedIndex = lbRecords.Items.Count - 1;

            if (selectedIndex >= 0)
                lbRecords.SelectedIndex = selectedIndex;
        }

        private void importRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog { Multiselect = true, Filter = FileDialogFilter };

            if (dlg.ShowDialog() != DialogResult.OK)
                return;

            foreach (var file in dlg.FileNames)
            {
                var json = _fileStuff.ReadTextFile(file);
                _mongoStuff.InsertRecord(cbDatabase.Text, cbCollection.Text, json);
            }

            RefreshList();
        }

        private void exportRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dlg = new SaveFileDialog{ Filter = FileDialogFilter };

            if (dlg.ShowDialog() != DialogResult.OK)
                return;

            _fileStuff.WriteTextFile( dlg.FileName, txtSelectedRecord.Text );

        }

        private const string FileDialogFilter = @"JSON|*.json|All Files|*.*";
    }




}
