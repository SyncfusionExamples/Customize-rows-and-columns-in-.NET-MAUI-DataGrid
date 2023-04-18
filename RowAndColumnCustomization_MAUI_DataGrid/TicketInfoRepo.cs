using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RowAndColumnCustomization_MAUI_DataGrid
{
	public class TicketInfoRepo
	{
		public ObservableCollection<TicketInfo> Tickets { get; set; }

		public TicketInfoRepo()
		{
			Tickets = new ObservableCollection<TicketInfo>();
			this.GenerateIncidents();
		}

		public void GenerateIncidents()
		{
			Tickets.Add(new TicketInfo("1001", "Maria Anders", "How do I create a custom data grid column in DataGrid?", "Germany"));
			Tickets.Add(new TicketInfo("1002", "Ana Trujillo", "How do I customize auto width calculation for a column?", "Mexico"));
			Tickets.Add(new TicketInfo("1003", "Ant Fuller", "How do I disable sorting in data grid?", "Mexico"));
			Tickets.Add(new TicketInfo("1004", "Thomas Hardy", "How do I customize the selection appearance in DataGrid?", "UK"));
			Tickets.Add(new TicketInfo("1005", "Tim Adams", "How do I get the row details by it in DataGrid?", "Sweden"));
			Tickets.Add(new TicketInfo("1006", "Hanna Moos", "How do I bind a data table collection to DataGrid?", "Germany"));
			Tickets.Add(new TicketInfo("1007", "Andrew Fuller", "How do I clear selection with a button click using MVVM in DataGrid?", "France"));
			Tickets.Add(new TicketInfo("1008", "Martin King", "How do I show multi-line header text in DataGrid?", "Spain"));
			Tickets.Add(new TicketInfo("1009", "Lenny Lin", "How do I customize the column header in DataGrid?", "France"));
			Tickets.Add(new TicketInfo("1010", "John Carter", "How do I add and delete rows and columns at runtime in MAUI DataGrid?", "Canada"));
		}
	}
}
