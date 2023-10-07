using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSceneComponent : MonoBehaviour
{
    private bool isOpen = false;

    public void Button1_Click()
    {
        if (isOpen == false)
        {
            isOpen = true;
            SceneManager.UnloadSceneAsync("MenuScene");
            SceneManager.LoadScene("SelectCharactorScene", LoadSceneMode.Additive);
        }
    }
}