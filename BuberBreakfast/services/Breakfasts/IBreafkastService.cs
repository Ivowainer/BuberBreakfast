namespace BuberBreakfast.services.Breakfasts;

using BuberBreakfast.Models;

public interface IBreakfastService
{
    void CreateBreakfast(Breakfast breakfast);
    Breakfast GetBreakfast(Guid id);
    Breakfast UpsertBreakfast(Breakfast breakfast);
}
