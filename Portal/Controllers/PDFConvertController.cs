using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Portal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PDFConvertController : ControllerBase
    {
        [HttpPost]
        public String Post([FromForm]IFormCollection files)
        {
            if (files.Files.Count == 0)
                throw new ArgumentNullException("file can't be null");
            using(Stream fs=files.Files[0].OpenReadStream())
            {
                var str= Base64Convert.FileToBase64(fs);
                return str;
            }
        }
    }
}