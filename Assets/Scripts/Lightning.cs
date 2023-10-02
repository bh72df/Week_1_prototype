using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightning : MonoBehaviour
{
    public float moveSpeed = 0.5f; 
    public float moveDistance = 50.0f;

    private Vector3 initialPosition;
    private float direction = 1.0f; 

    private void Start()
    {
        initialPosition = transform.position;
    }

    private void Update()
    {
       
        Vector3 newPosition = transform.position + Vector3.right * direction * moveSpeed * Time.deltaTime;

       
        if (Mathf.Abs(newPosition.x - initialPosition.x) >= moveDistance)
        {
           
            direction *= -1.0f;
        }

       
        transform.position = newPosition;
    }
}