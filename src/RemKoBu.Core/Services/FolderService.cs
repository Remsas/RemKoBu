using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace RemKoBu.Core.Services
{
    public static class FolderService
    {
        #region Public Methods

        public static void CreateImageFolders()
        {
            ImageFolders imageFolders = new ImageFolders();
            imageFolders.CreateFolders();
        }

        public static DirectoryInfo GetRootImageFolderDirectoryInfo()
        {
            ImageFolders imageFolders = new ImageFolders();
            return imageFolders.RootDirectoryInfo;
        }

        public static List<DirectoryInfo> GetSubImageFolderDirectoryInfos()
        {
            ImageFolders imageFolders = new ImageFolders();
            return imageFolders.SubFolderList;
        }

        public static string GetRootImageFolderPath()
        {
            ImageFolders imageFolders = new ImageFolders();
            return imageFolders.RootDirectoryInfo.FullName;
        }

        public static string[] GetAllSubImageFoldersPath()
        {
            ImageFolders imageFolders = new ImageFolders();
            string[] subFoldersStrings = new string[imageFolders.SubFolderList.Count];
            for (int i = 0; i < imageFolders.SubFolderList.Count; i++)
            {
                subFoldersStrings[i] = imageFolders.SubFolderList[i].FullName;
            }

            return subFoldersStrings;
        }

        public static string GetRecipeImageFolderPath()
        {
            ImageFolders imageFolders = new ImageFolders();
            var di = imageFolders.SubFolderList.FirstOrDefault(item => item.Name == "recipes");
            if (di == null) return "The path of the image folder for the recipes is unknown.";
            if (Directory.Exists(di.FullName))
                return di.FullName;
            return "The image folder for the recipes does not exists.";
        }

        public static string GetIngredientsImageFolderPath()
        {
            ImageFolders imageFolders = new ImageFolders();
            var di = imageFolders.SubFolderList.FirstOrDefault(item => item.Name == "ingredients");
            if (di == null) return "The path of the image folder for the ingredients is unknown.";
            if (Directory.Exists(di.FullName))
                return di.FullName;
            return "The image folder for the ingredients does not exists.";
        }

        public static string GetCategoriesImageFolderPath()
        {
            ImageFolders imageFolders = new ImageFolders();
            var di = imageFolders.SubFolderList.FirstOrDefault(item => item.Name == "categories");
            if (di == null) return "The path of the image folder for the categories is unknown.";
            if (Directory.Exists(di.FullName))
                return di.FullName;
            return "The image folder for the categories does not exists.";
        }

        #endregion

    }
}