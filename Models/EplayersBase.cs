using System.IO;

namespace Aula37_Eplayers.Models
{
    public class EplayersBase
    {
               //Criar arquivo e pasta
           public void CreateFolderAndFile(string _path){

            string folder   = _path.Split("/")[0];
           
            if(!Directory.Exists(folder)){
                Directory.CreateDirectory(folder);
            }

            if(!File.Exists(_path)){
                File.Create(_path).Close();
            }
    }
}
}