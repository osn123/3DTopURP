using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private Vector3 move;

    private InputScript inputScript;

    void Start()
    {
        inputScript = new InputScript();
        inputScript.Enable();
        inputScript.Player.Shot.performed += context => Debug.Log("Shot");
        //inputScript.Player.Fire.performed += context => Debug.Log("Fire");
    }
    void Update()
    {
        const float speed = 1f;
        Vector2 direction = inputScript.Player.Move.ReadValue<Vector2>();
        transform.Translate(direction * speed * Time.deltaTime);



        //const float speed = 1f;
        //transform.Translate(move * speed * Time.deltaTime);
    }


    public void OnMove(InputAction.CallbackContext context)
    {
        move = context.ReadValue<Vector2>();
    }

}
