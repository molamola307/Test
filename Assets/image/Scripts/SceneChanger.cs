using UnityEngine;
using UnityEngine.SceneManagement; // �� ���� ���ӽ����̽�

public class SceneChanger : MonoBehaviour
{
    // ��ư Ŭ�� �� ������ �Լ�
    public void LoadScene(string SampleScene)
    {
        SceneManager.LoadScene(SampleScene);
    }
}