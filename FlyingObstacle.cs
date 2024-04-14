using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingObstacle : MonoBehaviour
{
    public float moveSpeed = 4f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(moveSpeed * Time.deltaTime, 0, 0);
    }  
    void OnCollisionEnter(Collision collision)
    {
        // Destroy this sprite's GameObject
        Debug.Log("collision detected");
        Destroy(gameObject);
    }
}
