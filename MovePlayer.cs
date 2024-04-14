using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
    @author Kevin Guerra
    Source: Parsa Farvadian, Flappy Bird dude
    BTW: Infinite Jumping is a feature
    version 1.4
*/

public class MovePlayer : MonoBehaviour
{
    public bool Jump = false;
    public float moveSpeed = 50f;
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Start");
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector3.down, 15f);
        //Debug.Log("Collider: ", GetComponent<Collider>());
        if(hit.collider != null)
        {
            Jump = false;
        }
        if(Input.GetKeyDown(KeyCode.Space)||(Input.GetKeyDown(KeyCode.UpArrow)) && Jump == false)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(0,15f,0);
            Jump = true;
        }
    }
    /*
        *To kill the main character eventually
    */
        void OnCollisionEnter(Collision collision)
    {
        // Destroy this sprite's GameObject
        Debug.Log("collision detected");
        Destroy(gameObject);
    }
}
