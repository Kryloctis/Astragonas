using System.ComponentModel;
using UnityEngine;
using UnityEngine.InputSystem;

public class SpaceshipController : MonoBehaviour
{
    //Movement Settings
    [Header("Movement Settings")]
    public float moveSpeed = 10f;

    //Tilt Settings
    [Header("Tilt Settings")]
    public Transform modelTransform;
    public float maxTiltAngle = 50f;
    public float tiltSpeed = 30f; 

    private float currentTilt = 0f;

    public void Update()
    {
        float horizontalInput = 0f;
        float verticalInput = 0f;

        if(Keyboard.current is not null)
        {
            //For horizontal input
            if(Keyboard.current.aKey.isPressed || Keyboard.current.leftArrowKey.isPressed)
                horizontalInput = -1f;
            else if(Keyboard.current.dKey.isPressed || Keyboard.current.rightArrowKey.isPressed)
                horizontalInput = 1f;

            //For vertical Input
            if(Keyboard.current.wKey.isPressed || Keyboard.current.upArrowKey.isPressed)
                verticalInput = 1f;
            else if(Keyboard.current.sKey.isPressed || Keyboard.current.downArrowKey.isPressed)
                verticalInput = -1f;
        }

        Vector3 moveDirection = new Vector3(horizontalInput, 0f, verticalInput);
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime, Space.World);
        
        float targetTilt = horizontalInput * maxTiltAngle;
        currentTilt = Mathf.LerpAngle(currentTilt, targetTilt, Time.deltaTime * tiltSpeed);

        if(modelTransform !=null)
        {
            modelTransform.localRotation = Quaternion.Euler(-currentTilt, 0f, 0f);
        }
    }
}
