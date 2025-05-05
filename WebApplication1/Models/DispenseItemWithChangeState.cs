using WebApplication1.Interfaces;
namespace WebApplication1.Models
{
    public class DispenseItemWithChangeState : IVendingMachineState
    {
        public string Handle(VendingMachineContext context, decimal insertedMoney, decimal itemPrice)
        {
            var change = insertedMoney - itemPrice;
            return $"Товар видано. Ваша здача: {change} грн.";
        }
    }
}
