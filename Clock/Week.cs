﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
	public class Week
	{
		public static readonly string[] Weekdays = new string[]
		{
			"Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Вс"
		};
		byte week;
		public Week(bool[] days)
		{
			CompressWeekDays(days);
		}
		public void CompressWeekDays(bool[] days)
		{
			for( byte i = 0; i < days.Length; i++)
			{
				if (days[i]) week |= (byte)(1 << i);
			}
		}
		public override string ToString()
		{
			string weekdays = "";
			for(int i = 0; i < Weekdays.Length; i++)
			{
				if (((1 << i) & week) != 0) 
					weekdays += $"{Weekdays[i]},";
			}
			return weekdays;
		}
	}
}
