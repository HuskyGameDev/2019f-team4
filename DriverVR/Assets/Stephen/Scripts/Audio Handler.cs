using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioHandler : MonoBehaviour
{
    protected System.Random rand;
    [SerializeField]
    private float frequency;
    private AudioClip[] useSounds;
    private AudioClip[] ambientSounds;
    private AudioClip[] collisionSounds;
    private AudioSource source;

    private int ambientLength;
    private int useLength;
    private int collisionLength;

    // Start is called before the first frame update
    protected void Start()
    {
        ambientLength = ambientSounds.Length;
        useLength = useSounds.Length;
        collisionLength = collisionSounds.Length;
        source.playOnAwake = false;
        source.loop = false;
    }

    // Update is called once per frame
    protected void Update()
    {
        if (rand.NextDouble() < frequency)
        {
            source.PlayOneShot(ambientSounds[rand.Next(ambientLength)]);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        source.PlayOneShot(collisionSounds[rand.Next(collisionLength)]);
    }

    private void Use()
    {
        source.PlayOneShot(useSounds[rand.Next(useLength)]);
    }
}
