using NavigationDrawer.UI;
using UnityEngine;
using UnityEngine.UI;

namespace NavigationDrawer.Controller
{
    public class NavDrawerController : MonoBehaviour
    {
        [SerializeField, Header("Nav panels")]
        public NavDrawerPanelController _navDrawerPanelController;

        [SerializeField]
        public NavDrawerPanel _navDrawerPanel;

        [SerializeField, Header("Nav buttons")]
        public Button _btnProfile;

        [SerializeField]
        public Button _btnRating;

        [SerializeField]
        public Button _btnHelp;

        [SerializeField]
        public Button _btnAbout;

        [SerializeField]
        public Button _btnTerms;

        private void Start()
        {
            _btnProfile.onClick.AddListener(NavDrawerPanelOnProfile);
            _btnRating.onClick.AddListener(NavDrawerPanelOnRating);
            _btnHelp.onClick.AddListener(NavDrawerPanelOnHelp);
            _btnAbout.onClick.AddListener(NavDrawerPanelOnAbout);
            _btnTerms.onClick.AddListener(NavDrawerPanelOnTerms);
        }

        public void InitNavDrawer()
        {
            _navDrawerPanel.Open();
        }

        public void CloseAllPanel()
        {
            _navDrawerPanelController.CloseAllPanel();
        }

        private void NavDrawerPanelOnProfile()
        {
            _navDrawerPanelController.OpenProfilePanel();
        }

        private void NavDrawerPanelOnRating()
        {
            _navDrawerPanelController.OpenRatingPanel();
        }

        private void NavDrawerPanelOnHelp()
        {
            _navDrawerPanelController.OpenHelpPanel();
        }

        private void NavDrawerPanelOnAbout()
        {
            _navDrawerPanelController.OpenAboutPanel();
        }

        private void NavDrawerPanelOnTerms()
        {
            _navDrawerPanelController.OpenTermsPanel();
        }
    }
}
