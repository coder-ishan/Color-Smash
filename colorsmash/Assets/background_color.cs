using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class background_color : MonoBehaviour
{
    private SpriteRenderer bgrender;
   private float timesincechange = 0;
    public float timetochange = 0.1f;
    private int m;
    IEnumerator NextLevelAfterWait()
    {
        yield return new WaitForSeconds(0.5f);

        SceneManager.LoadScene("Game");
    }

    private void Awake()
    {
        bgrender = GetComponent <SpriteRenderer>();
    }
    Color[] colors = { new Color(0, 1, 0, 1), new Color(1, 0, 0, 1), new Color(0, 0, 1, 1), new Color(1, 1, 0, 1),new Color(1,0,1,1)};
    void Update()
    {

        
        timesincechange += Time.deltaTime;
        if (timesincechange > timetochange)
        {
         m = Random.Range(0, 5);
            bgrender.color = colors[m];
            StartCoroutine(NextLevelAfterWait());
            timesincechange = 0f;
            

        }
        
    }
}
