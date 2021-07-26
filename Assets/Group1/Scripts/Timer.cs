using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{
    private float _interval;
    private UnityAction _timeEnded;

    public bool IsFinished => _interval <= 0;

    public Timer(float interval, UnityAction timeEndedHandler)
    {
        _interval = interval;
        _timeEnded += timeEndedHandler;
    }

    public void Tick(float deltaTime)
    {
        _interval -= deltaTime;

        if (IsFinished)
        {
            _timeEnded?.Invoke();
            _timeEnded = null;
        }
    }

    private void OnDisable()
    {
        _timeEnded = null;
    }
}
