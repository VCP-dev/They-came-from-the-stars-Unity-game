using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class satellitescript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, Time.deltaTime * 20f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            if (healthscript.currenthealth >= 75f)
            {
                healthscript.currenthealth += (100 - healthscript.currenthealth);
            }
            else
            {
                healthscript.currenthealth += 25f;
            }
            scorescript.score += 20;
            Destroy(gameObject, 0f);
        }
    }
}
