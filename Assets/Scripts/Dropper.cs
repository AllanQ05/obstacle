using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer renDerer;
    Rigidbody rigidBody;
    [SerializeField]float timeToWait = 2f;
    // Start is called before the first frame update
    void Start()
    {
        renDerer = GetComponent<MeshRenderer>();
        rigidBody = GetComponent<Rigidbody>();

        renDerer.enabled=false;
        rigidBody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(Time.time);
        if(Time.time>timeToWait){
            renDerer.enabled=true;
            rigidBody.useGravity=true;
            // Debug.Log("3 secconds has elapsed");
        }
    }
}
