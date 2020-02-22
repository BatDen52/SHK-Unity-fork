using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public void MoveToTarget(Vector3 targetPosition, float speed)
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
    }

    public void MoveUp(float currentSpeed)
    {
        transform.Translate(0, currentSpeed * Time.deltaTime, 0);
    }

    public void MoveDown(float currentSpeed)
    {
        transform.Translate(0, -currentSpeed * Time.deltaTime, 0);
    }

    public void MoveRight(float currentSpeed)
    {
        transform.Translate(currentSpeed * Time.deltaTime, 0, 0);
    }

    public void MoveLeft(float currentSpeed)
    {
        transform.Translate(-currentSpeed * Time.deltaTime, 0, 0);
    }
}
