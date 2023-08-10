namespace LearningSkillsTest.Features.Skills
{
    using UnityEngine;
    using UnityEngine.UI;

    /// <summary>
    /// Забыть навык через кнопку.
    /// </summary>
    public class ButtonForgetSkillView : AbstractForgetSkillView
    {
        [SerializeField]
        private Button _forgetButton = null;

        protected override void Awake()
        {
            base.Awake();
            _forgetButton.onClick.AddListener(ForgetSkill);
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();
            _forgetButton.onClick.RemoveListener(ForgetSkill);
        }

        protected override void ActivateView() => _forgetButton.gameObject.SetActive(true);

        protected override void DeactivateView() => _forgetButton.gameObject.SetActive(false);
    }
}