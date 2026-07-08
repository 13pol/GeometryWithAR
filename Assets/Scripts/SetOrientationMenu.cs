using UnityEngine;

public class SetOrientationMenu : MonoBehaviour
{

    public Canvas portrait;
    public Canvas landscape;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Screen.orientation = UnityEngine.ScreenOrientation.AutoRotation;
    }

    // Update is called once per frame
    void Update()
    {
        if (Screen.orientation == UnityEngine.ScreenOrientation.Portrait)
        {
            portrait.enabled = true;
            landscape.enabled = false;
        }
        else
        {
            landscape.enabled = true;
            portrait.enabled = false;
        }
    }
}
