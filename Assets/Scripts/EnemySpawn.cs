using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public bool canSpawn = true;
    public bool Spawn = true;
    public float currentTime;
    public float Timer;
    
    public SongLoader data;

    // Update is called once per frame
    void Update()
    {
        if (data.started == true)
        {
            canSpawn = true;
        }

        if (canSpawn == true)
        {
            Timer += Time.deltaTime;

            if (Timer > 3)
            {
                Timer = 0;
            }
            
            currentTime += Time.deltaTime;

            if (currentTime > Timer)
            {
                
            }
        }
    }
}
