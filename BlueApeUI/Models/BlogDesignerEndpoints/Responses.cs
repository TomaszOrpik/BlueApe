using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueApeUI.Models.Responses
{
    public class UserBlogsResponse
    {
        public string[] blogNames { get; set; }
    }
    public class IsExistResponse
    {
        public bool isExist { get; set; }
    }
    public class ResponseModel
    {
        public string content { get; set; }
        public bool isSuccess { get; set; }
        public string message { get; set; }
    }
}
