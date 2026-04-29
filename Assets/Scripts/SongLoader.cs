using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SongLoader : MonoBehaviour
{
    public string beatmapFilename;
    private BeatWrapper beatWrapper;
    public List<Beat> beats;
    public AudioSource songAudio;

    private bool started;

    public Vector3 ArrowSpawnLeft, ArrowSpawnDown, ArrowSpawnUp, ArrowSpawnRight;
    public GameObject ArrowLeftPrefab;
    public GameObject ArrowDownPrefab;
    public GameObject ArrowUpPrefab;
    public GameObject ArrowRightPrefab;


    void Start()
    {
        TextAsset jsonFile = Resources.Load<TextAsset>(beatmapFilename);
        string json = jsonFile.text;
        beatWrapper = JsonUtility.FromJson<BeatWrapper>(json);
        beats = beatWrapper.beats;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            songAudio.Play();
            started = true;

            Debug.Log("Started playing the song!");
        }

        if (started)
        {
            // get the current timestamp in the song
            float currentTime = songAudio.time;

            // look at the next beat in the list
            Beat nextBeat = beats[0];

            // display the beat as soon as the time stamp passes
            if (currentTime > nextBeat.time - 1.25)
            {
                // spawn the beat prefab in the correct location
                // Instantiate function
                if (nextBeat.input == "Left")
                {
                    Instantiate(ArrowLeftPrefab, ArrowSpawnLeft, ArrowLeftPrefab.transform.rotation);
                }
                if (nextBeat.input == "Down")
                {
                    Instantiate(ArrowDownPrefab, ArrowSpawnDown, ArrowDownPrefab.transform.rotation);
                }
                if (nextBeat.input == "Up")
                {
                    Instantiate(ArrowUpPrefab, ArrowSpawnUp, ArrowUpPrefab.transform.rotation);
                }
                if (nextBeat.input == "Right")
                {
                    Instantiate(ArrowRightPrefab, ArrowSpawnRight, ArrowRightPrefab.transform.rotation);
                }
                
                // remove the beat from the list
                beats.RemoveAt(0);
            }


        }
    }
}
