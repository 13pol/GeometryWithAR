using UnityEngine;
using UnityEngine.UI;

public class ScreenOrientation : MonoBehaviour
{
    public RectTransform scanWarning;
    public RectTransform menuBtn;
    public RectTransform newScanBtn;
    public RectTransform examplesBtn;
    public RectTransform nextBtn;

    UnityEngine.ScreenOrientation orientation = UnityEngine.ScreenOrientation.Portrait;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
              
    }

    // Update is called once per frame
    void Update()
    {
        if (Screen.orientation != orientation)
        {
            if (Screen.orientation == UnityEngine.ScreenOrientation.Portrait)
            {
                portraitMode();
                orientation = Screen.orientation;
            }
            else
            {
                landscapeMode();
                orientation = Screen.orientation;
            }
        }
       
    }

    void portraitMode()
    {
        scanWarning.anchoredPosition3D = new Vector3(0, -170, 0);
        scanWarning.localScale = new Vector3(0.5f, 0.5f, 0.5f);

        menuBtn.anchoredPosition3D = new Vector3(-250, 125, 0);
        menuBtn.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        menuBtn.sizeDelta = new Vector2(900, 200);

        newScanBtn.anchoredPosition3D = new Vector3(250, 125, 0);
        newScanBtn.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        newScanBtn.sizeDelta = new Vector2(900, 200);

        examplesBtn.anchoredPosition3D = new Vector3(0, 250, 0);
        examplesBtn.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        examplesBtn.sizeDelta = new Vector2(1900, 200);

        nextBtn.anchoredPosition3D = new Vector3(0, 250, 0);
        nextBtn.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        nextBtn.sizeDelta = new Vector2(1900, 200);
    }

    void landscapeMode()
    {
        scanWarning.anchoredPosition3D = new Vector3(0, -55, 0);
        scanWarning.localScale = new Vector3(0.25f, 0.25f, 0.25f);

        menuBtn.anchoredPosition3D = new Vector3(-390, 55, 0);
        menuBtn.localScale = new Vector3(0.25f, 0.25f, 0.25f);
        menuBtn.sizeDelta = new Vector2(1000, 200);

        newScanBtn.anchoredPosition3D = new Vector3(390, 55, 0);
        newScanBtn.localScale = new Vector3(0.25f, 0.25f, 0.25f);
        newScanBtn.sizeDelta = new Vector2(1000, 200);

        examplesBtn.anchoredPosition3D = new Vector3(0, 55, 0);
        examplesBtn.localScale = new Vector3(0.25f, 0.25f, 0.25f);
        examplesBtn.sizeDelta = new Vector2(2030, 200);

        nextBtn.anchoredPosition3D = new Vector3(0, 55, 0);
        nextBtn.localScale = new Vector3(0.25f, 0.25f, 0.25f);
        nextBtn.sizeDelta = new Vector2(2030, 200);

    }
}
