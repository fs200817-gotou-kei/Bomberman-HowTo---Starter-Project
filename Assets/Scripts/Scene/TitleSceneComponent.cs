using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

/// <summary>
/// タイトルシーン上の処理クラス
/// </summary>
public class TitleSceneComponent : MonoBehaviour
{
    private bool isOpen = false;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && isOpen == false)
        {
            isOpen = true;
            SceneManager.UnloadSceneAsync("TitleScene");
            SceneManager.LoadScene("MenuScene", LoadSceneMode.Additive);
        }
    }
}
