using UnityEngine;
using UnityEngine.UI;

public class ButtonTextManager : MonoBehaviour
{
    public Text buttonText; // 버튼 텍스트를 저장할 변수

    // 이벤트 처리 함수 예시
    public void OnButtonClick()
    {
        // 버튼이 클릭될 때 실행되는 함수
        // 버튼 텍스트 변경 예시
        buttonText.text = "!test!";
    }
}