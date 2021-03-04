using BlueApeUI.Contracts;
using BlueApeUI.Models.Responses;
using BlueApeUI.Utilities;
using Microsoft.AspNetCore.Components.Forms;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace BlueApeUI.Services
{
    public class FileManagerRepository : IFileManagerRepository
    {
        private readonly HttpClient _client;
        public FileManagerRepository(IHttpClientFactory factory)
        {
            _client = factory.CreateClient("fileClient");
        }
        public async Task<ResponseModel> UploadLogo(IBrowserFile file, string format)
        {
            var resizedImageFile = await file.RequestImageFileAsync(format, 500, 500);
            var buffer = new byte[resizedImageFile.Size];
            await resizedImageFile.OpenReadStream().ReadAsync(buffer);
            var imageDataUrl = $"data:{format};base64,{Convert.ToBase64String(buffer)}";
            var serialized = JsonConvert.SerializeObject(new { base64File = imageDataUrl, fileName = file.Name });
            var stringContent = new StringContent(serialized, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync($"{_client.BaseAddress}saveImage", stringContent).ConfigureAwait(false);
            var responseData = await response.Content.ReadFromJsonAsync<LogoUrl>();
            return ResponseUtilities.ResponseValidation(response.StatusCode, responseData.logoUrl);          
        }
        public async Task<ResponseModel> DeleteLogo(string fileName)
        {
            var response = await _client.DeleteAsync($"{_client.BaseAddress}deleteImage/{fileName}");
            return ResponseUtilities.ResponseValidation(response.StatusCode, String.Empty);
        }
        public async Task<ResponseModel> UploadImage(IBrowserFile file, string format)
        {
            var resizedImageFile = await file.RequestImageFileAsync(format, 500, 500);
            var buffer = new byte[resizedImageFile.Size];
            await resizedImageFile.OpenReadStream().ReadAsync(buffer);
            var imageDataUrl = $"data:{format};base64,{Convert.ToBase64String(buffer)}";
            var serialized = JsonConvert.SerializeObject(new { base64File = imageDataUrl, fileName = file.Name });
            var stringContent = new StringContent(serialized, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync($"{_client.BaseAddress}saveJpgImage", stringContent).ConfigureAwait(false);
            var responseData = await response.Content.ReadFromJsonAsync<ImageUrl>();
            return ResponseUtilities.ResponseValidation(response.StatusCode, responseData.imageUrl);
        }
        public async Task<ResponseModel> DeleteImage(string fileName)
        {
            var response = await _client.DeleteAsync($"{_client.BaseAddress}deleteJpgImage/{fileName}");
            return ResponseUtilities.ResponseValidation(response.StatusCode, String.Empty);
        }
    }
    public class LogoUrl
    {
        public string logoUrl { get; set; }
    }
    public class logoFileName
    {
        public string fileName { get; set; }
    }
    public class ImageUrl
    {
        public string imageUrl { get; set; }
    }
    public class imageFileName
    {
        public string fileName { get; set; }
    }
}
