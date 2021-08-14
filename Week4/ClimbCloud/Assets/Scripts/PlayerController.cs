using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigid2D;
    Animator anim;
    [SerializeField]
    GameObject endText;
    [SerializeField]
    float jumpForce = 680.0f;
    float walkForce = 30.0f;
    float maxWalkSpeed = 2.0f;
    float threshold = 0.2f;

    void Awake()
    {
        rigid2D = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        //Jump
        /*if (Input.GetKeyDown(KeyCode.Space) && this.rigid2D.velocity.y == 0)
        {
            rigid2D.AddForce(transform.up * this.jumpForce);
        }*/
        if (Input.GetMouseButtonDown(0) && this.rigid2D.velocity.y == 0)
        {
            rigid2D.AddForce(transform.up * this.jumpForce);
        }

        //move
        int key = 0;
        /*if (Input.GetKey(KeyCode.RightArrow)) key = 1;
        if (Input.GetKey(KeyCode.LeftArrow)) key = -1;*/
        if (Input.acceleration.x > this.threshold) key = 1;
        if (Input.acceleration.x < -this.threshold) key = -1;

        //speed
        float speedx = Mathf.Abs(this.rigid2D.velocity.x);

        if (speedx < this.maxWalkSpeed)
        {
            this.rigid2D.AddForce(transform.right * key * this.walkForce);
        }

        if (key != 0)
        {
            transform.localScale = new Vector3(key, 1, 1);
        }

        anim.speed = speedx / 2.0f;

        if(transform.position.y < -10)
        {
            Time.timeScale = 0;
            endText.SetActive(true);
            if (Input.anyKey)
            {
                Time.timeScale = 1;
                endText.SetActive(false);
                SceneManager.LoadScene("SampleScene");
            }
            
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Goal");
        SceneManager.LoadScene("GameClear");
    }
}
