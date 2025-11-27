using UnityEngine;

public class WeaponSway : MonoBehaviour
{
    private Quaternion startingRotation;
    public float swayAmount = 8f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startingRotation = transform.localRotation;
    }

    // Update is called once per frame
    void Update()
    {
        Sway();
    }

    public void Sway()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        Quaternion xAngle = Quaternion.AngleAxis(-mouseX * -1.25f, Vector3.up);
        Quaternion yAngle = Quaternion.AngleAxis(-mouseY * -1.25f, Vector3.left);
        Quaternion targetRotation = startingRotation * xAngle * yAngle;
        transform.localRotation = Quaternion.Lerp(transform.localRotation, targetRotation, Time.deltaTime * swayAmount);
    }
}
