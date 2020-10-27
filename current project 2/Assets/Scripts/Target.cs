using UnityEngine;

public class Target : MonoBehaviour
{
    public float health = 50f;

    public AudioSource damagedSound;

    public void TakeDamage (float amount)
    {
        damagedSound.Play();

        health -= amount;
        if (health <= 0f)
        {
            Die();
        }
    }

    void Die ()
    {
        Destroy(gameObject);
    }


}
