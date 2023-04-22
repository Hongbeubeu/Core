using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class SampleTable
{
    public string Nameee;
    public string SampleField;
}

public class SampleTableData : ScriptableObject
{
    public List<SampleTable> sampleTables = new();
}