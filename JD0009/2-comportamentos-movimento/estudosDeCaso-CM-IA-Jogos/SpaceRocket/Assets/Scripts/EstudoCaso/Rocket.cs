using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    public float propulsionForce = 20f;
    public float rotationSpeed = -90f;
    [Header("Collision Settings")]
    public float maxCollisionSpeed = 3f;
    public float maxCollisionDot = .8f;

    Rigidbody2D body;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            body.AddRelativeForce(Vector2.up * propulsionForce, ForceMode2D.Force);
        }

        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        body.MoveRotation(body.rotation + rotation * Time.fixedDeltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Velocidade: " + collision.relativeVelocity.magnitude);
       

        float dot = Vector2.Dot(Vector2.up, transform.up);
       
        if (dot < maxCollisionDot) 
            Debug.LogFormat("Ângulo não é bom para aterrisagem: {0}", dot);
        
    }
}
