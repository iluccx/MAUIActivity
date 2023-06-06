using MauiActivity.MVVM.ViewModel;
using Microsoft.Data.SqlClient;

namespace MauiActivity.MVVM.Views;

public partial class DatabaseView : ContentPage
{
	public DatabaseView()
	{
		InitializeComponent();
    }

    private void BtnCommon_Clicked(object sender, EventArgs e)
    {
        //string connectionString = "server=10.2.14.55;user=sa;database=dbHolamundo;password=sa;";
        string connectionString = @"Data Source=10.2.14.55,1433;Initial Catalog=dbholaMundo;User ID=sa;Password=sistemas123;TrustServerCertificate=True;MultiSubnetFailover=True;";
        using (SqlConnection connection = new SqlConnection (connectionString))
        {
            try
            {
                var prueba = id.Text;
                connection.Open();

                SqlCommand command = new SqlCommand("INSERT INTO Sistemas_Operativos (id, Strnombre,telefono,email,Observacion,Datingreso ) VALUES (@value1, @value2, @value3, @value4, @value5, @value6)", connection);
                command.Parameters.AddWithValue("@value1", id.Text);
                command.Parameters.AddWithValue("@value2", name.Text);
                command.Parameters.AddWithValue("@value3", tel.Text);
                command.Parameters.AddWithValue("@value4", email.Text);
                command.Parameters.AddWithValue("@value5", obse.Text);
                command.Parameters.AddWithValue("@value6", datIngre.Text);
                command.ExecuteNonQuery();

                connection.Close();

                // Cerrar la conexión después de realizar la inserción.

            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir durante la conexión o la inserción.
                 Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
