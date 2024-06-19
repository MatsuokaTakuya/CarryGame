using UnityEngine;
using UnityEngine.UI;

namespace Title.View
{
    public class TitleSceneView : MonoBehaviour
    {
        [SerializeField]
        Button startButton;
        public Button StartButton => startButton;
    }
}
