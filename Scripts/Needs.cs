using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Needs : MonoBehaviour {

#region vars
    public Image Lifefill;
    public Image Hungerfill;
    public Image Thirstfill;
    public Image airfill;
    public float life = 100f;
    public float hunger = 100f;
    public float thirst = 100f;
    public float air = 100f;
    public float lrundown = 0.1f;
    public float hrundown = 0.1f;
    public float trundown = 0.1f;
    public float arundown = 0.1f;

    #endregion


    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {

        LifeUpdate();
        HungerUpdate();
        ThirstUpdate();
       
	}

    void LifeUpdate()
    {
        Lifefill.fillAmount = life / 100;
        if (hunger <=0 || thirst <= 0)
        {
            life -= lrundown;
        }
    }

    void HungerUpdate()
    {
        hunger -= hrundown * Time.deltaTime;
        Hungerfill.fillAmount = hunger / 100;
    }

    void ThirstUpdate()
    {
        thirst -= trundown * Time.deltaTime;
        Thirstfill.fillAmount = thirst / 100;
    }

}
