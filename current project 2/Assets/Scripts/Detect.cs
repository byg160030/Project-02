using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detect : MonoBehaviour
{
    bool detected;
    GameObject target;
    public Transform enemy;

    public GameObject bullet;
    public Transform shootPoint;

    public float shootSpeed = 10f;
    public float timeToShoot = 1.3f;
    float originalTime;

    public float health = 50f;

    public AudioSource damagedSound;
    public AudioSource shootSound;

    // Start is called before the first frame update
    void Start()
    {
        originalTime = timeToShoot;
    }

    // Update is called once per frame
    void Update()
    {
        if (detected)
        {
            enemy.LookAt(target.transform);
        }
    }

    private void FixedUpdate()
    {
        if(detected)
        {
            timeToShoot -= Time.deltaTime;

            if(timeToShoot < 0)
            {
                ShootPlayer();
                timeToShoot = originalTime;
                damagedSound.Play();
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            detected = true;
            target = other.gameObject;
        }
    }

    private void ShootPlayer()
    {
        GameObject currentBullet = Instantiate(bullet, shootPoint.position, shootPoint.rotation);
        Rigidbody rig = currentBullet.GetComponent<Rigidbody>();
        Target target = transform.GetComponent<Target>();

        rig.AddForce(transform.forward * shootSpeed, ForceMode.VelocityChange);

        Destroy(currentBullet, 5f);
    }

    public void TakeDamage(float amount)
    {
        damagedSound.Play();

        health -= amount;
        if (health <= 0f)
        {

            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }

}
