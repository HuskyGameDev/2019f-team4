using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioAmbient : AudioHandler
{
    [SerializeField]
    private AudioSource contSource;
    private AudioClip[] contSounds;

    private int contLength;
    private int curSound;

    // Start is called before the first frame update
    new void Start()
    {
        base.Start();
        contLength = contSounds.Length;
        curSound = rand.Next(contLength);
        contSource.clip = contSounds[curSound];
        Invoke("NextContinuousSound", contSounds[curSound].length+1f);
        contSource.playOnAwake = true;
        contSource.loop = false;
    }

    private void NextContinuousSound()
    {
        int nextSound = curSound;
        while (nextSound == curSound)
        {
            nextSound = rand.Next(contLength);
        }
        curSound = nextSound;
        contSource.PlayOneShot(contSounds[curSound]);
        Invoke("NextContinuousSound", contSounds[curSound].length+1f);
    }
}
