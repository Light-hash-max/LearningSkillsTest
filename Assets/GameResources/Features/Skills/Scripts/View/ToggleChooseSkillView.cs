namespace LearningSkillsTest.Features.Skills
{
    using UnityEngine;
    using UnityEngine.UI;

    /// <summary>
    /// Тоггл выбора навыка.
    /// </summary>
    [RequireComponent(typeof(Toggle))]
    public sealed class ToggleChooseSkillView : AbstractChooseSkillView
    {
        private Toggle _toggle = default;

        private void Start()
        {
            _toggle = GetComponent<Toggle>();
            _toggle.onValueChanged.AddListener(SelectSkill);
            SelectSkill(_toggle.isOn);
        }

        private void OnDestroy() => _toggle.onValueChanged.RemoveListener(SelectSkill);

        private void SelectSkill(bool isOn)
        {
            if (isOn)
            {
                ChooseSkil();
            }
        }

        protected override void ChooseSkil() => _skillController.SetSkillActive();
    }
}