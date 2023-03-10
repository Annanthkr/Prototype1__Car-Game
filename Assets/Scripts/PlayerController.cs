using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float horzInput;
    float vertInput;
    [SerializeField] 
    float playerSpeed , turnSpeed;
    Vector3 moveDir;

    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        horzInput = Input.GetAxis("Horizontal");
        vertInput = Input.GetAxis("Vertical");
        moveDir = Vector3.forward * vertInput * Time.deltaTime * playerSpeed;
        transform.Rotate(Vector3.up , turnSpeed * horzInput * Time.deltaTime);
        transform.Translate(moveDir);
    }
}
