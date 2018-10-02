using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {
    Rigidbody2D rb;
    public float speed;
    public float rozamiento;
    public float impulsoSalto;

    public void Saltar()

    public void Awake(){
        rb = GetComponent<Rigidbody2D>();
    }

    public void FixedUpdate(){
        float movHorz = Input.GetAxis("Horizontal");
        float salto = Input.GetAxis("Up");
        Vector2 movement = new Vector2(movHorz, 0);
	Vector2 vImpulso = new Vector2(0, salto);
        rb.AddForce(movement * speed);
        rb.AddForce(-rozamiento * rb.GetPointVelocity(this.transform.position));
	rb.AddForce(vImpulso * impulsoSalto);
    }

}
