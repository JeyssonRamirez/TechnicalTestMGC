using System;
using System.Collections.Generic;
using Core.DataTransferObject;
using Core.MainRepository.MasGlobal;
using Newtonsoft.Json;
using RestSharp;

namespace DataAccess.MasGlobalServices
{
    public class MasGlobalRepository : IMasGlobalRepository
    {
       public IEnumerable<EmployeeDto> GetEmployees()
        {
            var list = new List<EmployeeDto>();
            try
            {
                var client = new RestClient("http://masglobaltestapi.azurewebsites.net/api/Employees");
                var request = new RestRequest(Method.GET);
                request.AddHeader("cache-control", "no-cache");
                IRestResponse response = client.Execute(request);
                if (response.IsSuccessful)
                {
                    list = JsonConvert.DeserializeObject<List<EmployeeDto>>(response.Content);
                    return list;
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return list;
        }
    }
}
