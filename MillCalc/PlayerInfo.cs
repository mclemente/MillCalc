using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MillCalc
{
	class PlayerInfo
	{
		private int playerHP, playerDraw, playerDamage = 0, playerFatigue = 1, playerDeck, deathTime = 0;

		public PlayerInfo(int playerHP, int playerDraw, bool fatigueChecked, int playerFatigue, int playerDeck)
		{
			HP = playerHP;
			Draw = playerDraw;
			if (fatigueChecked) Fatigue = playerFatigue;
			else
			{
				Deck = playerDeck;
				Draw -= Deck;
			}
		}

		public int Damage
		{
			get
			{
				return playerDamage;
			}
			set
			{
				playerDamage = value;
			}
                }

		public int Fatigue
		{
			get
			{
				return playerFatigue;
			}
			set
			{
				playerFatigue = value;
			}
		}

		public int Draw
		{
			get
			{
				return playerDraw;
			}
			set
			{
				if(value < 0)
				{
					playerDraw = 0;
				}
				else
				{
					playerDraw = value;
				}
			}
		}

		public int HP
		{
			get
			{
				return playerHP;
			}
			set
			{
				playerHP = value;
			}
		}

		public int Deck
		{
			get
			{
				return playerDeck;
			}
			set
			{
				playerDeck = value;
			}
		}

		public int Death
		{
			set
			{
				deathTime = value;
			}
			get
			{
				return deathTime;
			}
		}

		public void FatigueDamage()
		{
			//Damage = (Cards to be Drawn  + 2 * Next Fatigue Damage - 1) * Cards to be Drawn / 2
			//HP -= (Draw + 2 * Fatigue - 1) * Draw / 2;
			int totalDraw = Draw;
			while(totalDraw > 0)
			{
				HP -= Fatigue;
				Fatigue++;
				totalDraw--;
				if (HP <= 0) Death = totalDraw;
			}
		}
        }
}
