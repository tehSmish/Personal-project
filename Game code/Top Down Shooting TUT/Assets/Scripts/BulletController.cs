using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{

    [SerializeField] float speed = 10f;
    [SerializeField] Rigidbody2D theRB;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        theRB.velocity = transform.right * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Enemy")
        {
            Destroy(collision.gameObject);

            ScreenShakeController.instance.StartShake(1f, 1f);

            Destroy(gameObject);
        }

        if (collision.tag != "Bullet")
        {
            ScreenShakeController.instance.StartShake(.2f, .1f);

            Destroy(gameObject);
        }
    }
}
