using UnityEngine;

public class FridgeRestrictions : MonoBehaviour
{
    public Camera cam;
    public GameObject leftDoor;
    public GameObject rigthDoor;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (cam.transform.position.z <= -2.087)
        {
            leftDoor.SetActive(true);
            rigthDoor.SetActive(true);
        }
        else
        {
            leftDoor.SetActive(false);
            rigthDoor.SetActive(false);
        }
    }
}
