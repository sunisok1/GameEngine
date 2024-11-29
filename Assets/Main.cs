using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{
    private async void Start()
    {
        await UniTask.WaitForSeconds(2);
        SceneManager.LoadScene("Scene/GameHall");
    }
}