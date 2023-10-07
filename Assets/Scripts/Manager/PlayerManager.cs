using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �e�v���C���[���Ǘ�����N���X
/// </summary>
public class PlayerManager : ManagerBase
{
    // �v���C���[���X�g
    private List<GameObject> m_players = null;

    // Prefab�p�X
    private string PLAYER_PREFAB_PATH = "Prefabs/Player 1";

    public override void OnStart()
    {
        _Generate();
    }
    public override void OnUpdate()
    {
    }

    /// <summary>
    /// �e�v���C���[���쐬
    /// </summary>
    private void _Generate()
    {
        // �v���C���[���X�g
        m_players = new List<GameObject>();

        // �v���n�u����ǂݍ��񂾃v���C���[�I�u�W�F�N�g
        GameObject playerPrefab = (GameObject)Resources.Load(PLAYER_PREFAB_PATH);

        // TEST: �L����������(��)
        int maxChrCount = 3;
        
        // �L�����B�𐶐�
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
