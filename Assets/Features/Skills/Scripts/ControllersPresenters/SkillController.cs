namespace LearningSkillsTest.Features.Skills
{
    using LearningSkillsTest.Features.Points;
    using System.Collections.Generic;
    using UnityEngine;

    /// <summary>
    /// Управляет состоянием навыка.
    /// </summary>
    public class SkillController : MonoBehaviour
    {
        /// <summary>
        /// Условие, показывающее приобретен ли текущий навык.
        /// </summary>
        public SkillCompleteCondition CurrentSkilllCompleteCondition => _currentSkilllCompleteCondition;

        /// <summary>
        /// Информация о стоимости навыка.
        /// </summary>
        public CostSkillCondition CostSkillCondition => _costSkill;

        [SerializeField]
        private CostSkillCondition _costSkill = default;
        [SerializeField]
        private List<AbstractSkillCondition> _currentSkillConditions = new List<AbstractSkillCondition>();
        [SerializeField]
        private List<SkillCompleteCondition> _skillsAfterCurrentSkill = new List<SkillCompleteCondition>();

        [SerializeField]
        private SkillCompleteCondition _currentSkilllCompleteCondition = null;

        private SelectedSkillController _selectedSkillController = null;
        private PointsPresenter _pointsPresenter = default;

        private void Awake()
        {
            _selectedSkillController = FindObjectOfType<SelectedSkillController>();
            _pointsPresenter = FindObjectOfType<PointsPresenter>();
        }

        /// <summary>
        /// Проверить навык на готовность к изучению.
        /// </summary>
        /// <returns></returns>
        public bool CheckLearningSkillConditions()
        {
            foreach (AbstractSkillCondition condition in _currentSkillConditions)
            {
                if (!condition.CheckCompetedState())
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Проверить навык на возможность быть забытым.
        /// </summary>
        /// <returns></returns>
        public bool CheckForgettingSkillConditions()
        {
            foreach (SkillCompleteCondition skill in _skillsAfterCurrentSkill)
            {
                if (skill.CheckCompetedState())
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Выбрать навык.
        /// </summary>
        public void SetSkillActive() => _selectedSkillController.SetCurrentSkill(this);

        /// <summary>
        /// Приобрести навык.
        /// </summary>
        public virtual void PurchaseSkill()
        {
            _pointsPresenter.RemovePoints(_costSkill.Points.PointsId, _costSkill.SkillCost);
            _currentSkilllCompleteCondition.ChangeComleteState(true);
        }

        /// <summary>
        /// Забыть навык.
        /// </summary>
        public virtual void ForgetSkill()
        {
            _pointsPresenter.AddPoints(_costSkill.Points.PointsId, _costSkill.SkillCost);
            _currentSkilllCompleteCondition.ChangeComleteState(false);
        }
    }
}
