using UnityEngine;

public class Bullet : MonoBehaviour
{
    public AudioSource shootAudio;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            //shootAudio.Play();
            Destroy(collision.gameObject);
        }
    }
}
