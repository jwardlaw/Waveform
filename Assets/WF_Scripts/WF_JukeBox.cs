using UnityEngine;
using System.Collections;

public class WF_JukeBox : MonoBehaviour 
{
    public AudioSource _AudioSource;
    public static float vol;

    public AudioClip Song1;
    public AudioClip Song2;
    public AudioClip Song3;

    public void ChangeSong( int SongNum)
    {
        if( SongNum == 1)
        {
            if(_AudioSource.clip != Song1)
            {
                _AudioSource.clip = Song1;
                _AudioSource.Play();
            }
        }
        if (SongNum == 2)
        {
            if (_AudioSource.clip != Song2)
            {
                _AudioSource.clip = Song2;
                _AudioSource.Play();
            }
        }
        if (SongNum == 3)
        {
            if (_AudioSource.clip != Song3)
            {
                _AudioSource.clip = Song3;
                _AudioSource.Play();
            }
        }
    }

    public void ChangeVolume( float newvolume)
    {
        _AudioSource.volume = newvolume;
        vol = newvolume;
    }
}
