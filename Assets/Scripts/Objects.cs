using UnityEngine;

public class Objects : MonoBehaviour
{
    public GameObject changeBtn;
    public GameObject DirLight;
    GameObject figure;
    Animator animator;
    bool isTransform = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject[] figures = GameObject.FindGameObjectsWithTag("Figure");
        for (int i = 0; i < figures.Length; i++)
        {
            if (figures[i].activeSelf)
            {
                figure = figures[i];
            }
        }
        
        GameObject[] realObjects = GameObject.FindGameObjectsWithTag("Examples");
        for (int i = 0; i < realObjects.Length; i++)
        {
            if (realObjects[i].name == figure.name + "Objects")
            {
                animator = realObjects[i].GetComponent<Animator>();
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!isTransform && figure.transform.localPosition.y < -2.25)
        {
            animator.enabled = true;
            isTransform = true;
            figure.SetActive(false);
            changeBtn.SetActive(true);
            DirLight.SetActive(true);
            
        }
    }
}
