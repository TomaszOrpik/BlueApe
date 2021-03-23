using BlueApeUI.Models.Responses;
using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueApeUI.Contracts
{
    public interface IFileManagerRepository
    {
        public Task<ResponseModel> UploadLogo(IBrowserFile file, string format);
        public Task<ResponseModel> DeleteLogo(string fileName);
        public Task<ResponseModel> UploadImage(IBrowserFile file, string format);
        public Task<ResponseModel> DeleteImage(string fileName);
        public string GenerateUrl();
    }
}
