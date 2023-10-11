using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezeProjectileLogic_Pauline : ProjectileLogicBaseClass
{
    public float m_freezeTime;
    public override void ApplyEffect(EnemyBaseClass _target)
    {
        _target.FreezeForSeconds(m_freezeTime);
        Destroy(gameObject);
    }
}
