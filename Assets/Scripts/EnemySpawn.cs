using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public bool canSpawn = true;
    public bool Spawn = true;
    public float currentTime;
    public float Timer ;
    
    public SongLoader data;

    // Update is called once per frame
    void Update()
    {
        if (data.started == true)
        {
            Debug.Log("Forsic");
            canSpawn = true;
        }

        if (canSpawn == true)
        {
            Debug.Log("Fire");
        }

        //Time Clock Counter - 3 Secounds at first

        currentTime += Time.deltaTime;

        if (currentTime > Timer)
        {

        }

    }
}
