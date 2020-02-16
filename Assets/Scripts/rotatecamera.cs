using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatecamera : MonoBehaviour
{

    Vector3 orignalpos;
    Vector3 nextpos;

    Transform UFO;

    Vector3 finalpos;
        

    // Start is called before the first frame update
    void Start()
    {
        orignalpos = transform.position;
        nextpos = new Vector3(0.11f,0,orignalpos.z);        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward,Time.deltaTime * 4.69f);        
    }

    public void camerashake()
    {
        gameObject.transform.position = nextpos;        
        Invoke("Moveback", 0.1f);           
    }

    private void Moveback()
    {
        gameObject.transform.position = orignalpos;
    }

}
