namespace LearningSkillsTest.Features.Points
{
    using UnityEngine;

    /// <summary>
    /// ����� ��� ��������� �����.
    /// </summary>
    public abstract class AbstractEarnPointsView : MonoBehaviour
    {
        [SerializeField]
        protected PointsPresenter _pointsPresenter = default;
        [SerializeField]
        protected int _earnPointsCount = 1;
        [SerializeField]
        protected string _pointsId = default;

        /// <summary>
        /// ���������� ����.
        /// </summary>
        protected abstract void EarnPoints();
    }
}