using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToOtherScene : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
