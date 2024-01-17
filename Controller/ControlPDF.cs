using iTextSharp.text;
using iTextSharp.text.pdf;
using Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Controller
{
    public class ControlPDF
    {
        Control_Veterinario ctrlVet = new Control_Veterinario();
        public void generatePDF()
        {
            FileStream stream = null;

            try
            {
                List<Veterinario> lstVet = ctrlVet.GetVeterinarios();

                stream = new FileStream("Reporte de Veterinarios.pdf", FileMode.Create);

                Document doc = new Document(PageSize.A4, 5, 5, 7, 7);
                PdfWriter pdf = PdfWriter.GetInstance(doc, stream);

                doc.Open();
                iTextSharp.text.Font myFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12,
                   iTextSharp.text.Font.NORMAL, BaseColor.ORANGE);

                doc.Add(new Paragraph("Veterinarios Ingresados"));
                doc.Add(Chunk.NEWLINE);

                PdfPTable table = new PdfPTable(3);
                table.WidthPercentage = 100;

                PdfPCell colNames = new PdfPCell(new Phrase("Nombres:", myFont));
                colNames.BorderWidth = 0;
                colNames.BorderWidthBottom = 0.5f;

                //PdfPCell colLstNames = new PdfPCell(new Phrase("Apellidos:", myFont));
                //colLstNames.BorderWidth = 0;
                //colLstNames.BorderWidthBottom = 0.5f;

                PdfPCell colEspe = new PdfPCell(new Phrase("Especialidad:", myFont));
                colEspe.BorderWidth = 0;
                colEspe.BorderWidthBottom = 0.5f;

                table.AddCell(colNames);
                //table.AddCell(colLstNames);
                table.AddCell(colEspe);

                foreach (Veterinario vet in lstVet)
                {
                    colNames = new PdfPCell(new Phrase(vet.Nombres, myFont));
                    colNames.BorderWidth = 0;
                    colEspe = new PdfPCell(new Phrase(vet.Especialidad, myFont));
                    colEspe.BorderWidth = 0;
                    table.AddCell(colNames);
                    table.AddCell(colEspe);
                }

                doc.Add(table);
                doc.Close();
                pdf.Close();

                MessageBox.Show("Documento PDF generado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el PDF: {ex.Message}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                stream.Close();
            }
        }
    }
}