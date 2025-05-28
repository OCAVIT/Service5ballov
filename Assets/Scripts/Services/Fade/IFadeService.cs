using UnityEngine.UI;
using System.Threading.Tasks;

public interface IFadeService
{
    Task FadeIn(Image image, float duration);
    Task FadeOut(Image image, float duration);
}