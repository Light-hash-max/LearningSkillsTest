namespace LearningSkillsTest.Features.Skills
{
    using UnityEngine;

    /// <summary>
    /// Вьюшка приобретения навыка.
    /// </summary>
    public abstract class AbstractPurchaseSkillView : MonoBehaviour
    {
        protected SelectedSkillController _selectedSkillController = default;

        protected virtual void Awake()
        {
            _selectedSkillController = FindObjectOfType<SelectedSkillController>();
            _selectedSkillController.onActiveSkillChanged += ChangeActiveViewState;
        }

        protected virtual void OnDestroy() => _selectedSkillController.onActiveSkillChanged -= ChangeActiveViewState;

        /// <summary>
        /// Изменяет состояние вьюшки в зависимости от того, доступна ли она для приобретения.
        /// </summary>
        protected virtual void ChangeActiveViewState()
        {
            if (_selectedSkillController.CurrentSkill.CheckLearningSkillConditions() && !_selectedSkillController.CurrentSkill.CurrentSkilllCompleteCondition.IsCompleted)
            {
                ActivateView();
            }
            else
            {
                DeactivateView();
            }
        }

        /// <summary>
        /// Включить вьюшку.
        /// </summary>
        protected abstract void ActivateView();

        /// <summary>
        /// Выключить вьюшку.
        /// </summary>
        protected abstract void DeactivateView();

        /// <summary>
        /// Приобрести навык.
        /// </summary>
        protected virtual void PurchaseSkill() => _selectedSkillController.PurchaseCurrentSkill();
    }
}