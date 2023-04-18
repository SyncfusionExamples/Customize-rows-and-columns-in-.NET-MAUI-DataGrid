using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RowAndColumnCustomization_MAUI_DataGrid
{
	public class TicketInfo : INotifyPropertyChanged
	{
		private string id;
		private string customerName;
		private string query;
		private string country;

		public string ID
		{
			get
			{
				return id;
			}
			set
			{
				id = value;
				OnPropertyChanged(nameof(ID));
			}
		}

		public string CustomerName
		{
			get
			{
				return customerName;
			}
			set
			{
				customerName = value;
				OnPropertyChanged(nameof(CustomerName));
			}
		}

		public string Query
		{
			get
			{
				return query;
			}
			set
			{
				query = value;
				OnPropertyChanged(nameof(Query));
			}
		}

		public string Country
		{
			get
			{
				return country;
			}
			set
			{
				country = value;
				OnPropertyChanged(nameof(Country));
			}
		}

		public TicketInfo(string incidentID, string customer, string description, string country)
		{
			ID = incidentID;
			CustomerName = customer;
			Query = description;
			Country = country;
		}

		public event PropertyChangedEventHandler PropertyChanged;

		private void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
