using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : MonoBehaviour
{
    [SerializeField] private PlayerController _player;

    void Update()
    {
        if (Vector3.Distance(_player.transform.position, this.transform.position) < 0.2f)
            _player.SendMessage(this.gameObject);
    }
}
