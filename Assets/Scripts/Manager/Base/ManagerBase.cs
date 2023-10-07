using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// マネージャーの基底クラス
/// </summary>
public abstract class ManagerBase: MonoBehaviour
{
    public abstract void OnStart();

    public abstract void OnUpdate();
}
