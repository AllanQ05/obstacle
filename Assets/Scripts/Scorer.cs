using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = -1; // it count the gound that mean if your set 0 it will be 1
    // // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag!="Hit"){
        this.hits ++;
        Debug.Log("you've bumped into a thing this many time: "+this.hits);
        }
    }
}
