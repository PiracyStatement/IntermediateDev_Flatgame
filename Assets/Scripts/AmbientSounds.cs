using UnityEngine;

public class AmbientSounds : MonoBehaviour
{
    private AudioSource[] sounds;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sounds = GetComponents<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (UnityEngine.Random.Range(1, 6000) == 5999)
        {
            sounds[UnityEngine.Random.Range(1, 4)].Play();
        }
    }
}
