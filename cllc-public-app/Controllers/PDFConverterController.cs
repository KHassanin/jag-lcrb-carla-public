using DocumentFormat.OpenXml.Packaging;
using GemBox.Document;
using Gov.Lclb.Cllb.Interfaces;
using Gov.Lclb.Cllb.Public.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using OpenXmlPowerTools;
using Spire.Doc;
using System;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Packaging;
using System.Reflection;
using System.Xml.Linq;
using static Gov.Lclb.Cllb.Services.FileManager.FileManager;

namespace Gov.Lclb.Cllb.Public.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PDFConverterController : ControllerBase
    {
        private readonly BCeIDBusinessQuery _bceid;
        private readonly IConfiguration _configuration;
        private readonly IDynamicsClient _dynamicsClient;
        private readonly IOrgBookClient _orgBookclient;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ILogger _logger;
        private readonly FileManagerClient _fileManagerClient;
        private readonly IWebHostEnvironment _env;
        
        public PDFConverterController(IConfiguration configuration,
            IHttpContextAccessor httpContextAccessor,
            IOrgBookClient orgBookClient,
            BCeIDBusinessQuery bceid,
            ILoggerFactory loggerFactory,
            IDynamicsClient dynamicsClient,
            FileManagerClient fileManagerClient,
            IWebHostEnvironment env)
        {
            _configuration = configuration;
            _bceid = bceid;
            _dynamicsClient = dynamicsClient;
            _env = env;
            _orgBookclient = orgBookClient;
            _httpContextAccessor = httpContextAccessor;
            _fileManagerClient = fileManagerClient;
            _logger = loggerFactory.CreateLogger(typeof(PDFConverterController));
        }
        [HttpPost("convert-file-pdf")]
        [AllowAnonymous]
        public IActionResult ConvertFilePDF([FromBody] string base64File)
        {
            _logger.LogDebug(LoggingEvents.HttpPost, "Begin method " + GetType().Name + "." + MethodBase.GetCurrentMethod().ReflectedType.Name);

            var guid = Guid.NewGuid();
            var folderName = "ConvertFiles";
            var docFilName = $@"{folderName}\{guid}.docx";
            var pdfFilName = $@"{folderName}\{guid}-pdf.pdf";
            var htmlFilName = $@"{folderName}\{guid}-html.html";
            var htmlContent=string.Empty;
            try
            {

                if (!Directory.Exists(folderName))
                    Directory.CreateDirectory(folderName);

                byte[] byteArray = Convert.FromBase64String(base64File);
                System.IO.File.WriteAllBytes(docFilName, byteArray);
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    memoryStream.Write(byteArray, 0, byteArray.Length);
                    Aspose.Words.Document doc = new Aspose.Words.Document(docFilName);
                    doc.Save(pdfFilName);

                    //using (WordprocessingDocument doc = WordprocessingDocument.Open(memoryStream, true))
                    //{
                    //    int imageCounter = 0;
                    //    HtmlConverterSettings settings = new HtmlConverterSettings()
                    //    {
                    //        PageTitle = "My Page Title",
                    //        ImageHandler = imageInfo =>
                    //        {
                    //            DirectoryInfo localDirInfo = new DirectoryInfo("img");
                    //            if (!localDirInfo.Exists)
                    //                localDirInfo.Create();
                    //            ++imageCounter;
                    //            string extension = imageInfo.ContentType.Split('/')[1].ToLower();
                    //            ImageFormat imageFormat = null;
                    //            if (extension == "png")
                    //            {
                    //                extension = "gif";
                    //                imageFormat = ImageFormat.Gif;
                    //            }
                    //            else if (extension == "gif")
                    //                imageFormat = ImageFormat.Gif;
                    //            else if (extension == "bmp")
                    //                imageFormat = ImageFormat.Bmp;
                    //            else if (extension == "jpeg")
                    //                imageFormat = ImageFormat.Jpeg;
                    //            else if (extension == "tiff")
                    //            {
                    //                extension = "gif";
                    //                imageFormat = ImageFormat.Gif;
                    //            }
                    //            else if (extension == "x-wmf")
                    //            {
                    //                extension = "wmf";
                    //                imageFormat = ImageFormat.Wmf;
                    //            }
                    //            if (imageFormat == null)
                    //                return null;
                    //            string imageFileName = "img/image" +
                    //                imageCounter.ToString() + "." + extension;
                    //            try
                    //            {
                    //                imageInfo.Bitmap.Save(imageFileName, imageFormat);
                    //            }
                    //            catch (System.Runtime.InteropServices.ExternalException)
                    //            {
                    //                return null;
                    //            }
                    //            XElement img = new XElement(Xhtml.img,
                    //                new XAttribute(NoNamespace.src, imageFileName),
                    //                imageInfo.ImgStyleAttribute,
                    //                imageInfo.AltText != null ?
                    //                    new XAttribute(NoNamespace.alt, imageInfo.AltText) : null);
                    //            return img;
                    //        }
                    //    };
                    //    XElement html = HtmlConverter.ConvertToHtml(doc, settings);
                    //   System.IO.File.WriteAllText(htmlFilName, html.ToStringNewLineOnAttributes());
                    //    htmlContent = html.ToStringNewLineOnAttributes();
                    //};

                }

                
                var pdfBytes = (new NReco.PdfGenerator.HtmlToPdfConverter()).GeneratePdf(htmlContent);
                //System.IO.File.WriteAllBytes(pdfFilName, pdfBytes);
                return new JsonResult(Convert.ToBase64String(pdfBytes));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error while converting word file from PDF, Guid : {guid}");

                throw;
            }
            finally
            {
                DeleteFile(docFilName);
                DeleteFile(pdfFilName);
                DeleteFile(htmlFilName);
            }     


        }
       
        //public IActionResult ConvertFilePDF([FromBody] string base64File)
        //{
        //    _logger.LogDebug(LoggingEvents.HttpPost, "Begin method " + GetType().Name + "." + MethodBase.GetCurrentMethod().ReflectedType.Name);

        //    var guid = Guid.NewGuid();
        //    var folderName ="ConvertFiles";
        //    var docFilName= $@"{folderName}\{guid}.docx";
        //    var pdfFilName= $@"{folderName}\{guid}-pdf.pdf";
        //    try
        //    {

        //        if (!Directory.Exists(folderName))
        //            Directory.CreateDirectory(folderName);

        //        byte[] newBytes = Convert.FromBase64String(base64File);
        //        System.IO.File.WriteAllBytes(docFilName, newBytes);
        //        Spire.Doc.Document document = new Spire.Doc.Document();
        //        document.LoadFromFile(docFilName);

        //        var fontFile = "data/Calibri.ttf";
        //        ToPdfParameterList parms = new ToPdfParameterList();
        //        List<PrivateFontPath> fonts = new List<PrivateFontPath>();
        //        fonts.Add(new PrivateFontPath("Calibri", fontFile));
        //         parms.PrivateFontPaths = fonts;  

        //        document.SaveToFile(pdfFilName,parms);
        //        var pdfBytes = System.IO.File.ReadAllBytes(pdfFilName);
        //        DeleteFile(docFilName);
        //        DeleteFile(pdfFilName);
        //        return new JsonResult(Convert.ToBase64String(pdfBytes));
        //    }
        //    catch (Exception ex)
        //    {
        //        DeleteFile(docFilName);
        //        DeleteFile(pdfFilName);
        //        _logger.LogError(ex, $"Error while converting word file from PDF, Guid : {guid}");

        //        throw;
        //    }
        //}

        private void DeleteFile(string fileName)
        {
            if (System.IO.File.Exists(fileName))
            {
                System.IO.File.Delete(fileName);
            }
        }

    }
}
