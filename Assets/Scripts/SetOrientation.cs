using UnityEngine;

public class SetOrientation : MonoBehaviour
{

    public MoveLandscapeCam landscape;
    public MovePortraitCam portrait;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Screen.orientation == UnityEngine.ScreenOrientation.Portrait)
        {
            portrait.enabled = true;
            landscape.enabled = false;
        }else
        {
            landscape.enabled = true;
            portrait.enabled = false;
        }
    }
}
