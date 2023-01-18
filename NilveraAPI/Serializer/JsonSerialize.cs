using Newtonsoft.Json;
using NilveraAPI.Models.Pagination;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NilveraAPI.Serializer
{
    public static class JsonSerialize
    {
        public static GeneralResponse<T> Parse<T>(this RestResponse<T> response)
        {
            if (response.IsSuccessful)
            {
                if (response.Content != null)
                {
                    T model = JsonConvert.DeserializeObject<T>(response.Content);
                    if (model != null)
                    {
                        return new GeneralResponse<T>
                        {
                            IsSuccess = true,
                            Content = model
                        };
                    }

                    model = System.Text.Json.JsonSerializer.Deserialize<T>(response.Content);
                    if (model != null)
                    {
                        return new GeneralResponse<T>
                        {
                            IsSuccess = true,
                            Content = model
                        };
                    }
                }

                return new GeneralResponse<T>
                {
                    IsSuccess = false,
                    ErrorMessage = "Response Deserialize Edilemedi."
                };
            }
            return new GeneralResponse<T> { IsSuccess = false };
        }
    }
}
