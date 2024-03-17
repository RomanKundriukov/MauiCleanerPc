using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiCleanerPc.ViewModel
{
    public partial class StartPageViewModel : ObservableObject
    {
        private string _benutzer = String.Empty;

        [ObservableProperty]
        private string[] filesInPrefetchFolder;
        private string[] filesInTempFolder;
        
        //[ObservableProperty]
        //ObservableCollection<string> filesInTempFolder = new();
        
        public void benutzerName()
        {
            _benutzer = Environment.UserName;
        }


        [RelayCommand]
        public void lesenOrdner()
        {
            prefetchFolder();
            tempFolder();
            
        }

        public void prefetchFolder()
        {
            //prefetch
            string windowsFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.Windows);
            string prefetchFolderPath = Path.Combine(windowsFolderPath, "Prefetch");
            try
            {
                filesInPrefetchFolder = Directory.GetFiles(prefetchFolderPath);

                foreach (string file in filesInPrefetchFolder)
                {
                    FileInfo fileInfo = new FileInfo(file);
                    long fileSize = fileInfo.Length;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void tempFolder()
        {
            //Temp
            string tempFolderPath = Path.GetTempPath();
            try
            {
                filesInTempFolder = Directory.GetFiles(tempFolderPath);

                foreach (string file in filesInTempFolder)
                {
                    FileInfo fileInfo = new FileInfo(file);

                    long fileSize = fileInfo.Length;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void diagramm()
        {

        }
    }
}
