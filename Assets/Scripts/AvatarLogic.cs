using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarLogic : MonoBehaviour
{
    public float speedMovement = 5.0f;
    public float speedRotation = 200.0f;
    private Animator anim;
    public float x, y;
    public float vida;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        vida = 10.0f;
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        transform.Rotate(0, x * Time.deltaTime * speedRotation, 0);
        transform.Translate(0,0, y * Time.deltaTime * speedMovement);

        anim.SetFloat("VelX", x);
        anim.SetFloat("VelY", y);
    
    }

    void OnTriggerEnter(Collider colisionador){

        if (colisionador.tag=="Item")
        {
            vida += 5.0f;
            Destroy (colisionador.gameObject);
        }else if(colisionador.tag=="Itemvidamenos"){
            vida -= 5.0f;
            Destroy (colisionador.gameObject);
        }

    }
}
