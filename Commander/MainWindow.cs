using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Commander.Helpers;
using Commander.Models;
using System.Globalization;

namespace Commander
{
    public partial class MainWindow : Form
    {
        public ProgressBarForm proceProgressBarForm;
        public CreateForm createForm;
        public bool activeGrid = false;
        public MainWindow()
        {
            InitializeComponent();
            backgroundWorker.WorkerSupportsCancellation = true;
            backgroundWorker.WorkerReportsProgress = true;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            foreach (DriveInfo driveInfo in DriveInfo.GetDrives())
            {
                driveComboLeft.Items.Add(driveInfo);
                driveComboRight.Items.Add(driveInfo);
            }

            driveComboRight.SelectedIndex = 0;
            pathBoxRight.Text = driveComboRight.Text;
            dataGVRight.CurrentCell.Selected = false;

            driveComboLeft.SelectedIndex = 0;
            pathBoxLeft.Text = driveComboLeft.Text;
            pathBoxLeft.BackColor = Color.Silver;
            
            

        }

        #region InitControls

        private void InitControls(string path, DataGridView dataGridView)
        {
            
            dataGridView.Rows.Clear();
            dataGridView.Refresh();

            List<DataGridViewModel> rootList = new List<DataGridViewModel>();
            List<DataGridViewModel> foldersList = new List<DataGridViewModel>();
            List<DataGridViewModel> filesList = new List<DataGridViewModel>();
            string rootDirectory = "";
            string[] foldersTable;
            string[] filesTable;

            try
            {
                rootDirectory = Path.GetDirectoryName(path);
                foldersTable = Directory.GetDirectories(path);
                filesTable = Directory.GetFiles(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wybrane urządzenie nie jest gotowe");
                return; 
            }

            #region Fill - Root

            if (rootDirectory != null)
            {
                rootList.Add(new DataGridViewModel
                {
                    Name = "...",
                    Path = rootDirectory,
                    IsRoot = true,
                    Date = "",
                    Size = ""
                });
            }

            #endregion

            #region Fill - Folders

            for (int i = 0; i < foldersTable.Count(); i++)
            {
                foldersList.Add(new DataGridViewModel
                {
                    Date = new DirectoryInfo(foldersTable[i]).CreationTime.ToLongDateString(),
                    Name = new DirectoryInfo(foldersTable[i]).Name,
                    Path = path,
                    Size = "<DIR>",
                    IsRoot = false
                });
            }

            #endregion

            #region Fill - Files

            for (int i = 0; i < filesTable.Count(); i++)
            {
                filesList.Add(new DataGridViewModel
                {
                    Date = new FileInfo(filesTable[i]).CreationTime.ToLongDateString(),
                    Name = new FileInfo(filesTable[i]).Name,
                    Path = path,
                    Size = new FileInfo(filesTable[i]).Length.ToString(),
                    IsRoot = false
                });
            }

            #endregion

            FillDataGridView(dataGridView, rootList);
            FillDataGridView(dataGridView, foldersList);
            FillDataGridView(dataGridView, filesList);
        }

        private void FillDataGridView(DataGridView dataGridView, List<DataGridViewModel> list)
        {

            foreach (var element in list)
            {
                dataGridView.Rows.Add(element.Path, element.Name, element.Size, element.Date, element.IsRoot);
            }
        }

        #endregion

        #region Directory - Left

        private void driveComboLeft_SelectedIndexChanged(object sender, EventArgs e)
        {
            string pathLeft = driveComboLeft.Text;
            pathBoxLeft.Text = driveComboLeft.Text;

            InitControls(pathLeft, dataGVLeft);
        }

        private void dataGVLeft_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRow = dataGVLeft.SelectedRows;

            if (selectedRow.Count == 1)
            {
                if (Convert.ToBoolean(selectedRow[0].Cells[4].Value))
                {
                    string path = selectedRow[0].Cells[0].Value.ToString();
                    pathBoxLeft.Text = path;
                    InitControls(path, dataGVLeft);
                }
                else
                {
                    if (selectedRow[0].Cells[2].Value == "<DIR>")
                    {
                        string path = selectedRow[0].Cells[0].Value.ToString() + "\\" + selectedRow[0].Cells[1].Value.ToString();
                        path = path.Replace("\\\\", "\\");
                        pathBoxLeft.Text = path;
                        InitControls(path, dataGVLeft);

                    }
                    else
                    {
                        string path = selectedRow[0].Cells[0].Value.ToString() + "\\" + selectedRow[0].Cells[1].Value.ToString();
                        Process.Start(path);
                    }
                }
            }
        }

        private void pathBoxLeft_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                string path = pathBoxLeft.Text;

                try
                {
                    FileAttributes attr = File.GetAttributes(path);
                    if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
                    {
                        string discDriveChar = path.Substring(0, 3).ToUpper();
                        driveComboLeft.Text = discDriveChar;
                        pathBoxLeft.Text = path;
                        InitControls(path, dataGVLeft);
                        
                    }
                    else
                    {
                        Process.Start(path);
                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show("Błędna ścieżka");
                    path = driveComboLeft.Text;
                    pathBoxLeft.Text = path;
                    InitControls(path, dataGVLeft);
                }                
            }
        }

        #endregion

        #region Directory - Right

        private void driveComboRight_SelectedIndexChanged(object sender, EventArgs e)
        {
            string pathLeft = driveComboRight.Text;
            pathBoxRight.Text = driveComboRight.Text;
            InitControls(pathLeft, dataGVRight);
        }

        private void pathBoxRight_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                string path = pathBoxRight.Text;

                try
                {
                    FileAttributes attr = File.GetAttributes(path);
                    if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
                    {
                        string discDriveChar = path.Substring(0, 3).ToUpper();
                        driveComboRight.Text = discDriveChar;
                        pathBoxRight.Text = path;
                        InitControls(path, dataGVRight);
                        
                    }
                    else
                    {
                        Process.Start(path);
                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show("Błędna ścieżka");
                    path = driveComboRight.Text;
                    pathBoxRight.Text = path;
                    InitControls(path, dataGVRight);
                }                
            }
        }

        private void dataGVRight_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRow = dataGVRight.SelectedRows;

            if (selectedRow.Count == 1)
            {
                if (Convert.ToBoolean(selectedRow[0].Cells[4].Value))
                {
                    string path = selectedRow[0].Cells[0].Value.ToString();
                    pathBoxRight.Text = path;
                    InitControls(path, dataGVRight);
                }
                else
                {
                    if (selectedRow[0].Cells[2].Value == "<DIR>")
                    {
                        string path = selectedRow[0].Cells[0].Value.ToString() + "\\" + selectedRow[0].Cells[1].Value.ToString();
                        path = path.Replace("\\\\", "\\");
                        pathBoxRight.Text = path;
                        InitControls(path, dataGVRight);

                    }
                    else
                    {
                        string path = selectedRow[0].Cells[0].Value.ToString() + "\\" + selectedRow[0].Cells[1].Value.ToString();
                        Process.Start(path);
                    }
                }
            }
        }

        #endregion

        #region ProgressBar - Copy

        public void Display(string text)
        {
            MessageBox.Show("Wykonano");
        }

        public void copy_Click(object sender, EventArgs e)
        {
            bool checkResult = CheckSelectedRow();

            if (checkResult)
            {
                backgroundWorker.WorkerSupportsCancellation = true;
                proceProgressBarForm = new ProgressBarForm();
                proceProgressBarForm.Cancel += () =>
                {
                    if (!backgroundWorker.CancellationPending)
                    {
                        backgroundWorker.CancelAsync();
                        proceProgressBarForm.Close();
                        copy.Enabled = true;
                    }
                };

                copy.Enabled = false;
                backgroundWorker.RunWorkerAsync();
                proceProgressBarForm.Show();
            }
        }

        public void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            CopyPath copyPath = GetSourceAndDestination();

            FileCopier fileCopier = new FileCopier(copyPath.Source, copyPath.Destination);
            fileCopier.OnProgressChanged += Progress;
            fileCopier.OnComplete += EndOfOperation;
            
            if (backgroundWorker.CancellationPending)
            {
                e.Cancel = true;
            }
            else
            {
                fileCopier.Copy();
            }
        }

        public void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            proceProgressBarForm.progressBar.Value = e.ProgressPercentage;
            proceProgressBarForm.progressLabel.Text = e.ProgressPercentage.ToString() + " %";
        }

        public void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            proceProgressBarForm.Close();
        }

        public void SimulateHeavyWork()
        {
            Thread.Sleep(10);
        }

        private void Progress(double Persentage, ref bool Cancel)
        {
            backgroundWorker.ReportProgress(Convert.ToInt32(Persentage));
        }
        private void EndOfOperation()
        {
        }

        public CopyPath GetSourceAndDestination()
        {
            CopyPath copyPath = new CopyPath();
            DataGridViewSelectedRowCollection selectedRow;

            if (activeGrid)
            {
                selectedRow = dataGVRight.SelectedRows;
                copyPath.Source = pathBoxRight.Text + "\\" + selectedRow[0].Cells[1].Value;
                copyPath.Destination = pathBoxLeft.Text + "\\" + selectedRow[0].Cells[1].Value;
                copyPath.IsOk = true;
            }
            else
            {
                selectedRow = dataGVLeft.SelectedRows;
                copyPath.Source = pathBoxLeft.Text + "\\" + selectedRow[0].Cells[1].Value;
                copyPath.Destination = pathBoxRight.Text + "\\" + selectedRow[0].Cells[1].Value;
                copyPath.IsOk = true;
            }

            return copyPath;
        }

        #endregion

        private void dataGVRight_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pathBoxLeft.BackColor = Color.White;
            if (dataGVLeft.CurrentCell != null)
            {
                dataGVLeft.CurrentCell.Selected = false;
            }
            pathBoxRight.BackColor = Color.Silver;
            activeGrid = true;
        }

        private void dataGVLeft_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pathBoxRight.BackColor = Color.White;
            if (dataGVRight.CurrentCell != null)
            {
                dataGVRight.CurrentCell.Selected = false;
            }
            pathBoxLeft.BackColor = Color.Silver;
            activeGrid = false;
        }

        public bool CheckSelectedRow()
        {
            DataGridViewSelectedRowCollection selectedRow;

            if (activeGrid)
                selectedRow = dataGVRight.SelectedRows;
            else
                selectedRow = dataGVLeft.SelectedRows;

            bool isRoot = Convert.ToBoolean(selectedRow[0].Cells[4].Value);

            if (isRoot)
            {
                MessageBox.Show("Nie można skopiować elementu");
                return false;
            }
            else
            {
                return true;
            }
        }

        public void ChangeActiveGrid()
        {
            
        }

        private void preview_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRow;

            if (activeGrid)
                selectedRow = dataGVRight.SelectedRows;
            else
                selectedRow = dataGVLeft.SelectedRows;

            bool isRoot = Convert.ToBoolean(selectedRow[0].Cells[4].Value);

            if (isRoot)
            {
                MessageBox.Show("Niewłaściwy element");
            }
            else
            {
                string path = selectedRow[0].Cells[0].Value + "\\" + selectedRow[0].Cells[1].Value;
                FileAttributes attr = File.GetAttributes(path);
                if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    MessageBox.Show("Niewłaściwy element");
                }
                else
                {
                    Process.Start(path);
                }
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRow;

            if (activeGrid)
                selectedRow = dataGVRight.SelectedRows;
            else
                selectedRow = dataGVLeft.SelectedRows;

            bool isRoot = Convert.ToBoolean(selectedRow[0].Cells[4].Value);

            if (isRoot)
            {
                MessageBox.Show("Niewłaściwy element");
            }
            else
            {
                string path = selectedRow[0].Cells[0].Value + "\\" + selectedRow[0].Cells[1].Value;
                FileAttributes attr = File.GetAttributes(path);
                if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    MessageBox.Show("Niewłaściwy element");
                }
                else
                {
                    Process.Start(path);
                }
            }
        }

        private void create_Click(object sender, EventArgs e)
        {
            createForm = new CreateForm();
            createForm.Show();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void changeLanguage_Click(object sender, EventArgs e)
        {
            if (Thread.CurrentThread.CurrentUICulture.Name == "pl-PL")
                ChangeCulture(new CultureInfo("en-US"));
            else
                ChangeCulture(new CultureInfo("pl-PL"));
        }

        void ChangeCulture(CultureInfo culture)
        {
            this.SuspendLayout();
            Thread.CurrentThread.CurrentUICulture = culture;
            ComponentResourceManager res = new ComponentResourceManager(typeof(MainWindow));

            res.ApplyResources(this, "$this", culture);
            UpdateControlCulture(res, this.Controls);
            this.ResumeLayout(true);
        }

        void UpdateControlCulture(ComponentResourceManager res, Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                res.ApplyResources(control, control.Name);
                UpdateControlCulture(res, control.Controls);
            }
        }
    }
}
