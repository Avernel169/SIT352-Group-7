using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalSoundManager : MonoBehaviour
{
    public AudioClip[] AnimalAudios; //Set audio class & array
    public AudioSource Audio;
    public static AnimalSoundManager instance;

    void Awake()
    {
        instance = this;
    }

    public void PlayTiger() //Tiger sound
    {
        Audio.clip = AnimalAudios[0];
        Audio.Play();
    }

    public void PlayBear()  //Bear sound
    {
        Audio.clip = AnimalAudios[1];
        Audio.Play();
    }

    public void PlayFox()  //Fox sound
    {
        Audio.clip = AnimalAudios[2];
        Audio.Play();
    }

    public void PlayHippo()  //Hippo sound
    {
        Audio.clip = AnimalAudios[3];
        Audio.Play();
    }

    public void PlayRhino() //Rhino sound
    {
        Audio.clip = AnimalAudios[4];
        Audio.Play();
    }

    public void PlayCroc()  //Crocodile sound
    {
        Audio.clip = AnimalAudios[5];
        Audio.Play();

    }

    public void PlayElephant() //Elephant sound
    {
        Audio.clip = AnimalAudios[6]; 
        Audio.Play();
    }


}
