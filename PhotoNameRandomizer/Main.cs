using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoRandomPicker {
	public partial class Main : MetroFramework.Forms.MetroForm {
		private List<String> randonNumRegion = new List<string>();

		private static readonly string SEPARATOR = "-";

		public Main() {
			InitializeComponent();

			this.dgPhotoName.AutoGenerateColumns = false;
		}

		private List<String> GenerateRandomNumRegion(int count) {
			List<String> randomNumRegion = new List<string>();

			for(int startIndex = 1; startIndex <= count; startIndex++) {
				randomNumRegion.Add(startIndex.ToString("D4"));
			}

			return randomNumRegion;
		}

		private string GenerateItemFromRegion(List<String> regionList) {
			string randomNumStr = String.Empty;

			if(regionList.Count != 0) {
				Random random = new Random(Guid.NewGuid().GetHashCode());
				int maxValueIndex = regionList.Count;

				int index = random.Next(maxValueIndex);

				randomNumStr = regionList[index];

				regionList.RemoveAt(index);
			}

			return randomNumStr;
		}

		private List<PhotoInfo> ConvertToPhotoInfoList(string[] filePaths) {

			List<PhotoInfo> photoInfoList = new List<PhotoInfo>();

			foreach(string filePath in filePaths) {
				var photoName = System.IO.Path.GetFileName(filePath);

				photoInfoList.Add(new PhotoInfo() { PhotoName = photoName, Path = filePath });

			}

			return photoInfoList;
		}

		private void RefreshList(string destinationPath) {
			this.txtLocation.Text = destinationPath;

			string[] filePaths = Directory.GetFiles(destinationPath);

			List<PhotoInfo> photoInfoList = this.ConvertToPhotoInfoList(filePaths);

			this.lbCount.Text = filePaths.Length.ToString();

			dgPhotoName.DataSource = photoInfoList;
		}

        private void SetPicture(string filename, PictureBox pb)
        {
            try
            {
                string tempFile = System.IO.Path.Combine(System.IO.Path.GetTempPath(), Guid.NewGuid().ToString() + System.IO.Path.GetExtension(filename));
                File.Copy(filename, tempFile);
                using (FileStream fsImage = new FileStream(tempFile, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {

                    if (pb.InvokeRequired)
                    {
                        pb.Invoke(new MethodInvoker(
                        delegate () {
                            pb.Image = new Bitmap(fsImage);
                        }));
                    }
                    else
                    {
                        pb.Image = new Bitmap(fsImage);
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void txtLocation_ButtonClick(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.txtLocation.Text = folderBrowserDialog1.SelectedPath;

                string[] filePaths = Directory.GetFiles(folderBrowserDialog1.SelectedPath);

                List<PhotoInfo> photoInfoList = this.ConvertToPhotoInfoList(filePaths);

                this.lbCount.Text = filePaths.Length.ToString();

                dgPhotoName.DataSource = photoInfoList;
            }
        }

        private void dgPhotoName_SelectionChanged(object sender, EventArgs e) {
			if(this.dgPhotoName.SelectedRows != null && this.dgPhotoName.SelectedRows.Count != 0) {
				PhotoInfo selectedClient = (PhotoInfo)this.dgPhotoName.SelectedRows[0].DataBoundItem;
				this.SetPicture(selectedClient.Path, this.pbPhoto);
			}
		}

		private void btnRandom_Click(object sender, EventArgs e) {
			randonNumRegion = this.GenerateRandomNumRegion(Directory.GetFiles(folderBrowserDialog1.SelectedPath).Length);

			var filePath = System.IO.Path.GetFileName(folderBrowserDialog1.SelectedPath);

			var destinationPath = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(folderBrowserDialog1.SelectedPath), filePath + "_" + Guid.NewGuid().ToString());

			if(!Directory.Exists(System.IO.Path.Combine(destinationPath))) {
				Directory.CreateDirectory(destinationPath);
			}

			string prefix = this.txtPrefix.Text;

			foreach(DataGridViewRow row in dgPhotoName.Rows) {
				string randomNum = this.GenerateItemFromRegion(randonNumRegion);

				PhotoInfo selectedPhotoInfo = ((PhotoInfo)row.DataBoundItem);

				string extension = System.IO.Path.GetExtension(selectedPhotoInfo.PhotoName);
				string fileName = prefix + SEPARATOR + randomNum + extension;

				File.Copy(selectedPhotoInfo.Path, System.IO.Path.Combine(destinationPath, fileName));
			}

			this.RefreshList(destinationPath);
		}
	}

	public class PhotoInfo {
		public string PhotoName {
			get; set;
		}

		public string Path {
			get; set;
		}
	}
}
