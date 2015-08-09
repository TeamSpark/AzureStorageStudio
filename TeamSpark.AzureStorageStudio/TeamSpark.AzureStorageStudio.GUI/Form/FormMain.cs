using System;
using TeamSpark.AzureStorageStudio.Resources.Translation.GUI.FormMain;

namespace TeamSpark.AzureStorageStudio.GUI.Form
{
	public partial class FormMain : System.Windows.Forms.Form
	{
		public FormMain()
		{
			InitializeComponent();
		}

		private void FormMain_Load(object sender, EventArgs e)
		{
			this.Text = English.Title;
		}
	}
}
