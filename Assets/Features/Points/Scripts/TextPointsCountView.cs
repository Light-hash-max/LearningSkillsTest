namespace LearningSkillsTest.Features.Points
{
    using UnityEngine;
    using UnityEngine.UI;

    /// <summary>
    /// ������ ���������� ����� � ���� ������.
    /// </summary>
    [RequireComponent(typeof(Text))]
    public sealed class TextPointsCountView : AbstractPointsCountView
    {
        private Text _pointsCountText = null;

        protected override void Awake()
        {
            base.Awake();
            _pointsCountText = GetComponent<Text>();
            UpdateView();
        }

        protected override void UpdateView() => _pointsCountText.text = _pointsModel.PointsCount.ToString();
    }
}