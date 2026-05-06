using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public bool canSpawn = false;
    public bool Spawn = true;
    public float Timer;

    public GameObject Drifter;
    
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

                Instantiate(Drifter, new Vector3(-12, -4, 0), Quaternion.identity);
            }
        }
    }
}
