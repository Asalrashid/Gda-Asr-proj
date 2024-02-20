using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class StartPuse : MonoBehaviour
{
    bool isPause = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && isPause)
        {
            Time.timeScale = 1.0f;
            isPause = false;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && !isPause)
        {
            Time.timeScale = 0.0f;
            isPause = true;
        }



    }

    public void ToStart()
    {
     Time.timeScale = 1.0f;
    }
    public void ToPause()
    {
        Time.timeScale = 0.0f;
    }
}
