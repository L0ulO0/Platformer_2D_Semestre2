using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Enemi : MonoBehaviour

{

    //erializeField] float Direction;
   //SerializeField] float moveSpeed = 5f; 
    [SerializeField] Rigidbody2D m_Rigidbody;
    [SerializeField] GameObject VerificationDuHide;
    [SerializeField] SpriteRenderer spriteRenderer;


    void Start()
    {

        VerificationDuHide.SetActive(false);
        m_Rigidbody = GetComponent<Rigidbody2D>();
       //irection = -1f; 

    }

    
    void Update()
    {
        

    }

    private void FixedUpdate()
    {
       //_Rigidbody.velocity = new Vector2(Direction * moveSpeed, m_Rigidbody.velocity.y);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name.Equals("Player"))
        {
            VerificationDuHide.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.name.Equals("Player"))
        {
            VerificationDuHide.SetActive(false);
        }
    }
}
