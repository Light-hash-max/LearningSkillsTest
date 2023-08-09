namespace LearningSkillsTest.Features.Points
{
    using UnityEngine;
    using UnityEngine.UI;

    /// <summary>
    /// Кнопка для заработка очков.
    /// </summary>
    [RequireComponent(typeof(Button))]
    public sealed class ButtonEarnPointsView : AbstractEarnPointsView
    {
        private Button _earnButton = null;

        private void Awake()
        {
            _earnButton = GetComponent<Button>();
            _earnButton.onClick.AddListener(EarnPoints);
        }

        private void OnDestroy() => _earnButton.onClick.RemoveListener(EarnPoints);

        protected override void EarnPoints() => _pointsPresenter.AddPoints(_pointsId, _earnPointsCount);
    }
}