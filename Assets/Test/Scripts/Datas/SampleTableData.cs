using UnityEngine;
using System.Collections.Generic;

[System.Serializable]
public class SampleTable {
	public string Nameee;
	public string SampleField;
}

public class SampleTableData : ScriptableObject {
	public List<SampleTable> sampleTables = new List<SampleTable>();
}

