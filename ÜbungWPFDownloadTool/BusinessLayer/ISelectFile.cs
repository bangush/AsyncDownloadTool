using System.Threading.Tasks;

namespace �bungWPFDownloadTool.BusinessLayer
{
    public interface ISelectFile
    {
        string ShowSaveFileDialog(string sourceFileName);
    }
}