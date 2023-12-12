using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileRenamer.DataAccess;

public interface IFileRepository
{
   void addFile(FileInfo file);
   void deleteFile(FileInfo file);
   List<FileInfo> getAllFiles();
}
