using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walkanimContro : MonoBehaviour
{
    static Animator anim;
    public float Speed = 2.0f;
   


    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        Transform ThisTransform = GetComponent<Transform>();

        ThisTransform.position += new Vector3(Speed * Time.deltaTime, 0f, 0f);
    }
}
