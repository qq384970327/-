using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Playercontroller : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    public float jumpforce;
    private Animator anim;
    public LayerMask ground;
    private Collider2D coll;
    public int Cherry;
    public Transform groundCheck;

    public bool isGround, isJump;
    bool jumpPressed;
    int jumpCount;
    public Text CherryNum;
    public bool squatPressed;


    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        coll = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        Movement();
        SwithAnim();
        isGround = Physics2D.OverlapCircle(groundCheck.position, 0.2f, ground);
        Tiaoyue();
    }
    void Update()
    {
        judge();
    }
    //判断
    void judge()
    {
        //判断是否按下跳跃
        if (Input.GetButtonDown("Jump") && jumpCount > 0)
        {
            jumpPressed = true;
        }
        if (Input.GetKey("s"))
        {
            squatPressed = true;
        }
        else 
        {
            squatPressed = false;
        }
    }
    //行走与朝向
    void Movement() 
    {
        float horizontalmove = Input.GetAxisRaw("Horizontal");
            rb.velocity = new Vector2(horizontalmove*speed,rb.velocity.y);
 
        if(horizontalmove != 0)
        {
           transform.localScale = new Vector3(horizontalmove, 1,1);
        }
    }
    //跳跃
    void Tiaoyue()
    {
        if (isGround)
        {
            jumpCount = 2;
            isJump = false;
        }
        if (jumpPressed && isGround && !squatPressed)
        {
            isJump = true;
            rb.velocity = new Vector2(rb.velocity.x, jumpforce * Time.deltaTime);
            jumpCount--;
            jumpPressed = false;
        }
        else if (jumpPressed && jumpCount > 0 && isJump)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpforce * Time.deltaTime);
            jumpCount--;
            jumpPressed = false;
        }
    }
    //改变动画效果
    void SwithAnim()
    {
        anim.SetFloat("running", Mathf.Abs(rb.velocity.x));

        if (isGround)
            {
                anim.SetBool("falling", false);
            }
            else if (!isGround && rb.velocity.y > 0)
            {
                anim.SetBool("jumping", true);
            }
            else if (rb.velocity.y < 0)
            {
                anim.SetBool("jumping", false);
                anim.SetBool("falling", true);
            }
        //蹲下
        if (squatPressed)
        {
            anim.SetBool("squatting", true);
        }
        else if (!squatPressed)
        {
            anim.SetBool("squatting", false);
        }

    }

   //拾取收集品
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Collection") 
        {
            Destroy(collision.gameObject);
            Cherry++;
            CherryNum.text = Cherry.ToString();
        }
    }
}