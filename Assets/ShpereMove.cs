using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class ShpereMove : MonoBehaviour
{
    [SerializeField] private float m_speed;
    [SerializeField] private float m_lifetime;
    private Rigidbody m_rigidbody;
    Vector3 playerTransform;
    // Start is called before the first frame update
    void Awake()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform.forward;
        Destroy(gameObject, m_lifetime);
        m_rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        m_rigidbody.velocity = playerTransform * m_speed;
        
    }


    void OnCollisionEnter(Collision collision)
    {
      /*  collision.contacts[0].otherCollider.tag */

        if (collision.gameObject.CompareTag("Enemy")) 
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            KillScore.Instance.ADD();
        }
    }

    public void Init(Vector3 diricetion) 
    {
    
        
    }
}

