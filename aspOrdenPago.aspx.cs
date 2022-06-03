using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace wsCompras_Hgo
{
    public partial class Formulario_web117 : System.Web.UI.Page
    {

        public void firmar(Stream input, Stream imagen, Stream output, int x)
        {
            var reader = new PdfReader(input);
            var stamper = new PdfStamper(reader, output);
            var pdfContentByte = stamper.GetOverContent(1);

            iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(imagen);
            image.SetAbsolutePosition(x, 325);
            image.ScaleAbsoluteHeight(50);
            image.ScaleAbsoluteWidth(50);
            pdfContentByte.AddImage(image);
            stamper.Close();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnPDF_Click(object sender, EventArgs e)
        {
            // Firma DG
            using (Stream inputPdfStream = new FileStream(Server.MapPath("~\\ODP\\OP_Telmex_Abril.pdf"), FileMode.Open, FileAccess.Read, FileShare.Read))
            using (Stream inputImageStream = new FileStream(Server.MapPath("~\\Firmas\\DG_HGO.png"), FileMode.Open, FileAccess.Read, FileShare.Read))
            using (Stream outputPdfStream = new FileStream(Server.MapPath("~\\ODP\\OP_Telmex_Abril_Firmado.pdf"), FileMode.Create, FileAccess.Write, FileShare.None))
            {
                firmar(inputPdfStream, inputImageStream, outputPdfStream, 350);
            }

            // Copia el archivo firmado para poder insertar segunda firma
            File.Copy(Server.MapPath("~\\ODP\\OP_Telmex_Abril_Firmado.pdf"), Server.MapPath("~\\ODP\\pdf_temp.pdf"));

            // Firma responsable de area
            using (Stream inputPdfStream = new FileStream(Server.MapPath("~\\ODP\\pdf_temp.pdf"), FileMode.Open, FileAccess.Read, FileShare.Read))
            using (Stream inputImageStream = new FileStream(Server.MapPath("~\\Firmas\\TI_HGO.png"), FileMode.Open, FileAccess.Read, FileShare.Read))
            using (Stream outputPdfStream = new FileStream(Server.MapPath("~\\ODP\\OP_Telmex_Abril_Firmado.pdf"), FileMode.Create, FileAccess.Write, FileShare.None))
            {
                firmar(inputPdfStream, inputImageStream, outputPdfStream, 200);
            }

            File.Delete(Server.MapPath("~\\ODP\\pdf_temp.pdf"));
        }
    }
}