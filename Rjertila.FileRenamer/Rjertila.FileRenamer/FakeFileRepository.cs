using System;
using System.Collections.Generic;
using System.IO;

namespace FileRenamer.DataAccess
{
    public class FakeFileRepository : IFileRepository
    {
        private List<FileInfo> files;

        public FakeFileRepository()
        {
            files = new List<FileInfo>();

            for (int i = 1; i <= 30; i++)
            {
                var fakeFile = new FileInfo($"./fakeFile{i}.txt");
                files.Add(fakeFile);
            }
        }

        public void addFile(FileInfo file)
        {
            files.Add(file);
        }

        public void deleteFile(FileInfo file)
        {
            files.Remove(file);
        }

        public List<FileInfo> getAllFiles()
        {
            return files;
        }
    }
}
