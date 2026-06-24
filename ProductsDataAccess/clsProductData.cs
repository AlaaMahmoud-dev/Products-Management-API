using ProductsModels;
using Microsoft.SqlServer.Server;
using Microsoft.Data.SqlClient;
namespace ProductsDataAccess
{
    public static class clsProductData
    {
        public static List<ProductDTO> GetProducts()
        {
            List<ProductDTO> products = new List<ProductDTO>();
            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "select * from Products";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    try
                    {
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            
                            products.Add(new ProductDTO()
                            {
                                Id = (int)reader["ID"],
                                ProductName = (string)reader["ProductName"],
                                Price = (decimal)reader["Price"],
                                Quantity = (int)reader["Quantity"],
                                Tax = (decimal)reader["Tax"],
                                CreatedAt = (DateTime)reader["CreatedAt"]
                            });
                        }
                    }
                    catch
                    {
                        return null;
                    }
                    return products;
                }
            }
        }
        public static List<ProductDTO> Search(string name)
        {
            List<ProductDTO> products = new List<ProductDTO>();
            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "select * from Products where ProductName like @name ";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    try
                    {
                        conn.Open();
                        cmd.Parameters.AddWithValue("name",'%' + name + '%');
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {

                            products.Add(new ProductDTO()
                            {
                                Id = (int)reader["ID"],
                                ProductName = (string)reader["ProductName"],
                                Price = (decimal)reader["Price"],
                                Quantity = (int)reader["Quantity"],
                                Tax = (decimal)reader["Tax"],
                                CreatedAt = (DateTime)reader["CreatedAt"]
                            });
                        }
                    }
                    catch
                    {
                        return null;
                    }
                    return products;
                }
            }
        }

        public static ProductDTO GetInfoByID(int ID)
        {
            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "select * from Products where ID = @ID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    try
                    {

                        conn.Open();
                        cmd.Parameters.AddWithValue("@ID", ID);
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {

                            return new ProductDTO()
                            {
                                Id = (int)reader["ID"],
                                ProductName = (string)reader["ProductName"],
                                Price = (decimal)reader["Price"],
                                Quantity = (int)reader["Quantity"],
                                Tax = (decimal)reader["Tax"],
                                CreatedAt = (DateTime)reader["CreatedAt"]
                            };
                        }
                    }
                    catch
                    {
                        return null;
                    }
                    return null;
                }
            }
        }
        public static int AddNewProduct(ProductDTO productDTO)
        {
            int ID = -1;
            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"Insert into Products(ProductName,Price,Quantity,Tax,CreatedAt) Values
                                 (@ProductName,@Price,@Quantity,@Tax,@CreatedAt);
                                 Select SCOPE_IDENTITY()";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    try
                    {
                        conn.Open();
                        cmd.Parameters.AddWithValue("@ProductName", productDTO.ProductName);
                        cmd.Parameters.AddWithValue("@Price", productDTO.Price);
                        cmd.Parameters.AddWithValue("@Tax", productDTO.Tax);
                        cmd.Parameters.AddWithValue("@Quantity", productDTO.Quantity);

                        cmd.Parameters.AddWithValue("@CreatedAt", productDTO.CreatedAt);
                        object result = cmd.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            ID = insertedID;
                        }

                    }
                    catch
                    {
                        return -1;
                    }
                    return ID;
                }
            }
        }
        public static bool UpdateProduct(ProductDTO productDTO)
        {
            int rowsEffected = 0;
            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"Update Products 
                                 set ProductName=@ProductName,
                                 Price=@Price,
                                 Quantity=@Quantity,
                                 Tax=@Tax,
                                 CreatedAt=@CreatedAt
                                 where ID = @ID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    try
                    {
                        conn.Open();
                        cmd.Parameters.AddWithValue("@ID", productDTO.Id);

                        cmd.Parameters.AddWithValue("@ProductName", productDTO.ProductName);
                        cmd.Parameters.AddWithValue("@Price", productDTO.Price);
                        cmd.Parameters.AddWithValue("@Tax", productDTO.Tax);
                        cmd.Parameters.AddWithValue("@Quantity", productDTO.Quantity);

                        cmd.Parameters.AddWithValue("@CreatedAt", productDTO.CreatedAt);
                        rowsEffected = cmd.ExecuteNonQuery();
                        

                    }
                    catch
                    {
                        return false;
                    }
                    return rowsEffected > 0;
                }
            }
        }

        public static bool Delete(int ID)
        {
            int rowsEffected = 0;
            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"Delete from Products 
                                 where ID = @ID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    try
                    {
                        conn.Open();
                        cmd.Parameters.AddWithValue("@ID", ID);                     
                        rowsEffected = cmd.ExecuteNonQuery();
                    }
                    catch
                    {
                        return false;
                    }
                    return rowsEffected > 0;
                }
            }
        }
    }
}
