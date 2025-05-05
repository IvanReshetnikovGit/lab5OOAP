using WebApplication1.Interfaces;
namespace WebApplication1.Models
{
    public class WaitingForPaymentState : IVendingMachineState
    {
        public string Handle(VendingMachineContext context, decimal insertedMoney, decimal itemPrice)
        {
            if (insertedMoney < itemPrice)
            {
                context.State = new InsufficientFundsState();
            }
            else if (insertedMoney == itemPrice)
            {
                context.State = new DispenseItemState();
            }
            else
            {
                context.State = new DispenseItemWithChangeState();
            }

            return context.State.Handle(context, insertedMoney, itemPrice);
        }
    }
}
