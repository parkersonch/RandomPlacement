﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ikc5.TypeLibrary;

namespace WpfApplication.Models
{
	public class Cell : BaseNotifyPropertyChanged, ICell
	{
		public Cell()
		{
			this.SetDefaultValues();
		}

		#region Implementation ICell

		private State _state;

		[DefaultValue(State.Empty)]
        public State State
		{
			get { return _state; }
			set { SetProperty(ref _state, value); }
		}

		#endregion

		public static ICell Empty =>  new Cell();
	}
}
