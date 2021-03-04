using BlueApeUI.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace BlueApeUI.Utilities
{
    public static class ResponseUtilities
    {
        public static ResponseModel ResponseValidation(HttpStatusCode statusCode, string content)
        {
            switch (statusCode)
            {
                case HttpStatusCode.OK:

                    return new ResponseModel
                    {
                        content = content,
                        isSuccess = true,
                        message = "Checked Successfully"
                    };
                case HttpStatusCode.NoContent:
                    return new ResponseModel
                    {
                        content = string.Empty,
                        isSuccess = true,
                        message = "Checked Successfully"
                    };
                case HttpStatusCode.Unauthorized:
                    return new ResponseModel
                    {
                        content = string.Empty,
                        isSuccess = false,
                        message = "Unauthorized Access"
                    };
                case HttpStatusCode.BadRequest:
                    return new ResponseModel
                    {
                        content = string.Empty,
                        isSuccess = false,
                        message = "Bad Request"
                    };
                case HttpStatusCode.InternalServerError:
                    return new ResponseModel
                    {
                        content = string.Empty,
                        isSuccess = false,
                        message = "Internal Server Error"
                    };
                default:
                    return new ResponseModel
                    {
                        content = string.Empty,
                        isSuccess = false,
                        message = "Undefined Error Occured"
                    };

            }
        }
    }
}
