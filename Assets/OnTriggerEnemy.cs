using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEditor.AssetImporters;

public class OnTriggerEnemy : MonoBehaviour
{
    [SerializeField] private GameObject m_enemyPrefab;
    [SerializeField] private Transform m_enemySpawn;
    [SerializeField] private List<EnemyMovement> m_enemies;

    private bool m_activated = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    

    private void Awake()
    {
        foreach (EnemyMovement enemy in m_enemies)
        {
            enemy.GetComponent<EnemyShooting>().ShootOnStart = false;
            enemy.GetComponent<Rigidbody>().isKinematic = true;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        
        if (!m_activated && other.gameObject.tag == "Player")
        {
            Debug.Log("IM SPAWNING");
            m_activated = true;
            var seq = DOTween.Sequence();
            foreach (EnemyMovement enemy in m_enemies)
            {
                enemy.gameObject.SetActive(true);

                var pos = enemy.transform.position;

                RaycastHit info;
                if (Physics.Raycast(pos, Vector3.down, out info))
                {
                    pos.y = info.point.y + 1;
                }

                seq.Append(enemy.transform.DOMove(pos, 3)
                    .OnComplete(
                        () => {
                            enemy.GetComponent<EnemyShooting>().StartShooting();
                        }
                     ));
            }
 
            StartCoroutine(Spawn(5));
        }
    }

    IEnumerator Spawn(int amount)
    {
        int enemySpawn = 0;
        while (enemySpawn < amount)
        {
            //Vector3 spawnPos = m_enemySpawn.position;
            yield return new WaitForSeconds(4f);
            //spawnPos.x += Random.Range(-100.0f, 100.0f);
            //spawnPos.z += Random.Range(-100.0f, 100.0f);

            var col = GetComponent<BoxCollider>();
            Vector3 size = col.size;
            size.x *= col.transform.localScale.x * 0.5f;
            size.y *= col.transform.localScale.y * 0.5f;
            size.z *= col.transform.localScale.z * 0.5f;

            var pos = col.transform.position;
            pos.x += Random.Range(-size.x, size.x);
            pos.z += Random.Range(-size.z, size.z);

            Instantiate(m_enemyPrefab, pos, Quaternion.identity);
            enemySpawn++;
        }
    }
}
