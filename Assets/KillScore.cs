using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Unity.VisualScripting;
public class KillScore : MonoBehaviour
{
    public static KillScore Instance;
    private static int m_Score = 0;
    [SerializeField] private static TextMeshProUGUI m_KillCount;
    // Start is called before the first frame update
    public void ADD() 
    {
        m_Score++;
        m_KillCount.text = m_Score.ToString();
    }

    void Start()
    {
        Instance = this;
        m_KillCount = GameObject.Find("score").GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        
    }
}
