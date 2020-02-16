using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laserscript : MonoBehaviour
{

    float speed;
    public GameObject laserexplosion;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 1f);
        speed = 3f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Instantiate(laserexplosion, transform.position, Quaternion.identity);
        Destroy(gameObject, 0f);
    }
}
