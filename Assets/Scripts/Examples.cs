using UnityEngine;

public class Examples : MonoBehaviour
{
    Animator animator;
    public GameObject cubeObjects;
    public GameObject prismObjects;
    public GameObject pyramidObjects;
    public GameObject cylinderObjects;
    public GameObject sphereObjects;
    public GameObject coneObjects;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = FindActiveAnimator();
        animator.SetBool("Examples", true);
        activateObjects(animator.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    Animator FindActiveAnimator()
    {
        GameObject[] targets = GameObject.FindGameObjectsWithTag("Target");
        for (int i = 0; i < targets.Length; i++)
        {
            if (targets[i].activeSelf)
            {
                return targets[i].GetComponentInChildren<Animator>();
            }
        }
        return null;
    }

    void activateObjects(string name)
    {
        switch (name)
        {
            case "Cube":
                cubeObjects.SetActive(true);
                break;
            case "Prism":
                prismObjects.SetActive(true);
                break;
            case "Pyramid":
                pyramidObjects.SetActive(true);
                break;
            case "Cylinder":
                cylinderObjects.SetActive(true);
                break;
            case "Sphere":
                sphereObjects.SetActive(true);
                break;
            case "Cone":
                coneObjects.SetActive(true);
                break;
            default:
                break;
        }
    }

    public void ChangeObject()
    {
        Animator objectsAnimator;
        switch (animator.name)
        {
            case "Cube":
                objectsAnimator = cubeObjects.GetComponent<Animator>();
                objectsAnimator.SetBool("Change", true);
                break;
            case "Prism":
                objectsAnimator = prismObjects.GetComponent<Animator>();
                objectsAnimator.SetBool("Change", true);
                break;
            case "Pyramid":
                objectsAnimator = pyramidObjects.GetComponent<Animator>();
                objectsAnimator.SetBool("Change", true);
                break;
            case "Cylinder":
                objectsAnimator = cylinderObjects.GetComponent<Animator>();
                objectsAnimator.SetBool("Change", true);
                break;
            case "Sphere":
                objectsAnimator = sphereObjects.GetComponent<Animator>();
                objectsAnimator.SetBool("Change", true);
                break;
            case "Cone":
                objectsAnimator = coneObjects.GetComponent<Animator>();
                objectsAnimator.SetBool("Change", true);
                break;
            default:
                break;
        }        
    }

}
