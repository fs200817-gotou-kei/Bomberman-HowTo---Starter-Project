using System.Collections;
using UnityEngine;

/// <summary>
/// �Q�[���S�̂̐�����s���N���X
/// </summary>
public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    // �e�}�l�[�W���[
    private StageManager m_stageManager = null;

    private PlayerManager m_playerManager = null;

    // �X�N���v�g�쐬���I��������ǂ���
    private bool m_isDoneCreateScript = false;

    public static GameManager GetInstance()
    {
        return instance;
    }

    // ������
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
    /// �X�e�[�W�ɃL�����N�^�[��z�u����
    /// </summary>
    private void _PutPlayersInStage()
    {
    }

    /// <summary>
    /// �v���C���[���쐬�����X�N���v�g�����s����
    /// </summary>
    private IEnumerator _CreateScript()
    {
        return null;
    }

    /// <summary>
    /// �L�����N�^�[�𐶐�����
    /// </summary>
    /// <param name="chrChr"></param>
    /// <param name="position"></param>
    public GameObject InstantiateCharactor(GameObject chrChr, Vector3 position)
    {
        return Instantiate(chrChr, position, Quaternion.identity);
    }
}