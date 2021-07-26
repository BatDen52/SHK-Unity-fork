using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyDeathTrigger : PlayerDistanceChecker
{
    public event UnityAction<EnemyDeathTrigger> Died;

    protected override void CollisionHandle()
    {
        Died?.Invoke(this);
    }
}
