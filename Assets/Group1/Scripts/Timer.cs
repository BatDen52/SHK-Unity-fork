using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    private float _interval;

    public bool IsFinished => _interval <= 0;

    public Timer(float interval)
    {
        _interval = interval;
    }

    public void Tick(float deltaTime)
    {
        _interval -= deltaTime;
    }
}
