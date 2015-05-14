using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Commander.Models;

namespace Commander
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            foreach (DriveInfo driveInfo in DriveInfo.GetDrives())
            {
                driveComboLeft.Items.Add(driveInfo);
            }

            driveComboLeft.SelectedIndex = 0;

        }

        #region InitControls

        private void InitControls(string path, DataGridView dataGridView)
        {
            //DataTable dataTable = (DataTable) dataGridView.DataSource;
            //dataTable.Clear();

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

            pathBoxLeft.Text = path;
        }

        private void FillDataGridView(DataGridView dataGridView, List<DataGridViewModel> list)
        {

            foreach (var element in list)
            {
                dataGridView.Rows.Add(element.Path, element.Name, element.Size, element.Date, element.IsRoot);
            }
        }

        #endregion


        private void driveComboLeft_SelectedIndexChanged(object sender, EventArgs e)
        {
            string pathLeft = driveComboLeft.Text;

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
                    InitControls(path, dataGVLeft);
                }
                else
                {
                    if (selectedRow[0].Cells[2].Value == "<DIR>")
                    {
                        string path = selectedRow[0].Cells[0].Value.ToString() + selectedRow[0].Cells[1].Value.ToString() + "\\";
                        InitControls(path, dataGVLeft);
                    
                    }
                    else
                    {
                        MessageBox.Show("Plik");
                    }
                }
            }            
        }

    }
}
