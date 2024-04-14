using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
    @author Kevin Guerra
    Source: Parsa Farvadian, Flappy Bird dude
*/

public class Player : MonoBehaviour
{
    public bool Jump = false;
    public float moveSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        }
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector3.down, 1f);
        Debug.Log("Collider: ", GetComponent<Collider>());
        if(hit.collider != null)
        {
            Jump = false;
        }
        if(Input.GetKeyDown(KeyCode.Space) && Jump == false)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(0,10f,0);
            Jump = true;
        }
    }
    /*
        *To kill the mc
    */
        void OnCollisionEnter(Collision collision)
    {
        // Destroy this sprite's GameObject
        Debug.Log("collision detected");
        Destroy(gameObject);
    }
}
