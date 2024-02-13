using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShpereMove : MonoBehaviour
{
    [SerializeField] private float m_speed;
    [SerializeField] private float m_lifetime;
    // Start is called before the first frame update
    void Awake()
    {
        Destroy(gameObject, m_lifetime);
    }

    // Update is called once per frame
    void Update()
    {
       transform.position += Vector3.forward * m_speed;
        
    }
}
