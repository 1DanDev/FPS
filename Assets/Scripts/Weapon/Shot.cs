using UnityEngine;

public class Shot : MonoBehaviour
{


    public Transform spawnPoint;
    public GameObject bullet;
    public float shotForce = 1500f;
    public float shotRate = 0.5f;
    private float shotRateTime = 0f;
    public AudioSource shootAudio;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && Time.time >= shotRateTime && GameManager.Instance.gunAmmo > 0)
        {
            GameManager.Instance.gunAmmo--;
            GameObject newBullet;
            newBullet = Instantiate(bullet, spawnPoint.position, spawnPoint.rotation);
            newBullet.GetComponent<Rigidbody>().AddForce(spawnPoint.forward * shotForce);
            shotRateTime = Time.time + shotRate;
            shootAudio.Play();
            Destroy(newBullet, 5f);
        }
    }
}
