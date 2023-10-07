using System.Collections;
using UnityEngine;

/// <summary>
/// ゲーム全体の制御を行うクラス
/// </summary>
public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    // 各マネージャー
    private StageManager m_stageManager = null;

    private PlayerManager m_playerManager = null;

    // スクリプト作成が終わったかどうか
    private bool m_isDoneCreateScript = false;

    public static GameManager GetInstance()
    {
        return instance;
    }

    // 初期化
    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
    }

    private void Update()
    {
    }

    private void FixedUpdate()
    {
    }

    private void LateUpdate()
    {
    }

    /// <summary>
    /// ステージにキャラクターを配置する
    /// </summary>
    private void _PutPlayersInStage()
    {
    }

    /// <summary>
    /// プレイヤーが作成したスクリプトを実行する
    /// </summary>
    private IEnumerator _CreateScript()
    {
        return null;
    }

    /// <summary>
    /// キャラクターを生成する
    /// </summary>
    /// <param name="chrChr"></param>
    /// <param name="position"></param>
    public GameObject InstantiateCharactor(GameObject chrChr, Vector3 position)
    {
        return Instantiate(chrChr, position, Quaternion.identity);
    }
}