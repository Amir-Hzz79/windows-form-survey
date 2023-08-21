using FinalProject.Models;
using FinalProject.Services;
using FinalProject.UserControls;
using FinalProject.ViewModels;
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
	public partial class PollAnswersPercentForm : Form
	{
		PollService _pollService = MyServices.PollService;

		Poll poll;

		public PollAnswersPercentForm(int pollId)
		{
			poll = _pollService.Get(pollId);

			List<AnswerPercent> answerPercents = MyServices.PollService.GetAnswerPercent(pollId);

			InitializeComponent();

			foreach (Question question in poll.Questions)
			{
				QuestionControl questionControl = new QuestionControl(question, false,-1, answerPercents);

				containerPanel.Controls.Add(questionControl);
			}
		}
	}
}
