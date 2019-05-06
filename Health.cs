using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class Health : MonoBehaviour {

    public const int maxHealth = 100;

    [SyncVar(hook = "OnChangeHealth")] // 네트워크를 넘나들면서 수치를 자동으로 동기화 클라이언트도 동기화
    public int currentHealth;

    public Slider healthSlider;

    public void TakeDamage(int amount) // 데미지를 입을 수 있는 함수 총알이 Health 스크립트를 가지고있는 물체에게 데미지를 줌
    {
        
        if(!isServer)
        {
            return;
        }

        currentHealth -= amount;

        if(currentHealth <= 0)
        {
            currentHealth = 0;
            Debug.Log("Dead!");
        }
    }

    //currentHealth에 hook을 걸어서 동기화에 의해서 변경이 될때마다 ui를 변경하도록
    
    void OnChangeHealth(int health)
    {
        healthSlider.value = health;
    } 
}
