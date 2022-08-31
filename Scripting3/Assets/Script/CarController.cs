using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    
    [SerializeField] private float carSpeed = 10f;
    private float zDirection = 0f;

    [SerializeField] private float rotationSpeed = 20f;
    float xRotation = 0f;

    private void Update()
    {
        CheckMove();
        CheckTurn();
    }

    private void CheckMove()
    {
        zDirection = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * carSpeed * Time.deltaTime * zDirection);
    }

    private void CheckTurn()
    {
        xRotation = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime * xRotation);
    }
}
