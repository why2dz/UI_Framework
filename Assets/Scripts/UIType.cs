using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIType
{
    public string UI_Name { get; private set; }
    public string UI_Path { get; private set; }

    public UIType(string Path)
    {
        UI_Name = Path.Substring(Path.LastIndexOf('/')+1);
        UI_Path = Path;
    }
}
