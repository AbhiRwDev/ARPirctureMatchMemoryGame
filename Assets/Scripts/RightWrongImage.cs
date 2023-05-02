using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RightWrongImage : MonoBehaviour
{
    public Sprite Match, NoMatch;
    public AudioSource ad;
    public AudioClip[] audios;
    // Start is called before the first frame update
    void Start()
    {
        if (gameObject.GetComponent<Image>().sprite == Match)
        {
            ad.clip = audios[0];
        }
        else
        {
            ad.clip = audios[1];
        }
        ad.Play();
        Destroy(gameObject,2.5f);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
