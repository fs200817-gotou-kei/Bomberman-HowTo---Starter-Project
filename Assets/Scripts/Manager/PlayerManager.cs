using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 各プレイヤーを管理するクラス
/// </summary>
public class PlayerManager : ManagerBase
{
    // プレイヤーリスト
    private List<GameObject> m_players = null;

    // Prefabパス
    private string PLAYER_PREFAB_PATH = "Prefabs/Player 1";

    public override void OnStart()
    {
        _Generate();
    }
    public override void OnUpdate()
    {
    }

    /// <summary>
    /// 各プレイヤーを作成
    /// </summary>
    private void _Generate()
    {
        // プレイヤーリスト
        m_players = new List<GameObject>();

        // プレハブから読み込んだプレイヤーオブジェクト
        GameObject playerPrefab = (GameObject)Resources.Load(PLAYER_PREFAB_PATH);

        // TEST: キャラ生成数(仮)
        int maxChrCount = 3;
        
        // キャラ達を生成
        for(int i = 0, iCount = maxChrCount; i < iCount; i++)
        {
            m_players.Add(Instantiate(playerPrefab));
        }
    }

    public IEnumerator CreateScript()
    {
        if(m_players == null)
        {
            for(int i = 0, iCount = m_players.Count; i < iCount; i++)
            {
                GameObject playerObj = m_players[i];
                Player player = playerObj.GetComponent<Player>();
                yield return player.CreateScript();
            }
        }
    }

    public void ExecuteScript()
    {
    }
}
