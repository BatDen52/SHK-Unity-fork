using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{
    [SerializeField] private float _interval;

    public event UnityAction<Timer> EndOfTime;

    void Update()
    {
        if (_interval > 0)
        {
            _interval -= Time.deltaTime;
        }
        else
        {
            EndOfTime?.Invoke(this);
            Destroy(this);
        }
    }
}
