using UnityEngine;

public class Figures : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        DisableTargets();
        Animator animator = GetComponent<Animator>();
        animator.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DisableTargets()
    {
        GameObject[] targets = GameObject.FindGameObjectsWithTag("Target");
        for (int i = 0; i < targets.Length; i++)
        {
            if (targets[i].name != name + "Target")
            {
                targets[i].SetActive(false);
            }
        }
    }

}
