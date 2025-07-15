using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// UIÃæ°åµÄ¸¸Àà
/// </summary>
public abstract class UIPlanel
{
    public UIType UIType { get; private set; }

    public virtual void OnEnter() { }

    public virtual void OnPause() { }

    public virtual void OnResume() { }

    public virtual void OnExit() { }
}
