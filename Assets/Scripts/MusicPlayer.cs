using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    // create AudioSoure in order to set up Audio
    public AudioSource AudioSource;

    private float musicVolume = 1f; // to create music volume on slider

    // Start is called before the first frame update
    void Start()
    {
        AudioSource.Play();   
    }

    // Update is called once per frame
    void Update()
    {
        AudioSource.volume = musicVolume;
    }

    public void upgradeVolume (float volume)
    {
        musicVolume = volume;
    }
}
