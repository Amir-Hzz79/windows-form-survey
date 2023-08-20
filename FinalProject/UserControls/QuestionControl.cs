using FinalProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.UserControls
{
	public partial class QuestionControl : UserControl
	{
		public int selectedAnswer = -1;
		public Question _question;
		public QuestionControl(Question question)
		{
			_question = question;
			InitializeComponent();

			questionLabel.Text = _question.Text;
			answer1Label.Text = _question.Answers[0].AnswerText;
			answer2Label.Text = _question.Answers[1].AnswerText;
			answer3Label.Text = _question.Answers[2].AnswerText;
			answer4Label.Text = _question.Answers[3].AnswerText;
		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			selectedAnswer = _question.Answers[0].Id;
		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
			selectedAnswer = _question.Answers[1].Id;
		}

		private void radioButton3_CheckedChanged(object sender, EventArgs e)
		{
			selectedAnswer = _question.Answers[2].Id;
		}

		private void radioButton4_CheckedChanged(object sender, EventArgs e)
		{
			selectedAnswer = _question.Answers[3].Id;
		}
	}
}
