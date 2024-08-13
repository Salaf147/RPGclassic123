using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public int health;
    public Slider healthBar;
    public GameObject chuatextmau;

    // Start is called before the first frame update
    private void Start()
    {
        healthBar.maxValue = health;
        healthBar.value = health;
    }
    private void OnTriggerEnter2D(Collider2D doiTuong)
    {
        if (doiTuong.CompareTag("danplayer")) 
        {
            Destroy(doiTuong.gameObject);
            //  Destroy(doiTuong.gameObject);
            GetDmg(5);

        }
    }
    public void GetDmg(int dmg)
    {
        
        health -= dmg;
        healthBar.value = health;
        for (int i = 0; i < chuatextmau.transform.childCount; i++) 
        {
            if (chuatextmau.transform.GetChild(i).gameObject.activeSelf == false)
            {
                chuatextmau.transform.GetChild(i).gameObject.SetActive(true);
                chuatextmau.transform.GetChild(i).gameObject.GetComponent<Text>().text = "-" + dmg;
                break;
            }
        }
        if (health <= 0)
        {
            ListAllItems.Instance.checksoluongenemychet();
            //Play animation dead
            //StartCoroutine()....
            Destroy(gameObject);
        }
    }
}