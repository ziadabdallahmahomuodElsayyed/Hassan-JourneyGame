using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrolling : MonoBehaviour
{
    public float movementSpeed;
    public Transform groundCheck;
    public Transform groundCheck2;
    public float groundCheckRadius = 0.5f;
    public LayerMask groundLayer;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(translation: Time.deltaTime * movementSpeed * transform.right);

        if (!Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer)|| !Physics2D.OverlapCircle(groundCheck2.position, groundCheckRadius, groundLayer))
        {

            Flip();
        }


    }


    private void Flip()
    {
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;

        movementSpeed *= -1;


    }
}
