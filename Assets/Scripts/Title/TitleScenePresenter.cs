using UnityEngine; 
using R3;

namespace Title
{
    using Cysharp.Threading.Tasks;
    using UnityEngine.SceneManagement;
    using View;
    public class TitleScenePresenter : MonoBehaviour
    {
        [SerializeField]
        TitleSceneView titleSceneView;

        void Start()
        {
            titleSceneView.StartButton
                .OnClickAsObservable()
                .SubscribeAwait(async (_, ct) =>
                {
                    // シーンの移動を行う
                    await SceneManager.LoadSceneAsync("GameScene", LoadSceneMode.Single).WithCancellation(ct);
                }, AwaitOperation.Drop);
        }
    }
}