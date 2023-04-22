using UnityEditor;
using UnityEngine;

namespace SuperAshley.GoogleSpreadSheet
{
    public class SpreadSheetLoaderConfig : ScriptableObject
    {
        private static Sprite defaultSprite;
        public string SpreadsheetID;
        public string ScriptFolder;
        public string AssetFolder;
        public string SpriteAssetFolder;
        public string SkeletonDataFolder;
        public string PrefabFolder;
        public static SpreadSheetLoaderConfig Instance => GetInstance();

        private static SpreadSheetLoaderConfig GetInstance()
        {
            var value = AssetDatabase.LoadAssetAtPath<SpreadSheetLoaderConfig>(
                "Assets/Standard Assets/SAGoogleSpreadsheet/Editor/SpreadSheetLoaderConfig.asset");
            if (value == null)
            {
                value = CreateInstance<SpreadSheetLoaderConfig>();
                AssetDatabase.CreateAsset(value,
                    "Assets/Standard Assets/SAGoogleSpreadsheet/Editor/SpreadSheetLoaderConfig.asset");
            }

            return value;
        }
    }
}