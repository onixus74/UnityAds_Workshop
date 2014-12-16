using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class Health : MonoBehaviour {
    public Scrollbar healthBar;
    public float health = 100;
    public void TakeDamage(float value)
    {
        health -= value;
        healthBar.size = health / 100f;
    }


    void Update()
    {
        if ((Advertisement.isReady()))
        {   
            if(health<=0)
            Advertisement.Show();
            if(Advertisement.isShowing)
            health = 100;
            Debug.Log("Showing ads");
        }
    }

}
