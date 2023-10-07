using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public classÅ@MainSceneComponent: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SceneManager.LoadScene("TitleScene", LoadSceneMode.Additive);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
