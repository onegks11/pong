using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PaddleMove : MonoBehaviour
{
    public InputActionAsset inputActions;
    public string actionName = "Move";
    public float moveSpeed = 5f;

    private InputActionMap paddleMap;
    private InputAction moveAction;

    public float minY = -4f;
    public float maxY = 4f;

    private void Awake()
    {
        paddleMap = inputActions.FindActionMap("Paddle");
        moveAction = paddleMap.FindAction(actionName);
    }

    private void OnEnable()
    {
        if(paddleMap != null)
        {
            paddleMap.Enable();
        }
    }

    private void OnDisable()
    {
        if (paddleMap != null)
        {
            paddleMap.Disable();
        }
    }

    private void Update()
    {
        float moveInput = moveAction.ReadValue<Vector2>().y;

        float nextY = transform.position.y + moveInput * moveSpeed * Time.deltaTime;

        nextY = Mathf.Clamp(nextY, minY, maxY);

        transform.position = new Vector3(
            transform.position.x,
            nextY,
            transform.position.z
            );
    }
}
