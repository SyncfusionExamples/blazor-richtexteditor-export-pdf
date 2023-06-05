using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Syncfusion.Pdf;
using Syncfusion.HtmlConverter;

namespace BlazorRichTextEditorToPDF.Data
{
    public class ExportService
    {
        public MemoryStream ExportAsPdf(string content)
        {
            try
            {
                //Initialize HTML to PDF converter.
                HtmlToPdfConverter htmlConverter = new HtmlToPdfConverter();
                BlinkConverterSettings blinkConverterSettings = new BlinkConverterSettings();
                //Set Blink viewport size.
                blinkConverterSettings.ViewPortSize = new Syncfusion.Drawing.Size(1280, 0);
                //Assign Blink converter settings to HTML converter.
                htmlConverter.ConverterSettings = blinkConverterSettings;
                //Convert HTML string to PDF document.
                PdfDocument document = htmlConverter.Convert(content,"");
                //Create memory stream.
                MemoryStream stream = new MemoryStream();
                //Save the document to memory stream.
                document.Save(stream);
                return stream;
            }
            catch
            {
                return new MemoryStream();
            }
        }
    }
}
