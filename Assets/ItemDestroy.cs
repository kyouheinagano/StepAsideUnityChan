using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDestroy : MonoBehaviour
{
    private Camera cam;
    private bool judgepos;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
       
    }

    // Update is called once per frame
    void Update()
    {
        judgepos = cam.transform.position.z > this.transform.position.z;

        if (judgepos == true)
        {
            Destroy(this.gameObject);
        }
    }
}
