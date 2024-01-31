using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyKill : MonoBehaviour
{

    public GameObject player;
    public GameObject playerzom;
    public GameObject Enemy;
    public GameObject spawn;

    public int playerhealthtimes = 3;
    public float playerhealth = 100f;
    public float enemyhealth = 20f;
    public float touchplyr;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        touchplyr = Vector2.Distance(transform.position, player.transform.position);
        if (touchplyr <= 0.5f)
        {
            for (int x = 0; x <= playerhealth; playerhealth--)
            {
                Debug.Log("player: ahhhh");

                if (playerhealth == 0f)
                {
                    playerhealthtimes--;



                }

            }

        }
       

    }
    private void FixedUpdate()
    {

        if (playerhealthtimes == -1)
        {
            playerzom.transform.position = player.transform.position;
            player.transform.position = spawn.transform.position;
            playerhealthtimes = 3;
        }

        if (playerhealth ==-1f)
        {
            spawnplyr();
                
                playerhealth = 100f;
        }
    }
    void spawnplyr()
    {
       
            player.transform.position = spawn.transform.position;


        



    }
  
}
