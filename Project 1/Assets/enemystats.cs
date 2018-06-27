using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemystats : MonoBehaviour {
    public int StartingHealth;
    int CurrentHealth;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        CurrentHealth = StartingHealth;
	}
    public void UpdateHealth(int amount)
    {
        CurrentHealth = CurrentHealth + amount;
        if (CurrentHealth <= 0)
        {
            Death();
        }
    }
    void Death()
    {
        gameObject.SetActive(false);
    }
}
