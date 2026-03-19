using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{

    public float movementSpeed = 5.0f;
    public float lookSpeed = 2f;
    private Vector3 moveDirection = Vector3.zero;

    public Rigidbody rb;
    public Vector3 moveInput;
    public Vector3 velocity;

    public InputActionAsset inputActions;
    public InputAction moveAction;

    private void Awake()
    {
        var playerActions = inputActions.FindActionMap("PlayerMap");
        moveAction = playerActions.FindAction("MoveX");
    }

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();

    }

    private void OnEnable()
    {
        moveAction.Enable();
    }

    private void OnDisable()
    {
        moveAction.Disable();
    }

    // Update is called once per frame
    void Update()
    {

        //CheckInput();

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * movementSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * movementSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.right * movementSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * movementSpeed * Time.deltaTime;
        }
    }

    void CheckInput()
    {

    }
}
