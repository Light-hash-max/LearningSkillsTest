namespace LearningSkillsTest.Features.Skills
{
    using UnityEngine;

    /// <summary>
    /// Отображение стоимости навыка.
    /// </summary>
    public abstract class AbstractSkillCostView : MonoBehaviour
    {
        protected SelectedSkillController _selectedSkillController = default;

        protected virtual void Awake()
        {
            _selectedSkillController = FindObjectOfType<SelectedSkillController>();
            _selectedSkillController.onActiveSkillChanged += UpdateSkillCostView;
        }

        protected virtual void OnDestroy() => _selectedSkillController.onActiveSkillChanged -= UpdateSkillCostView;

        /// <summary>
        /// Обновить вьюшку стоимости навыка.
        /// </summary>
        protected abstract void UpdateSkillCostView();
    }
}