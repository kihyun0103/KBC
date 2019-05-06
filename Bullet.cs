using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Bullet : MonoBehaviour {
    private void Start()
    {
        GetComponent<Rigidbody>().velocity = transform.forward * 6.0f;
        Destroy(gameObject, 2.0f);
    }
    private void OnCollisionEnter(Collision collision)
    {
        var hit = collision.gameObject;
        var health = hit.GetComponent<Health>();

        if(health != null)
        {
            health.TakeDamage(10);
        }

        Destroy(gameObject);
    }
}
