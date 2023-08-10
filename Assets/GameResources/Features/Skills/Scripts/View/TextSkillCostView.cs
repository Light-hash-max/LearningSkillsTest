namespace LearningSkillsTest.Features.Skills
{
    using UnityEngine;
    using UnityEngine.UI;

    /// <summary>
    /// Отображение стоимости навыка через текст.
    /// </summary>
    [RequireComponent(typeof(Text))]
    public sealed class TextSkillCostView : AbstractSkillCostView
    {
        private const string DEFAULT_FORMAT = "SKILL COST: {0}";

        [SerializeField]
        private string _formatText = DEFAULT_FORMAT;

        private Text _skillText = default;

        protected override void Awake()
        {
            base.Awake();
            _skillText = GetComponent<Text>();
        }

        protected override void UpdateSkillCostView() => _skillText.text = string.Format(_formatText, _selectedSkillController.CurrentSkill.CostSkillCondition.SkillCost);
    }
}