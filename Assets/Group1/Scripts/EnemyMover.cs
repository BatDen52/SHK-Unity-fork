using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] private float _radius;
    [SerializeField] private float _speed;

    private Vector3 _targetPosition;

    void Start()
    {
        GenerateTarget();
    }

    private void Update()
    {
        Move();

        if (transform.position == _targetPosition)
            GenerateTarget();
    }

    public void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, _targetPosition, _speed * Time.deltaTime);
    }

    private void GenerateTarget()
    {
        _targetPosition = Random.insideUnitCircle * _radius;
    }
}
