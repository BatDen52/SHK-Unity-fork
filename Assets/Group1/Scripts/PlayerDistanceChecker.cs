using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public abstract class PlayerDistanceChecker : MonoBehaviour
{
    [SerializeField] protected PlayerMover _player;

    private void Update()
    {
        if (Vector3.Distance(_player.transform.position, transform.position) < 0.2f)
        {
            CollisionHandle();
            Destroy(gameObject);
        }
    }

    protected abstract void CollisionHandle();
}
