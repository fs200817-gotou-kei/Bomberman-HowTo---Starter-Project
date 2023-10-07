using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectCharactorComponent : MonoBehaviour
{
    // Prefab�p�X
    private string CHR_MODEL_PREFAB_PATH = "Resources/Prefabs/Player 1";

    // Start is called before the first frame update
    void Start()
    {
        GameManager gameManager = GameManager.GetInstance();
        if(gameManager != null)
        {
            GameObject chrObj = (GameObject)Resources.Load(CHR_MODEL_PREFAB_PATH);
            
            GameObject afterChr =  gameManager.InstantiateCharactor(chrObj,new Vector3(0,2,1));

            if(afterChr == null)
            {
                Debug.Log("chr��null!");
            }
            Debug.Log("chr��������!!!");

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
