

namespace Sales.Services
{
    using System;
    using System.Threading.Tasks;
    using Sales.

    public class ApiService
    {
        public async Task<Response> GetList<T>(string urlBase, string prefix, string controller)
        {
            try
            {

            }
            catch (Exception ex)
            {
                return new Response
                {
                    IsSuccess = false,
                    Message = ex.Message,
                }

                throw;
            }
        }
    }
}
