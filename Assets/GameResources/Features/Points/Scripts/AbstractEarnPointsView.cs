namespace LearningSkillsTest.Features.Points
{
    using UnityEngine;

    /// <summary>
    /// Вьшка для заработка очков.
    /// </summary>
    public abstract class AbstractEarnPointsView : MonoBehaviour
    {
        [SerializeField]
        protected int _earnPointsCount = 1;
        [SerializeField]
        protected string _pointsId = default;

        protected PointsPresenter _pointsPresenter = default;

        protected virtual void Awake() => _pointsPresenter = FindObjectOfType<PointsPresenter>();

        /// <summary>
        /// Заработать очки.
        /// </summary>
        protected abstract void EarnPoints();
    }
}