/*
 * Created by SharpDevelop.
 * User: mohammedibrahim
 * Date: 2/3/2016
 * Time: 9:29 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using tessnet2;
using System.Text.RegularExpressions;
using System.Reflection;

namespace Tesseract_OCR
{
	class Program
	{
		public static void Main(string[] args)
		    {

			    ocr_demo();
		    }

        static void ocr_demo()
         {
                string appPath = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
				//change the below image location
                var image = new Bitmap(@"C:\Users\ibrahim\Desktop\Tesseract_OCR-master\test.jpeg");
                var ocr = new tessnet2.Tesseract();

                //change the below tessdata folder location which is avaliable in Source code
                ocr.Init(@"C:\Users\ibrahim\Desktop\Tesseract_OCR-master\tessdata", "eng", false);
                 
                var result = ocr.DoOCR(image, Rectangle.Empty);
                foreach (tessnet2.Word word in result)
                {	
                	Console.WriteLine(word.Text);
            	}
            Console.ReadKey();

        }
	}


}