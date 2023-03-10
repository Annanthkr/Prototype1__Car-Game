using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float horzInput;
    float vertInput;
    [SerializeField] 
    float playerSpeed;
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
        moveDir = new Vector3(horzInput,0,vertInput) * Time.deltaTime * playerSpeed;
        transform.Translate(moveDir);
    }
}
