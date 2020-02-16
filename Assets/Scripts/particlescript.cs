using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particlescript : MonoBehaviour
{

    private float timebtwspawns;
    private float starttimebtwspawns;


    public GameObject particle;

    private Playerscript player;


    // Start is called before the first frame update
    void Start()
    {
        starttimebtwspawns = 0.03f;
        player = GetComponent<Playerscript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player.movement != 0)
        {
            if (timebtwspawns <= 0)
            {
                GameObject instance = Instantiate(particle, transform.position, Quaternion.identity);
                Destroy(instance, 0.315f);
                timebtwspawns = starttimebtwspawns;
            }
            else
            {
                timebtwspawns -= Time.deltaTime;
            }
        }
    }
}
