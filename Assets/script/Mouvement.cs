using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class mouvement : MonoBehaviour

    //////////////////////// VARIABLE /////////////////
{
    public bool CanMouv = true;

    [SerializeField] private float Direction; 

    // Deplacement du player

    [SerializeField] bool Player_Run;
    [SerializeField] private float m_Thrust = 400f;
    [SerializeField] float speed = 4.5f;


    // mechanics cinematics
   public bool Freez = false;
   
    [SerializeField] Animator Player_animator;
    [SerializeField] SpriteRenderer spriteRenderer;
    [SerializeField] Rigidbody2D m_Rigidbody;

    // mechanics isgrounded
    [SerializeField] bool isGrounded ;
    [SerializeField] bool isJumping; 
    [SerializeField] float groundCheckRadius;
    [SerializeField] Transform groundCheck;
    [SerializeField] LayerMask CollisionsLayer;


    // mechanics hide 
    [SerializeField]  bool canHide = false;
    [SerializeField]  bool hiding = false;

    // mechanics checkppoint 
    [SerializeField] GameMaster GM;

    [SerializeField] Collider2D PlayerCollider;
    public bool sheHide = false; 


////////////////////////////////// FIN VARIABLE ///////////////////////////////

    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>(); 
        Player_animator = GetComponent<Animator>();
    
    }



    void Update()
    {


        Mouvement();
        Jump();
        Hide();
       
       

    }

    //ISGROUNDED

    private void FixedUpdate()
    {

        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, CollisionsLayer);

       /* if (isGrounded)
        {
            Player_animator.SetBool("BoolJump", false);
            isGrounded = true;
        }

        else
        {
            Player_animator.SetBool("BoolJump", true);
            isGrounded = false; 
        }

        if(! hiding)
        {
            m_Rigidbody.velocity = new Vector2( Direction, m_Rigidbody.velocity.y); 
        }
        else
        {
            m_Rigidbody.velocity = Vector2.zero; 
        }*/
    }



    ////////////////////// MOUVEMENT PLAYER ////////////////////////

    void Mouvement()
    {


       // Direction = Input.GetAxisRaw("Horizontal") * Time.deltaTime;  

        if (Input.GetKey(KeyCode.RightArrow) && CanMouv)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
            Player_animator.SetBool("BoolRun", true);
            spriteRenderer.flipX = false;

        }

        else if (Input.GetKey(KeyCode.LeftArrow) && CanMouv)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
          Player_animator.SetBool("BoolRun", true);
          spriteRenderer.flipX = true;
        }

        else
        {
            Player_animator.SetBool("BoolRun", false);
            //spriteRenderer.flipX = false;
        }

    }

    // JUMP MECHANICS

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && isGrounded && hiding == false && CanMouv)
        {
            Debug.Log("jump");
            Player_animator.SetTrigger("TriggerJump");
            Player_animator.SetBool("BoolRun", false);
            m_Rigidbody.AddForce(Vector2.up * m_Thrust);
            canHide = false;

        }

      
        /*else
        {
            Player_animator.SetBool("BoolJump", false);
        }*/

    }

    // HIDING MECHANICS

    void Hide()
    {
        if ( canHide && Input.GetKey(KeyCode.H))
        {
           
            Physics2D.IgnoreLayerCollision(9, 10, true);
            spriteRenderer.sortingOrder = 0;
            hiding = true; 
            CanMouv = false;
            sheHide = true; 

            transform.gameObject.tag = "Hide";
            //PlayerCollider.enabled = false;
        }

        if(Input.GetKeyUp(KeyCode.H))
        {
            Physics2D.IgnoreLayerCollision(9, 10, false);
            spriteRenderer.sortingOrder = 2;
            hiding = false;
            CanMouv = true;
            sheHide = false; 
            //PlayerCollider.enabled = true;
            transform.gameObject.tag = "Player";
        }


    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name.Equals("HidePlace"))
        {
            canHide = true; 
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.name.Equals("HidePlace"))
        {
            canHide = false; 
        }
    }


    // MECHANICS CHECKPOINT 
    /*

    void Checkpoint ( Transform checkpointTransform)
    {
        GM = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
        transform.position = GM.lastCheckPointPos;
    }*/


    /* private void OnTriggerEnter2D (Collider2D other) 
    {
       if ( other.gameObject.CompareTag("Enemy")&& hiding == false)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

       else if (other.gameObject.CompareTag("Thorn"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }*/

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(groundCheck.position, groundCheckRadius);
    }

}
    
