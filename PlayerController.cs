using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class PlayerController : MonoBehaviour
{
    public float speed; //moving speed
    private Rigidbody rb; //holds rigidbody component of the object
    public Vector3 jump;
    public float jumpForce = 2.8f;
    private bool isGrounded = false;
    public int score;
    public TMPro.TMP_Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f,2.0f , 0.0f);
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        // float moveVertical = Input.GetAxis("Vertical");
        float moveVertical = 1;
        //float moveHeight = Input.GetAxis("Height");

        //create a Vector3 movement variable to store the X,Y,Z movement values
        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

        //adds movement values to the rigidbody
        rb.AddForce(movement * speed);
    }

    //void OnTriggerEnter(Collider other)
    //{
        //if the other object entering our trigger zone
        //has a tag called 'Pick Up'
        //if(other.gameObject.CompareTag("Pick Up"))
        //{
            //deactivate the other object
        //    other.gameObject.SetActive (false);
        //}
    //}
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag=="ground")
        {
            isGrounded = true;
        }
    }
    void Update ()
    {
        if (isGrounded) {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.AddForce(jump*jumpForce, ForceMode.Impulse);
                isGrounded = false;
            }
        }
        
    }



    public void increaseScore(){
        score++;
        //Debug.Log(score);
    }

    
    void LateUpdate(){
        scoreText.text = ""+score+"";
    }
}
