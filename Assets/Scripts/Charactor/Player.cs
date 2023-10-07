using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// キャラを操作するプレイヤー
/// </summary>
public class Player:MonoBehaviour
{
    // 自身のキャラクター
    private ChrCtrl chrCtrl;

    // キャラを動かすためのスクリプトパネル
    List<PanelBase> panels = null;

    /// <summary>
    /// キャラを動かすスクリプトを作成する
    /// </summary>
    public Object CreateScript()
    {
        return null;
    }
}