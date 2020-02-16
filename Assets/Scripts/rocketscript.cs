using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocketscript : MonoBehaviour
{

    public float speed;
    public GameObject explosion;


    // Start is called before the first frame update
    void Start()
    {
        Invoke("spawnexplosion", 0.69f);
        Destroy(gameObject, 0.7f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject, 0f);
            spawnexplosion();
            healthscript.currenthealth -= 25f;
            GameObject.FindGameObjectWithTag("MainCamera").GetComponent<rotatecamera>().camerashake();
        }
    }

    void spawnexplosion()
    {
        Instantiate(explosion, transform.position, Quaternion.identity);
    }
}
