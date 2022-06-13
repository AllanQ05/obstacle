using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // [SerializeField]float xValue =0;
    // [SerializeField]float yValue = 0;
    // [SerializeField]float zValue = 0;
    [SerializeField]float moveSpeed = 10f; //better at 10
    // Start is called before the first frame update
    void Start()
    {
        PrintInstruction();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PrintInstruction()
    {
        Debug.Log("welcome to the game");
        Debug.Log("move you player with WASD or arrow keys");
        Debug.Log("don't hit the walls!");
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal")*Time.deltaTime*moveSpeed;
        float zValue = Input.GetAxis("Vertical")*Time.deltaTime*moveSpeed;
        transform.Translate(xValue,0,zValue);
    }
}
