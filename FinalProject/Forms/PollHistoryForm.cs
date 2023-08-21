using FinalProject.Models;
using FinalProject.Services;
using FinalProject.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.Forms
{
	public partial class PollHistoryForm : Form
	{
		PollService _pollService = MyServices.PollService;

		Poll poll;
		public PollHistoryForm(int pollId)
		{
			poll = _pollService.Get(pollId, AppData.User.Id);

			InitializeComponent();

			nameLable.Text = poll.Title;
			descriptionLable.Text = poll.Description;

			foreach (Question question in poll.Questions)
			{
				int selectedAnswer = poll.UserAnswers.Where(ua => ua.Answer.QuestionID == question.Id).FirstOrDefault().AnswerId;
				QuestionControl questionControl = new QuestionControl(question,true ,selectedAnswer);

				containerPanel.Controls.Add(questionControl);
			}
		}
	}
}
