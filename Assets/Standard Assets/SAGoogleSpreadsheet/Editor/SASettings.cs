//----------------------------------------------
// SA: Google Spreadsheet Loader
// Copyright © 2014 SuperAshley Entertainment
//----------------------------------------------

using UnityEngine;
using UnityEditor;
using System.Collections;

namespace SuperAshley.GoogleSpreadSheet
{
    public class SASettings
    {
        static public string SpreadsheetID
        {
//            get { return EditorPrefs.GetString("SASpreadsheetID", "1TtZA6pNTPko10hFZ-OL3q-6GNfwqnvxjxD3cTx04wsY"); }
//            set { EditorPrefs.SetString("SASpreadsheetID", value); }
            get { return SpreadSheetLoaderConfig.Instance.SpreadsheetID; }
            set
            {
                SpreadSheetLoaderConfig.Instance.SpreadsheetID =  value;
                EditorUtility.SetDirty(SpreadSheetLoaderConfig.Instance);
            }
        }

        static public string WorksheetJSON
        {
            get { return EditorPrefs.GetString("SAWorksheetJSON", string.Empty); }
            set { EditorPrefs.SetString("SAWorksheetJSON", value); }
        }

        static public string CellsJSON
        {
            get { return EditorPrefs.GetString("SACellsJSON", string.Empty); }
            set { EditorPrefs.SetString("SACellsJSON", value); }
        }

        static public string SelectedWorksheet
        {
            get { return EditorPrefs.GetString("SASelectedWorksheet", string.Empty); }
            set { EditorPrefs.SetString("SASelectedWorksheet", value); }
        }

        static public string ScriptFolder
        {
//            get { return EditorPrefs.GetString("SAScriptFolder", "Assets"); }
//            set { EditorPrefs.SetString("SAScriptFolder", value); }
            get { return SpreadSheetLoaderConfig.Instance.ScriptFolder; }
            set
            {
                SpreadSheetLoaderConfig.Instance.ScriptFolder =  value; 
                EditorUtility.SetDirty(SpreadSheetLoaderConfig.Instance);

            }
        }

        static public string AssetFolder
        {
//            get { return EditorPrefs.GetString("SAAssetFolder", "Assets"); }
//            set { EditorPrefs.SetString("SAAssetFolder", value); }
            get { return SpreadSheetLoaderConfig.Instance.AssetFolder; }
            set
            {
                SpreadSheetLoaderConfig.Instance.AssetFolder =  value; 
                EditorUtility.SetDirty(SpreadSheetLoaderConfig.Instance);
            }
        }
    }
}