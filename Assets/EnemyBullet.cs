using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    [SerializeField] private float m_speed;
    [SerializeField] private float m_lifetime;
    private Rigidbody m_rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, m_lifetime);
        m_rigidbody = GetComponent<Rigidbody>();
        m_rigidbody.velocity = Vector3.back * m_speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player Damged");
        }
    }
}

