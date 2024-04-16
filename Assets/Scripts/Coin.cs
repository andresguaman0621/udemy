using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    //public float animationTime = 0.1f;
    //public Vector3 enlargedScate = new Vector3(2f, 2f, 2f);
    //public Color capsuleColor;
    [SerializeField] AudioSource audioFX;

   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

 

    void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag ("Player"))
        {
            //transform.localScale = enlargedScate;
            //Debug.Log("Color de la cápsula: " + capsuleColor);
            audioFX.Play();
            Destroy(gameObject);
            //collision.GetComponent<Renderer>().material.color = capsuleColor;
        }

    }


}
