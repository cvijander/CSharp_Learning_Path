using OfficeOpenXml;

namespace ExcelDemo
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            ExcelPackage.License.SetNonCommercialPersonal("Borko");
            var file = new FileInfo(@"D:\Dev\csharp\CSharp_Learning_Path\IAmTimCorey\excelFile.xlsx");

            var people = GetSetupData();

            await SaveExcelFile(people, file);
        }

        private static async Task SaveExcelFile(List<PersonalModel> people, FileInfo file)
        {
            DeleteIfExists(file);

            using var package = new ExcelPackage(file);
            
            var ws = package.Workbook.Worksheets.Add("MainReport");

            var range = ws.Cells["A1"].LoadFromCollection(people, true);

            range.AutoFitColumns();

            await package.SaveAsync();
        }

        private static void DeleteIfExists(FileInfo file)
        {
           if (file.Exists)
            {
                file.Delete();
            }
        }

        private static List <PersonalModel> GetSetupData()
        {
            List<PersonalModel> output = new()
            {
                new PersonalModel() { Id = 1, FirstName ="Tim", LastName = "Corey"},
                new PersonalModel() { Id = 2, FirstName = "Sue", LastName = "Storm"},
                new PersonalModel() { Id = 3 , FirstName = "Jane", LastName = "Smith"}


            };

            return output;
        }
    }
}
