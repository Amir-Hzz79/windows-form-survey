﻿using FinalProject.Forms;
using FinalProject.Models;
using FinalProject.Services;
using System.Windows.Forms;

namespace FinalProject.UserControls
{
	public partial class ShowAvaiablePollsControl : UserControl
	{
		PollService _pollService = MyServices.PollService;
		List<Poll> polls;

		public event EventHandler QuestionClicked;
		public event FormClosedEventHandler PollFormClosed;

		public ShowAvaiablePollsControl()
		{
			InitializeComponent();

			polls = _pollService.GetAllAvaiable(AppData.User.Id);
			pollDataGridView.DataSource = polls;

			pollDataGridView.Columns["Id"].Visible = false;
			pollDataGridView.Columns["Questions"].Visible = false;
			pollDataGridView.Columns["UserAnswers"].Visible = false;
		}

		private void pollDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			Hide();

			int selectedPollId = Convert.ToInt32(pollDataGridView.Rows[e.RowIndex].Cells[0].Value);
			
			PollForm pollForm = new PollForm(selectedPollId);
			pollForm.FormClosed += PollFormClosed;
			pollForm.Show();

			QuestionClicked?.Invoke(this, EventArgs.Empty);
		}
	}
}
