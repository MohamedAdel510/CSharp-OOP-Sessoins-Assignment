using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_OOP_Sessoin_01_Assignment
{
	internal class Cinema
	{
		private Ticket[] _ticket;
		private int _count = 0;
		public int  Count => _count;

		public Cinema(int capacity)
		{
			_ticket = new Ticket[capacity];
		}

		public bool AddTicket(Ticket ticket)
		{
			if (_count < _ticket.Length)
			{
				_ticket[_count] = ticket;
				_count++;
				return true;
			}
			return false;
		}

		public Ticket? this[int index]
		{
			get
			{
				if(index >= 0 && index < _ticket.Length)
					return _ticket[index];
				return null;
			}
			set
			{
				if (index >= 0 && index < _ticket.Length)
				{
					if (_ticket[index] == null)
						_count++;

					_ticket[index] = value!;
				}
				
			}
		}

		public Ticket? this[string MovName]
		{
			get
			{
				foreach (var mov in _ticket)
				{
					if(mov.MovieName == MovName)
					{
						return mov;
					}
				}
				return null;
			}
		}

	}
}
