using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement; 

public class Mouvement : MonoBehaviour

    //////////////////////// VARIABLE /////////////////
{
    public bool CanMouv = true;

    [SerializeField] private float Direction;

    // Deplacement du player

    [Header("statistic")]
    [SerializeField] bool Player_Run;
    [SerializeField] float m_Thrust = 12f;
    [SerializeField] float GravityScale= 1.5f;
    [SerializeField] float fallGravityScale = 5f;
    [SerializeField] float speed =100f;



    // mechanics cinematics
   public bool Freez = false;

    [Header("assignation")]
    [SerializeField] Animator Player_animator;
    [SerializeField] SpriteRenderer spriteRenderer;
    [SerializeField] Rigidbody2D m_Rigidbody;

    // mechanics isgrounded
    [Header("ground debug")]
    [SerializeField] bool isGrounded ;
    [SerializeField] bool isJumping; 
    [SerializeField] float groundCheckRadius;
    [SerializeField] Transform groundCheck;
    [SerializeField] LayerMask CollisionsLayer;


    // mechanics hide 
    [Header("hide debug")]
    [SerializeField]  bool canHide = false;
    [SerializeField]  bool hiding ;

    // mechanics checkppoint 
   // [SerializeField] GameMaster GM;

    [SerializeField] Collider2D PlayerCollider;
    public bool sheHide = false;

    public LayerMask Player_Hitbox_LayerMask;



    // input manette

    private Input_manette input_manette;

    public Vector2 Input_Direction;

    ////////////////////////////////// FIN VARIABLE ///////////////////////////////

    private void Awake()
    {
        input_manette = new Input_manette();
        hiding = false;
    }



    private void OnEnable()
    {
        input_manette.Mouvement.Run.Enable();
        input_manette.Mouvement.Jump.Enable();
        input_manette.Mouvement.Hide.Enable();
       // input_manette.Mouvement.Phone.Enable();

        input_manette.Mouvement.Jump.performed += Jump;
        input_manette.Mouvement.Hide.performed += Hide;
       // input_manette.Mouvement.Phone.performed += Phone;
    }

   

   // private void Phone(InputAction.CallbackContext context)
    //{
       
    //}

    private void OnDisable()
    {
        input_manette.Mouvement.Run.Disable();
        input_manette.Mouvement.Jump.Disable();
        input_manette.Mouvement.Hide.Disable();
        input_manette.Mouvement.Phone.Disable();
    }

    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>(); 
        Player_animator = GetComponent<Animator>();


    }



    void Update()
    {


        if (CanMouv)
        {
            mouvement();
        }


        if (!hiding)
        {
            Enemy_Awakening_Box();
        }

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

    private void Enemy_Awakening_Box()
    {

        Collider2D[] Enemey_found = Physics2D.OverlapBoxAll(this.transform.position, new Vector2(15, 5), Player_Hitbox_LayerMask);

        foreach (var Object in Enemey_found)
        {

            if (Object.tag == "Prefab_ia")
            {

                if (Object.GetComponent<Script_PatrolingAi_Prefab>().Get_Alive())
                {

                    Object.GetComponent<Script_PatrolingAi_Prefab>().Assign_Player(this.transform);
                }
            }
        }
    }


    ////////////////////// MOUVEMENT PLAYER ////////////////////////

    void mouvement()
    {

        CanMouv = true;

        Input_Direction = input_manette.Mouvement.Run.ReadValue<Vector2>();
        Vector2 Player_Velocity = m_Rigidbody.velocity;

        Player_Velocity.x = ((speed * Time.deltaTime)* Input_Direction.x);
        m_Rigidbody.velocity = Player_Velocity;

        if (m_Rigidbody.velocity.x > 0.01)
        {

            spriteRenderer.flipX = false;
            Player_animator.SetBool("BoolRun", true);

        }
        else if (m_Rigidbody.velocity.x < -0.01)
        {

            spriteRenderer.flipX = true;
            Player_animator.SetBool("BoolRun", true);
        }

        else
        {
            Player_animator.SetBool("BoolRun", false);
        }
        
        // Direction = Input.GetAxisRaw("Horizontal") * Time.deltaTime;  

        //if (Input.GetKey(KeyCode.RightArrow) && CanMouv)
        //{
        //    transform.Translate(Vector3.right * speed * Time.deltaTime);
        //    Player_animator.SetBool("BoolRun", true);
        //    spriteRenderer.flipX = false;

        //}

        //else if (Input.GetKey(KeyCode.LeftArrow) && CanMouv)
        //{
        //    transform.Translate(Vector3.left * speed * Time.deltaTime);
        //  Player_animator.SetBool("BoolRun", true);
        //  spriteRenderer.flipX = true;
        //}

        //else
        //{
        //    Player_animator.SetBool("BoolRun", false);
        //    //spriteRenderer.flipX = false;
        //}

    }

    // JUMP MECHANICS

    void Jump(InputAction.CallbackContext context)
    {
        if ( isGrounded && hiding == false && CanMouv)
        {
            Debug.Log("jump");
            Player_animator.SetTrigger("TriggerJump");
            Player_animator.SetBool("BoolRun", false);
            m_Rigidbody.velocity = Vector2.zero;
            m_Rigidbody.AddForce(Vector2.up * m_Thrust,ForceMode2D.Impulse);
            canHide = false;

            if (m_Rigidbody.velocity.y > 0)
            {
                Debug.Log("1");
                m_Rigidbody.gravityScale = GravityScale;
            }
            else
            {
               Debug.Log("2");
               m_Rigidbody.gravityScale = fallGravityScale;
            }

        }

      
        /*else
        {
            Player_animator.SetBool("BoolJump", false);
        }*/

    }

    // HIDING MECHANICS

    void Hide(InputAction.CallbackContext context)


    {
        if (canHide && hiding == false)
        {

            Physics2D.IgnoreLayerCollision(9, 10, true);
            spriteRenderer.sortingOrder = 0;
            hiding = true;
            CanMouv = false;
            sheHide = true;

            transform.gameObject.tag = "Hide";
            //PlayerCollider.enabled = false;
        }

         else if (hiding == true)
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
    
