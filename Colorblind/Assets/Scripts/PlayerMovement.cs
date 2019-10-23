using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private string horiInputName;
    [SerializeField] private string vertInputName;
    [SerializeField] private float movementSpeed;

    private CharacterController charController;

    // Start is called before the first frame update

    private void Awake()
    {
        charController = GetComponent<CharacterController>();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
    }


    private void PlayerMove()
    {
        float horizInput = Input.GetAxis(horiInputName) * movementSpeed;
        float vertInput = Input.GetAxis(vertInputName) * movementSpeed;

        Vector3 forwardMovement = transform.forward * vertInput;
        Vector3 rightMovement = transform.right * horizInput;

        charController.SimpleMove(forwardMovement + rightMovement);
    }

}
