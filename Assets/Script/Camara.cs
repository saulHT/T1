using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    public Transform playerTransfor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var x =playerTransfor.position.x;
        var y =playerTransfor.position.y;

        transform.position = new Vector3(x,y,transform.position.z);
    }
}
