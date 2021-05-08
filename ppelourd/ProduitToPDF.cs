using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System.Diagnostics;

namespace ppelourd
{
    class ProduitToPDF
    {
        private List<Buy> buysList = new List<Buy>();

        private Produit produit;

        public ProduitToPDF (List<Buy> buysList, Produit produit )
        {
            this.buysList = buysList;
            this.produit = produit;

        }

        public void ToPDF(string filename)
        {
            // Create a new PDF document
            PdfDocument document = new PdfDocument();
            document.Info.Title = produit.Nom;

            // Create an empty page
            PdfPage page = document.AddPage();

            // Get an XGraphics object for drawing
            XGraphics gfx = XGraphics.FromPdfPage(page);

            // Create a font
            XFont font = new XFont("Verdana", 14, XFontStyle.BoldItalic);
            XFont fontDetails = new XFont("Times New Roman", 12, XFontStyle.Regular);

            int marginx = 20;

            int x = 0;

            int y = 50;

            gfx.DrawString(produit.Nom, font, XBrushes.Red, new XRect(0, y, page.Width, 30), XStringFormats.Center);
            y += 30;
            y += 30;


            foreach (Buy buy in buysList)
            {
                x = 0;

                int marginLine = 10;
                
                gfx.DrawString(buy.Username, font, XBrushes.Black, marginx+x, y);
                y += 30;

                //Nouvelle Ligne

                x = 0;
                gfx.DrawString("Quantite : " , fontDetails, XBrushes.Black, marginx + marginLine + x, y);
                x += 50;

                gfx.DrawString(buy.Quantite.ToString(), fontDetails, XBrushes.Black, marginx +marginLine + x, y);
                y += 30;

                // Nouvelle Ligne

                x = 0;
                gfx.DrawString("Date de la commande : ", fontDetails, XBrushes.Black, marginx + marginLine + x, y);
                x += 120;

                gfx.DrawString(buy.Date.ToString(), fontDetails, XBrushes.Black, marginx + marginLine + x, y);
                y += 30;

                gfx.DrawLine(new XPen(XColors.Black, 1), 0, y, page.Width, y);
                y += 30;


            }

            // Draw the text
           

            // Save the document...
           
            document.Save(filename);
            // ...and start a viewer.
            Process.Start(filename);
        }
    }

}
