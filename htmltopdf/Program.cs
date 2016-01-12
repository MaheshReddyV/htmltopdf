using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace htmltopdf
{
    class Program
    {
        static void Main(string[] args)
        {
            string v="<!DOCTYPE html PUBLIC '-//W3C//DTD XHTML 1.0 Transitional//EN' 'http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd'><html xmlns='http://www.w3.org/1999/xhtml'><head></head><body><h1>WELCOME TO WORLD OF HTML to PDF</h1></body><html>          ";          
            var pdfBytes = (new NReco.PdfGenerator.HtmlToPdfConverter()).GeneratePdf(v);
            System.IO.File.WriteAllBytes("F:\\Work\\htmltopdf\\myfile.pdf", pdfBytes);
        }   
    }
}
