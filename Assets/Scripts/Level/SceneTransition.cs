using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public string sceneToLoad;
    public string entryPoint;

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.CompareTag(Constants.TAG_PLAYER) && !collision.isTrigger) {
            Context.GetPlayer().entryPoint = entryPoint;
            Context.GetUiManager().FadeIn();
            StartCoroutine(loadScene());
        }
    }

    private IEnumerator loadScene() {
        yield return new WaitForSeconds(0.2f);
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneToLoad);
        while (!operation.isDone) {
            yield return null;
        }
    }

}
