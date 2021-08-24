using System.Collections.Generic;
using System.IO;

namespace RemKoBu.Core
{
    public class ImageFolders
    {
        #region Properties

        public DirectoryInfo RootDirectoryInfo { get; init; }
        public List<DirectoryInfo> SubFolderList { get; init; }

        #endregion

        #region Constructor

        public ImageFolders()
        {
            RootDirectoryInfo = new DirectoryInfo(@".\images");
            SubFolderList = new List<DirectoryInfo>
            {
                new DirectoryInfo(@".\images\recipes"),
                new DirectoryInfo(@".\images\ingredients"),
                new DirectoryInfo(@".\images\categories")
            };
        }

        #endregion

        #region Public Methods

        public void CreateFolders()
        {
            CreateRootFolder();
            CreateSubFolders();
        }

        #endregion

        #region Private Methods

        private void CreateRootFolder()
        {
            if (Directory.Exists(RootDirectoryInfo.FullName)) return;
            Directory.CreateDirectory(RootDirectoryInfo.FullName);
        }

        private void CreateSubFolders()
        {
            foreach (DirectoryInfo subFolder in SubFolderList)
            {
                if (Directory.Exists(subFolder.FullName)) break;
                Directory.CreateDirectory(subFolder.FullName);
            }
        }

        #endregion
    }
}