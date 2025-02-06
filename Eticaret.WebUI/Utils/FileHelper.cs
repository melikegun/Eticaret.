namespace Eticaret.WebUI.Utils
{
    public class FileHelper
    {
        public static async Task<String> FileLoaderAsync(IFormFile formFile,
            string filePath = "/Img/")
        {
            string fileName = "";

            if(formFile != null && formFile.Length > 0)
            {
                //Dosyanın adını küçük harfe çevirerek kaydediyor.
                fileName = formFile.FileName.ToLower();


                //Projenin çalıştığı dizini bulur.
                //filePath değeri varsayılan olarak "/Img/"
                string directory = Directory.GetCurrentDirectory()
                    + "/wwwroot" + filePath + fileName;

                //Dosya yazma işlemi başlatılır.
                using var stream = new FileStream(directory,
                    FileMode.Create);

                //Dosyanın belirlenen dizine yüklenmesini sağlar.
                await formFile.CopyToAsync(stream);
            }

            return fileName;
        }

        public static bool FileRemover(string fileName, string filePath = "/Img/" )
        {
            string directory = Directory.GetCurrentDirectory() + "/wwwroot" + filePath + fileName;

            if(File.Exists(directory))
            {
                File.Delete(directory);
                return true;
            }
            return false;
                
        }
    }
}
