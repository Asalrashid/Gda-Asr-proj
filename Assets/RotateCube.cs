using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCube : MonoBehaviour
{
    private Vector3 m_StartPos;
    [SerializeField] private float m_speed;
    // Start is called before the first frame update
    void Start()
    {
        m_StartPos = transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = m_StartPos + new Vector3(Mathf.Sin(Time.time), Mathf.Cos(Time.time), 0.0f) * m_speed ;
    }
}
