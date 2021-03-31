using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour
{

    
    [SerializeField] AudioClip addScoreSound;
    [SerializeField] [Range(0, 1)] float addScoreSoundVolume;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        FindObjectOfType<Score>().AddScore();
        AudioSource.PlayClipAtPoint(addScoreSound, Camera.main.transform.position, addScoreSoundVolume);
    }
}
