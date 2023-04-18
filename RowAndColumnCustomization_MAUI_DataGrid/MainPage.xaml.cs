namespace RowAndColumnCustomization_MAUI_DataGrid;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void dataGrid_QueryRowHeight(object sender, Syncfusion.Maui.DataGrid.DataGridQueryRowHeightEventArgs e)
	{
		e.Height = e.GetIntrinsicRowHeight(e.RowIndex);
		e.Handled = true;
	}
}

