using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{
    private Animator anim;
    public int levelToLoad;

    public Vector3 position;
    public VectorValue positionStorage;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void FadeToLevel()
    {
        anim.SetTrigger("fade");
    }

    public void OnFadeComplete()
    {
        positionStorage.initialPosition = position;
        SceneManager.LoadScene(levelToLoad);
    }
}
