using System.Collections;
using Loading;
using UnityEngine;

namespace NavigationDrawer.Controller
{
    public class MainController : MonoBehaviour
    {
        [SerializeField, Header("Controllers")]
        private NavDrawerController _navDrawerController;

        private IEnumerator Start()
        {
            LoadingPanel.Instance.LoadingStart(ELoading.LoadData);

            yield return StartCoroutine(InitAsync());

            LoadingPanel.Instance.LoadingStop();
        }

        private IEnumerator InitAsync()
        {
            yield return new WaitForSeconds(2.0f);

            Initialize();
        }

        private void Initialize()
        {
            _navDrawerController.InitNavDrawer();
        }
    }
}
