using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MillCalc
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void playerFatigueCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if (playerFatigueCheckBox.Checked)
			{
				playerDeckLabel.Enabled = false;
				playerDeckUpDown.Enabled = false;
				playerFatigueDamageLabel.Enabled = true;
				playerFatigueDamageUpDown.Enabled = true;
                        }
			else
			{
				playerDeckLabel.Enabled = true;
                                playerDeckUpDown.Enabled = true;
				playerFatigueDamageLabel.Enabled = false;
				playerFatigueDamageUpDown.Enabled = false;
			}
		}
		
		private void opponentFatigueCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if (opponentFatigueCheckBox.Checked)
			{
				opponentDeckLabel.Enabled = false;
				opponentDeckUpDown.Enabled = false;
				opponentFatigueDamageLabel.Enabled = true;
				opponentFatigueDamageUpDown.Enabled = true;
			}
			else
			{
				opponentDeckLabel.Enabled = true;
				opponentDeckUpDown.Enabled = true;
				opponentFatigueDamageLabel.Enabled = false;
				opponentFatigueDamageUpDown.Enabled = false;
			}
		}

		private void calculateButton_Click(object sender, EventArgs e)
		{
			//Players' Info
			PlayerInfo player = new PlayerInfo((int)playerHPUpDown.Value + (int)playerArmorUpDown.Value, (int)playerCardsDrawUpDown.Value, playerFatigueCheckBox.Checked, (int)playerFatigueDamageUpDown.Value, (int)playerDeckUpDown.Value);
			PlayerInfo opponent = new PlayerInfo((int)opponentHPUpDown.Value + (int)opponentArmorUpDown.Value, (int)opponentCardsDrawUpDown.Value, opponentFatigueCheckBox.Checked, (int)opponentFatigueDamageUpDown.Value, (int)opponentDeckUpDown.Value);
			string diesFirst = "\r\n{0} {1} during the Draw no. {2}";
                        resultBox.Visible = true;

			player.FatigueDamage(); 
			opponent.FatigueDamage();
			if(player.Death - opponent.Death <= 0)
			{
				diesFirst = string.Format(diesFirst, "You", "win", opponent.Draw - opponent.Death);
			}
			else
			{
				diesFirst = string.Format(diesFirst, "Opponent", "wins", player.Draw - player.Death);
			}

			resultBox.Text =
				"Player:\r\nDamage: " + player.Damage
				+ "\r\nHP: " + (player.HP - player.Damage)
				+ "\r\n\r\nOpponent\r\nDamage: " + opponent.Damage
				+ "\r\nHP: " + (opponent.HP - opponent.Damage)
				+ diesFirst;
		}

		private void playerCardsDrawUpDown_ValueChanged(object sender, EventArgs e)
		{
			if(mirrorDraw.Checked)
			{
				opponentCardsDrawUpDown.Value = playerCardsDrawUpDown.Value;
                        }
		}

		private void opponentCardsDrawUpDown_ValueChanged(object sender, EventArgs e)
		{
			if (mirrorDraw.Checked)
			{
				playerCardsDrawUpDown.Value = opponentCardsDrawUpDown.Value;
			}
		}
	}
}
