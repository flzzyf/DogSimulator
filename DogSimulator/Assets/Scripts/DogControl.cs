using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogControl : MonoBehaviour 
{
    public float speed = 1;
    public Animator animator;
	
	void Update () 
	{
        if (GameManager.Instance().isPaused)
        {
            if(animator.GetBool("walking"))
                animator.SetBool("walking", false);

            return;
        }

        //移动
        float inputH = Input.GetAxisRaw("Horizontal");
        float inputV = Input.GetAxisRaw("Vertical");

        //移动动画
        if(inputH != 0 || inputV != 0)
        {
            Vector2 movement = new Vector2(inputH, inputV).normalized * speed * Time.deltaTime;
            transform.Translate(movement, Space.World);

            animator.SetBool("walking", true);
        }
        else
        {
            animator.SetBool("walking", false);
        }

        //朝向
        if (inputH != 0)
        {
            Vector3 scale = transform.localScale;
            scale.x = inputH < 0 ? 1 : -1;
            transform.localScale = scale;
        }
    }
}
