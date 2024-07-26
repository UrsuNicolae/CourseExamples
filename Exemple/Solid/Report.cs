using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemple.Solid
{
    public interface IReportGenerator
    {
        void GenerateReport(Report report);
    }

    public class PDFReportGenerator : IReportGenerator
    {
        public void GenerateReport(Report report)
        {
            // Cod pentru generarea unui raport PDF
            Console.WriteLine("Generating PDF report...");
        }
    }

    public class ExcelReportGenerator : IReportGenerator
    {
        public void GenerateReport(Report report)
        {
            // Cod pentru generarea unui raport Excel
            Console.WriteLine("Generating Excel report...");
        }
    }

    public class WordReportGenerator : IReportGenerator
    {
        public void GenerateReport(Report report)
        {
            // Cod pentru generarea unui raport Word
            Console.WriteLine("Generating Word report...");
        }
    }

    public interface IReportRepository
    {
        void SaveToDatabase(Report report);
        void LoadFromDatabase(int reportId);
    }

    public class MySqlReportRepository : IReportRepository
    {
        // Salvarea raportului în baza de date
        public void SaveToDatabase(Report report)
        {
            Console.WriteLine("Saving report to sql database...");
        }

        // Încarcă raportul din baza de date
        public void LoadFromDatabase(int reportId)
        {
            Console.WriteLine("Loading report from sql database...");
        }
    }

    public class OracleReportRepository : IReportRepository
    {
        // Salvarea raportului în baza de date
        public void SaveToDatabase(Report report)
        {
            Console.WriteLine("Saving report to oracle database...");
        }

        // Încarcă raportul din baza de date
        public void LoadFromDatabase(int reportId)
        {
            Console.WriteLine("Loading report from oracle database...");
        }
    }

    public class Report
    {
        public string Title { get; set; }
        public string Content { get; set; }
    }

}
