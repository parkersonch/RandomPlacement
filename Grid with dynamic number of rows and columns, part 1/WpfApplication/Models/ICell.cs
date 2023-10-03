using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication.Models
{
	public interface ICell
	{
		/// <summary>
		/// State of the cell.
		/// </summary>
		State State { get; set; }
	}

	public enum State {
		Empty,
		Filled,
		Selected
	}
}
