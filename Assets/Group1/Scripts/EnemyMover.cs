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
        Move(_targetPosition);

        if (Vector3.Distance(transform.position, _targetPosition) == 0)
            GenerateTarget();
    }

    public void Move(Vector3 target)
    {
        transform.position = Vector3.MoveTowards(transform.position, target, _speed * Time.deltaTime);
    }

    private void GenerateTarget()
    {
        _targetPosition = Random.insideUnitCircle * _radius;
    }
}
