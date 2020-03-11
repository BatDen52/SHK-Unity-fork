using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyDeathTrigger : PlayerDistanceChecker
{
    public event UnityAction<EnemyDeathTrigger> Died;

    private void Update()
    {
        CheckDistance(Die);
    }

    private void Die()
    {
        Died?.Invoke(this);
    }
}
