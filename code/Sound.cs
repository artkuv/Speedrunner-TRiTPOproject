using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public static AudioClip jumpSound, explosionSound, coinSound, finishSound, gameoverSound, GameSound;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<AudioSource>().volume = MainMenu.SoundActive;
        jumpSound = Resources.Load<AudioClip>("Jump");
        explosionSound = Resources.Load<AudioClip>("explosion");
        coinSound = Resources.Load<AudioClip>("coin");
        gameoverSound = Resources.Load<AudioClip>("gameover");
        finishSound = Resources.Load<AudioClip>("Finish");
        GameSound =Resources.Load<AudioClip>("MusicGame");
        audioSrc = GetComponent<AudioSource>();
    }

    
    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "Jump":
                audioSrc.PlayOneShot(jumpSound);
                break;
            case "explosion":
                audioSrc.PlayOneShot(explosionSound);
                break;
            case "coin":
                audioSrc.PlayOneShot(coinSound);
                break;
            case "gameover":
                audioSrc.PlayOneShot(gameoverSound);
                break;
            case "Finish":
                audioSrc.PlayOneShot(finishSound);
                break;
            case "MusicGame":
                audioSrc.PlayOneShot(GameSound);
                
                break;
        }

        }
}
