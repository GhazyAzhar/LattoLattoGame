using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevelx : MonoBehaviour
{
    public void LoadLevelNumber(int _index)
    {
        SceneManager.LoadScene(_index);
    }
}