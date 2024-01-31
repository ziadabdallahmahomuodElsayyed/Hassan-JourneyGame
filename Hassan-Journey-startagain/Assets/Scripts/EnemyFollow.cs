using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour

{
    public GameObject player;
    public float speed;
    private float distance;
    public bool flip;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector2.Distance(transform.position, player.transform.position);
        if (distance <= 4)
        {

            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);

            Vector3 scale = transform.localScale;

            if (player.transform.position.x < transform.position.x)
            {
                scale.x = Mathf.Abs(scale.x) * -1 * (flip ? -1 : 1);




            }
            else
            {
                scale.x = Mathf.Abs(scale.x) * (flip ? -1 : 1);


            }
            transform.localScale = scale;
        }




       


    }

    

}
