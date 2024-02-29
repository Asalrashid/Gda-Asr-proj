using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    [SerializeField] private SpeedandDelay m_speedandDelay;
    //[SerializeField] private float m_speedandDelay;
    [SerializeField] private float m_lifetime;
    private Rigidbody m_rigidbody;
    private NewBehaviourScript m_player;
    private Quaternion m_quat;
    [SerializeField] private bool m_followPlayer;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, m_lifetime);
        m_rigidbody = GetComponent<Rigidbody>();
       // m_rigidbody.velocity = Vector3.back * m_speedandDelay.Speed;
        
    }
    public void Init(float speed, bool lookAtPlayer, bool followPlayer)
    {
        m_speedandDelay.Speed = speed;

        if (lookAtPlayer)
        {
            m_player = FindObjectOfType<NewBehaviourScript>();
            m_quat = Quaternion.LookRotation((m_player.transform.position - transform.position).normalized);
            m_followPlayer = followPlayer;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        if (m_followPlayer)
        {
            m_quat = Quaternion.LookRotation((m_player.transform.position - transform.position).normalized);
        }

        //transform.position += Vector3.forward * m_speedandDelay * Time.deltaTime;
        m_rigidbody.velocity = m_quat * (Vector3.forward * m_speedandDelay.Speed);
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player Damged");
        }
   
    }
}

