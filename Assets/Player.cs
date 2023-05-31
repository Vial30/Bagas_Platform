using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public Rigidbody2D Rb;
    public int jump = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update(){
        if(Input.GetKeyDown("space") && jump < 2){
           Debug.Log("lompat");
           Rb.AddForce(new Vector2(0, 10000f));
           jump++;
        }

    }
    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");

        Vector2 movement = new Vector2(horizontalMovement * speed, 0.5f);

        Rb.AddForce(movement);



    }

    void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "Platform"){
            // Debug.Log("Diatas Tanah");
            jump = 0;
        }
    }

//     void OnCollisionExit2D(Collision2D collision) {
//          if (collision.gameObject.tag == "Platform"){
//             Debug.Log("Lompat !");
//             jump = 0;
//         }       
//     }
}
