using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemple.Solid
{
    public class Report
    {
        public string Title { get; set; }
        public string Content { get; set; }

        // Generarea raportului în diferite formate
        public void GenerateReport(string format)
        {
            if (format == "PDF")
            {
                // Cod pentru generarea unui raport PDF
                Console.WriteLine("Generating PDF report...");
            }
            else if (format == "Excel")
            {
                // Cod pentru generarea unui raport Excel
                Console.WriteLine("Generating Excel report...");
            }
            else if (format == "Word")
            {
                // Cod pentru generarea unui raport Word
                Console.WriteLine("Generating Word report...");
            }
            else
            {
                throw new ArgumentException("Invalid format");
            }
        }

        // Salvarea raportului în baza de date
        public void SaveToDatabase()
        {
            Console.WriteLine("Saving report to database...");
        }

        // Încarcă raportul din baza de date
        public void LoadFromDatabase(int reportId)
        {
            Console.WriteLine("Loading report from database...");
        }
    }

}
