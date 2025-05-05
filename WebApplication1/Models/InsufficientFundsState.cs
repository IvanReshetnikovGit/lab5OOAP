using WebApplication1.Interfaces;
namespace WebApplication1.Models
{
    public class InsufficientFundsState : IVendingMachineState
    {
        public string Handle(VendingMachineContext context, decimal insertedMoney, decimal itemPrice)
        {
            return $"Недостатньо коштів. Ціна товару: {itemPrice} грн, внесено: {insertedMoney} грн.";
        }
    }
}
