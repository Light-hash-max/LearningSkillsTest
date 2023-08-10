namespace LearningSkillsTest.Features.Skills
{
    using UnityEngine;
    using UnityEngine.UI;

    /// <summary>
    /// Приобретения навыка через кнопку.
    /// </summary>
    public sealed class ButtonPurchaseSkillView : AbstractPurchaseSkillView
    {
        [SerializeField]
        private Button _purchaseButton = null;

        protected override void Awake()
        {
            base.Awake();
            _purchaseButton.onClick.AddListener(PurchaseSkill);
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();
            _purchaseButton.onClick.RemoveListener(PurchaseSkill);
        }

        protected override void ActivateView() => _purchaseButton.gameObject.SetActive(true);

        protected override void DeactivateView() => _purchaseButton.gameObject.SetActive(false);
    }
}