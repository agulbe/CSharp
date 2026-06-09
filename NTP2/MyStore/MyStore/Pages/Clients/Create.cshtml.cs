using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;

namespace MyStore.Pages.Clients
{
    public class CreateModel : PageModel
    {
        public ClientInfo clientInfo = new();
        public string errorMessage = "";
        public string successMessage = "";
        public void OnGet()
        {
        }

        public void OnPost() 
        {
            clientInfo.Name = Request.Form["name"].ToString();
            clientInfo.Email = Request.Form["email"].ToString();
            clientInfo.Phone = Request.Form["phone"].ToString();
            clientInfo.Address = Request.Form["address"].ToString();

            if(clientInfo.Name.Length ==0 || clientInfo.Email.Length==0||
                clientInfo.Phone.Length==0||clientInfo.Address.Length==0)
            {
                errorMessage = "All the fields are required.";
                return;
            }
            try
            {
                string connectionString = "Data Source=ALPERPC;Initial Catalog=mystore;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";
                using (SqlConnection connection = new(connectionString))
                {
                    connection.Open();
                    string sql = "INSERT INTO clients " +
                                 "(Name, Email, Phone, Address, Created_at) VALUES " +
                                 "(@Name, @Email, @Phone, @Address, @Created_at);";
                    using (SqlCommand command = new(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Name", clientInfo.Name);
                        command.Parameters.AddWithValue("@Email", clientInfo.Email);
                        command.Parameters.AddWithValue("@Phone", clientInfo.Phone);
                        command.Parameters.AddWithValue("@Address", clientInfo.Address);
                        command.Parameters.AddWithValue("@Created_at", DateTime.Now);
                        command.ExecuteNonQuery();
                    }
                }
                successMessage = "Client added successfully.";

                clientInfo.Name = ""; 
                clientInfo.Email = ""; 
                clientInfo.Phone = ""; 
                clientInfo.Address = "";
                //Response.Redirect("/Clients/Index");
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                Console.WriteLine(ex.Message);
            }
        }
    }
}
