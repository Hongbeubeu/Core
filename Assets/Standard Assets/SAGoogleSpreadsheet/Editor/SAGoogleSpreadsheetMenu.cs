//----------------------------------------------
// SA: Google Spreadsheet Loader
// Copyright © 2014 SuperAshley Entertainment
//----------------------------------------------

using UnityEditor;

namespace SuperAshley.GoogleSpreadSheet
{
    static public class SAGoogleSpreadsheetMenu
    {

        [MenuItem("Tools/Open Spreadsheet Loader", false, 0)]
        static public void OpenSpreadsheetLoader()
        {
            EditorWindow.GetWindow<SAGoogleSpreadsheetLoader>(false, "Spreadsheet Loader", true).Show();
        }
    }
}