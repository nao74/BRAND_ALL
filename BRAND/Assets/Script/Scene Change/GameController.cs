using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//●ゲーム起動後の処理
//①エスケープを押したらゲーム終了

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // エスケープでゲーム終了
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
