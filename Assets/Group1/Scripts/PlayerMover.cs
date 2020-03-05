using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private float _currentSpeed;
    private Vector3 _direction;

    private void Start()
    {
        _currentSpeed = _speed;
    }

    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
            Move();
    }

    void Move()
    {
        _direction.x = Input.GetAxis("Horizontal");
        _direction.y = Input.GetAxis("Vertical");

        transform.Translate(_direction * Time.deltaTime * _currentSpeed);
    }

    public void SpeedUpStart()
    {
        _currentSpeed += _speed;
    }

    public void SpeedUpEnd()
    {
        _currentSpeed -= _speed;
    }
}
