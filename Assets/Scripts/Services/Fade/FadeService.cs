using DG.Tweening;
using UnityEngine.UI;
using System.Threading.Tasks;

public class FadeService : IFadeService
{
    public async Task FadeIn(Image image, float duration)
    {
        image.gameObject.SetActive(true);
        await image.DOFade(1f, duration).AsyncWaitForCompletion();
    }

    public async Task FadeOut(Image image, float duration)
    {
        await image.DOFade(0f, duration).AsyncWaitForCompletion();
        image.gameObject.SetActive(false);
    }
}