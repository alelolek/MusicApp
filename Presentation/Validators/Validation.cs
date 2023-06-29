
namespace Presentation.Validators
{
	public class Validation
	{
		public static bool CamposVacios(params Control[] controles)
		{
			foreach (var control in controles)
			{
				if (control is TextBox textBox && string.IsNullOrEmpty(textBox.Text))
				{
					return true;
				}
				else if (control is ComboBox comboBox && comboBox.SelectedItem == null)
				{
					return true;
				}
			}
			return false;
		}
	}
}
