using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D rb;

    #region 参数
        [Header("移动")]
            public float moveSpeed = 3.5f;//人物移动速度
            public float targetSpeed=3.5f;// 最大速度
    #endregion

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        var moveX = Input.GetAxis("Horizontal");
        var moveY = Input.GetAxis("Vertical");

        rb.velocity = new Vector2(moveX * moveSpeed, rb.velocity.y);
        rb.velocity = new Vector2(rb.velocity.x, moveY * moveSpeed);
        //rb.velocity = new Vector2(Mathf.Sign(rb.velocity.x) * targetSpeed, rb.velocity.y);
        //rb.velocity = new Vector2(rb.velocity.x, Mathf.Sign(rb.velocity.y) * targetSpeed);
    }
}
