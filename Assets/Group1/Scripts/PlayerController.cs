using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Timer _timer;

    private float _currentSpeed;
    private List<Timer> _timerList;

    private void Start()
    {
        _timerList = new List<Timer>();
        _currentSpeed = _speed;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
            transform.Translate(0, _currentSpeed * UnityEngine.Time.deltaTime, 0);

        if (Input.GetKey(KeyCode.S))
            transform.Translate(0, -_currentSpeed * UnityEngine.Time.deltaTime, 0);

        if (Input.GetKey(KeyCode.A))
            transform.Translate(-_currentSpeed * UnityEngine.Time.deltaTime, 0, 0);

        if (Input.GetKey(KeyCode.D))
            transform.Translate(_currentSpeed * UnityEngine.Time.deltaTime, 0, 0);
    }

    public void SendMessage(GameObject other)
    {
        if (other.GetComponent<EnemyMove>() != null)
            Destroy(other);

        if (other.GetComponent<SpeedUp>() != null)
        {
            SpeedUpStarting();
            Destroy(other);
        }
    }

    public void SpeedUpEnding(Timer timer)
    {
        timer.EndOfTime -= SpeedUpEnding;
     
        _timerList.Remove(timer);
        
        _currentSpeed -= _speed;
    }

    public void SpeedUpStarting()
    {
        _currentSpeed += _speed;
     
        Timer timer = Instantiate(_timer, transform.position, Quaternion.identity, transform).gameObject.GetComponent<Timer>();
        timer.EndOfTime += SpeedUpEnding;
     
        _timerList.Add(timer);
    }
}
