using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouvement : MonoBehaviour
{
    bool CanMouv = true;

    [SerializeField] int speed = 5;
    //[SerializeField] Animator Player_animator;
    bool Player_Run;
    private float m_Thrust = 300f;
    private bool jumped = true;
    [SerializeField] SpriteRenderer spriteRenderer;
    [SerializeField] Rigidbody2D m_Rigidbody;
    [SerializeField] bool isGrounded;
    public bool Freez = false;

    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody2D>();
        //Player_animator = GetComponent<Animator>();
        Mouvement();
        Jump();
    }

    // Update is called once per frame
    void Update()
    {


        Mouvement();
        Jump();


    }

    void Mouvement()
    {


        if (Input.GetKey(KeyCode.RightArrow) && CanMouv)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
            //Player_animator.SetBool("BoolRun", true);
            spriteRenderer.flipX = true;

        }

        else if (Input.GetKey(KeyCode.LeftArrow) && CanMouv)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
            //Player_animator.SetBool("BoolRun", true);
          spriteRenderer.flipX = false;
        }

        else
        {
           //Player_animator.SetBool("BoolRun", false);
            spriteRenderer.flipX = false;
        }

    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && jumped == true)
        {
            jumped = false;
            //Player_animator.SetBool("BoolJump", true);
            m_Rigidbody.AddForce(Vector2.up * m_Thrust);

        }
        else if (Input.GetKeyUp(KeyCode.UpArrow) && jumped == false)
        {
            jumped = true;
            //Player_animator.SetBool("BoolJump", false);
        }
    }
}
