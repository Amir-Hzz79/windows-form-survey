using FinalProject.Models;
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

namespace FinalProject.UserControls
{
	public partial class QuestionControl : UserControl
	{
		public int selectedAnswer = -1;
		public Question _question;
		public QuestionControl(Question question, bool enable, int selectedAnswer, List<AnswerPercent> answerPercents=null)
		{
			_question = question;
			InitializeComponent();

			if (!enable)
			{
				radioButton1.Enabled = false;
				radioButton2.Enabled = false;
				radioButton3.Enabled = false;
				radioButton4.Enabled = false;

				if(answerPercents != null)
				{
					AnswerPercent answerPercent1=answerPercents.FirstOrDefault(ap=>ap.AnswerId == _question.Answers[0].Id);
					AnswerPercent answerPercent2 = answerPercents.FirstOrDefault(ap => ap.AnswerId == _question.Answers[1].Id);
					AnswerPercent answerPercent3 = answerPercents.FirstOrDefault(ap => ap.AnswerId == _question.Answers[2].Id);
					AnswerPercent answerPercent4 = answerPercents.FirstOrDefault(ap => ap.AnswerId == _question.Answers[3].Id);

					if (answerPercent1!=null)
					{
						answer1PercentLabel.Text = answerPercent1.Percentage.ToString();
					}
					else if (answerPercent2!=null)
					{
						answer2PercentLabel.Text = answerPercent2.Percentage.ToString();
					}
					else if (answerPercent3 != null)
					{
						answer3PercentLabel.Text = answerPercent3.Percentage.ToString();
					}
					else if (answerPercent4 != null)
					{
						answer4PercentLabel.Text = answerPercent4.Percentage.ToString();
					}
				}
			}

			if (selectedAnswer != -1)
			{
				radioButton1.Enabled = false;
				radioButton2.Enabled = false;
				radioButton3.Enabled = false;
				radioButton4.Enabled = false;

				if (_question.Answers[0].Id == selectedAnswer)
				{
					radioButton1.Checked = true;
				}
				else if (_question.Answers[1].Id == selectedAnswer)
				{
					radioButton2.Checked = true;
				}
				else if (_question.Answers[2].Id == selectedAnswer)
				{
					radioButton3.Checked = true;
				}
				else if (_question.Answers[3].Id == selectedAnswer)
				{
					radioButton4.Checked = true;
				}
			}

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
