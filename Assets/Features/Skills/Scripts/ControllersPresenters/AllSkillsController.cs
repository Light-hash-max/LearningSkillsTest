namespace LearningSkillsTest.Features.Skills
{
    using LearningSkillsTest.Features.Points;
    using System.Collections.Generic;
    using UnityEngine;

    /// <summary>
    /// Контроллер всеми навыками.
    /// </summary>
    public class AllSkillsController : MonoBehaviour
    {
        [SerializeField]
        protected OneTypePointsSkills[] _allSkills = default;

        protected PointsPresenter _pointsPresenter = null;
        protected SelectedSkillController _selectedSkillController = default;

        protected virtual void Awake()
        {
            _pointsPresenter = FindObjectOfType<PointsPresenter>();
            _selectedSkillController = FindObjectOfType<SelectedSkillController>();
        }

        /// <summary>
        /// Забыть все навыки.
        /// </summary>
        public void ForgetAllSkills()
        {
            foreach (OneTypePointsSkills skills in _allSkills)
            {
                ForgetSkills(skills);
            }

            _selectedSkillController.UpdateCurrentSkillActiveState();
        }

        protected void ForgetSkills(OneTypePointsSkills oneTypePointsSkills)
        {
            foreach(SkillWithCost skill in oneTypePointsSkills.Skills)
            {
                if (skill.CompleteCondition.IsCompleted)
                {
                    _pointsPresenter.AddPoints(oneTypePointsSkills.PointsModel.PointsId, skill.CostSkillCondition.SkillCost);
                    skill.CompleteCondition.ChangeComleteState(false);
                }
            }
        }
    }
}
