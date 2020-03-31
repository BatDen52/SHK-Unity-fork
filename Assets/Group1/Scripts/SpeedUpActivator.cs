using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUpActivator : PlayerDistanceChecker
{
    [SerializeField] private Timers _timer;
    [SerializeField] private float _interval;

    protected override void CollisionHandle()
    {
        _timer.Add(_interval, _player.SpeedDown);
        _player.SpeedUp();
    }
}
