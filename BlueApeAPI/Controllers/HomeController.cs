using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using MongoDB.Bson;
using MongoDB.Driver;
using Serilog;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BlueApeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : Controller
    {
        public HomeController(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }
        /// <summary>
        /// GET: HomeController
        /// </summary>
        /// <returns></returns>
        [HttpGet("api/[controller]")]
        public ActionResult Index()
        {
            string connectionString = Configuration.GetConnectionString("MongoConnection");
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("BlueApeDB");
            var collection = database.GetCollection<BsonDocument>("Blogs");
            var result = collection.Find(_ => true).ToList();
            Log.Warning(result.ToString());
            Log.Error("Logging is working");
            return BadRequest();
        }

        /// <summary>
        /// GET: HomeController/Details/5
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("api/[controller]/Details/{id}")]
        public ActionResult Details(int id)
        {
            return View();
        }

        /// <summary>
        /// GET: HomeController/Create
        /// </summary>
        /// <returns></returns>
        [HttpGet("api/[controller]/TestDownload")]
        public FileResult TestDownload()
        {
            try
            {
                var path = Path.Combine(Path.GetTempPath(), "newFolder");
                DirectoryInfo directory = Directory.CreateDirectory(path);
                var filePath = Path.Combine(Path.Combine(path, "test.txt"));
                FileInfo fi = new FileInfo(filePath);
                using (FileStream fs = fi.Create())
                {
                    Log.Warning(path);
                    byte[] txt = new UTF8Encoding(true).GetBytes("New file.");
                    fs.Write(txt, 0, txt.Length);
                    fs.Close();
                    var zipPath = Path.Combine(Path.GetTempPath(), "result.zip");
                    ZipFile.CreateFromDirectory(path, zipPath);
                    FileContentResult result = new FileContentResult(System.IO.File.ReadAllBytes(zipPath), "application/msword")
                    {
                        FileDownloadName = "result.zip"
                    };

                    directory.Delete();

                    return result;
                }
            } catch (Exception e)
            {
                Log.Error(e.Message);
            }
            throw new NotImplementedException();

        }

        /// <summary>
        /// POST: HomeController/Create
        /// </summary>
        /// <param name="collection"></param>
        /// <returns></returns>
        [HttpPost("api/[controller]/Create")]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        /// <summary>
        /// GET: HomeController/Edit/5
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("api/[controller]/Edit/{id}")]
        public ActionResult Edit(int id)
        {
            return View();
        }

        /// <summary>
        /// POST: HomeController/Edit/5
        /// </summary>
        /// <param name="id"></param>
        /// <param name="collection"></param>
        /// <returns></returns>
        [HttpPost("api/[controller]/Edit/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        /// <summary>
        /// GET: HomeController/Delete/5
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("api/[controller]/Delete/{id}")]
        public ActionResult Delete(int id)
        {
            return View();
        }

        /// <summary>
        /// POST: HomeController/Delete/5
        /// </summary>
        /// <param name="id"></param>
        /// <param name="collection"></param>
        /// <returns></returns>
        [HttpPost("api/[controller]/Delete/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
