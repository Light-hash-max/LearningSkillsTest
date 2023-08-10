namespace LearningSkillsTest.Features.Skills
{
    using UnityEngine;
    using UnityEngine.UI;

    /// <summary>
    /// Кнопка "забыть все навыки".
    /// </summary>
    [RequireComponent(typeof(Button))]
    public sealed class ButtonForgetAllSkillsView : AbstractForgetAllSkillsView
    {
        private Button _button = default;

        protected override void Awake()
        {
            base.Awake();
            _button = GetComponent<Button>();
            _button.onClick.AddListener(ForgetAllSkills);
        }

        private void OnDestroy() => _button.onClick.RemoveListener(ForgetAllSkills);
    }
}