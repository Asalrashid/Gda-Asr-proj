using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationHandler : MonoBehaviour
{
    private NewBehaviourScript m_Shooting;
    // Start is called before the first frame update
    void Awake()
    {
        m_Shooting = GetComponent<NewBehaviourScript>();
    }

    // Update is called once per frame
    void ShootBullet()
    {
        m_Shooting.ShootMethod();
    }
}
