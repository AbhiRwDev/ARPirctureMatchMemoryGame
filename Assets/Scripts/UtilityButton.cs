using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class UtilityButton : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        if(GameObject.FindGameObjectsWithTag("Phones").Length>0)
        {
           Destroy( GameObject.FindGameObjectsWithTag("Phones")[1]);
        }
    }
    public void SceneLoad(string Scenename)
    {
        SceneManager.LoadScene(Scenename);
    }
    public void PhoneSizeChange(float val)
    {
        val = gameObject.GetComponent<Slider>().value;
        val += 0.5f;
        Vector3 size = new Vector3(val, val, val);
        GameObject.FindGameObjectWithTag("Phones").transform.localScale = size;
    }
}
