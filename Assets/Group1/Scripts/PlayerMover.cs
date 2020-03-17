using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private float _currentSpeed;

    private void Start()
    {
        _currentSpeed = _speed;
    }

    private void Update()
    {
        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
            Move();
    }

    private void Move()
    {
        Vector3 direction = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        transform.Translate(direction * Time.deltaTime * _currentSpeed);
    }

    public void SpeedUp()
    {
        _currentSpeed += _speed;
    }

    public void SpeedDown()
    {
        _currentSpeed -= _speed;
    }
}
