using UnityEngine;

public class TestAudioManager : MonoBehaviour
{
    public AudioClip musicClip;
    public AudioClip sfxClip;

    private void Start()
    {
       AudioMnager.instance.PlayMusic(musicClip);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            AudioMnager.instance.PlaySfx(sfxClip);
        }
    }
}
