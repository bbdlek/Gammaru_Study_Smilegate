using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int count = 0;

    void Update()
    {
        //CheckFrameOut();

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            LButtonDown();
        }

        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            RButtonDown();
        }
    }

    public void LButtonDown()
    {
        if(count > -3)
        {
            count -= 1;
            transform.Translate(-3, 0, 0);
        }
    }
    
    public void RButtonDown()
    {
        if (count < 3)
        {
            count += 1;
            transform.Translate(3, 0, 0);
        }
    }

    /*private void CheckFrameOut()
    {
        if (transform.position.x > 10.0f)
            transform.position = new Vector2(10.0f, -3.6f);
        
        if (transform.position.x < -10.0f)
            transform.position = new Vector2(-10.0f, -3.6f);

    }*/

}
