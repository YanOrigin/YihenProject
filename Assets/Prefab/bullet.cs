using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{


    [SerializeField] private float speed = 5f;//子弹的速度
    public Rigidbody2D rig;
    // public GameObject prefab;
 
    void Start () {
        // Instantiate(prefab);
        rig = GetComponent<Rigidbody2D>();//获取子弹刚体组件
        rig.velocity = transform.right * speed;//移动
        Destroy(gameObject, 2);//2秒后销毁子弹，不然子弹会无限多
    }	
 
    private void OnTriggerEnter2D(Collider2D collision)//触碰到别的碰撞器的时候
    {
        Destroy(gameObject);//只要碰撞到碰撞体就摧毁子弹本身
    }
}
