using UnityEngine;
using UnityEngine.SceneManagement; // 씬 관리 네임스페이스

public class SceneChanger : MonoBehaviour
{
    // 버튼 클릭 시 실행할 함수
    public void LoadScene(string SampleScene)
    {
        SceneManager.LoadScene(SampleScene);
    }
}