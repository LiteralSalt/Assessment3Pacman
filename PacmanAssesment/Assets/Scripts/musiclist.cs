using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musiclist : MonoBehaviour
{
    public AudioSource Track1;

    public AudioSource Track2;

   

    public int TrackSelector;

    public int trackhistory;






    // Start is called before the first frame update
    void Start()
    {
        TrackSelector = 0;


        if(TrackSelector == 0 )
        {

            Track1.Play();
            trackhistory = 1;
        }        
        else if ( TrackSelector == 1 )
        {
            Track2.Play();
            trackhistory = 2;

        }


    }

    // Update is called once per frame
    void Update()
    {
        if (Track1.isPlaying == false && Track2.isPlaying == false )
        {

            TrackSelector = Random.Range (0, 2);

            if (TrackSelector == 0 && trackhistory != 1) 
            {
                Track1.Play();
                trackhistory = 1;

            }
            else if (TrackSelector == 1 && trackhistory != 2)
            {
                Track2.Play();
                trackhistory = 2;

            }
        }
    }
}
