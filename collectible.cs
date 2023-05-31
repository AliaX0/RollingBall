using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectible : MonoBehaviour
{
    public GameObject player;
    public PlayerController playerScore;
    void Start(){
        if (transform.gameObject.activeSelf==false){
            transform.gameObject.SetActive(true);
        }
        else{
        }

        player = GameObject.Find("Player");
        playerScore = player.GetComponent<PlayerController>();
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            //deactivate the other object
            transform.gameObject.SetActive (false);
            playerScore.increaseScore();
        }
    }
}
