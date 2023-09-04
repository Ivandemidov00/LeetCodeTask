namespace SolutionHelper;
/// <summary>
/// Базовый класс решений
/// </summary>
/// <typeparam name="TInput">Тип входящих параметров</typeparam>
/// <typeparam name="TOutput">Тип ответа</typeparam>
public interface ISolution<in TInput, out TOutput>
{
    public TOutput Resolve(TInput parameter);
}