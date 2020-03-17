using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUpActivator : PlayerDistanceChecker
{
    [SerializeField] private Timers _timer;

    protected override void CollisionHandle()
    {
        _timer.Add();
        _player.SpeedUp();
    }
}
